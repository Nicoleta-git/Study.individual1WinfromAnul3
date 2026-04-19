USE DarwinDB;
GO

CREATE PROCEDURE sp_GetDashboardStats
AS
BEGIN
    SET NOCOUNT ON;
    
    SELECT 
        (SELECT COUNT(*) FROM Utilizatori) AS TotalUtilizatori,
        ISNULL((SELECT SUM(PretTotal) FROM Comenzi), 0) AS VenitTotal,
        (SELECT 8900) AS VizitatoriTotali;

    SELECT SistemOperare, COUNT(*) as Numar FROM Comenzi GROUP BY SistemOperare;

    SELECT 
        DATENAME(MONTH, DataComanda) as Luna, 
        SUM(Cantitate) as TotalVanzari
    FROM Comenzi
    WHERE DataComanda >= DATEADD(MONTH, -4, GETDATE())
    GROUP BY DATENAME(MONTH, DataComanda), MONTH(DataComanda)
    ORDER BY MONTH(DataComanda) DESC;
END;
GO

CREATE VIEW v_RaportStocCritic AS
SELECT NumeProdus, Stoc, Categorie FROM Produse WHERE Stoc < 5;
GO

CREATE VIEW v_PerformantaCategorii AS
SELECT Categorie, SUM(Cantitate) as UnitatiVandute, ISNULL(SUM(PretTotal), 0) as TotalIncasat
FROM Produse P
JOIN Comenzi C ON P.ID_Produs = C.ID_Produs
GROUP BY Categorie;
GO

CREATE PROCEDURE sp_LogareUtilizator
    @User NVARCHAR(100),
    @Pass NVARCHAR(255)
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @HashedPass NVARCHAR(255) = CONVERT(NVARCHAR(255), HASHBYTES('SHA2_512', @Pass), 2);

    SELECT U.ID_Utilizator, U.Username, R.NumeRol 
    FROM Utilizatori U
    JOIN Roluri R ON U.ID_Rol = R.ID_Rol
    WHERE U.Username = @User AND U.Parola = @HashedPass;
END;
GO

CREATE PROCEDURE sp_GetUserDashboardStats
    @ID_Utilizator INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT 
        COUNT(C.ID_Comanda) AS TotalCumparaturi,
        ISNULL(SUM(C.PretTotal), 0) AS BaniCheltuiti,
        ISNULL(SUM(C.Cantitate), 0) AS TotalProduseCumparate
    FROM Comenzi C
    JOIN Clienti CL ON C.ID_Client = CL.ID_Client
    WHERE CL.ID_Utilizator = @ID_Utilizator;

    SELECT TOP 1 P.NumeProdus AS ProdusPreferat
    FROM Produse P
    JOIN Comenzi C ON P.ID_Produs = C.ID_Produs
    JOIN Clienti CL ON C.ID_Client = CL.ID_Client
    WHERE CL.ID_Utilizator = @ID_Utilizator
    GROUP BY P.NumeProdus ORDER BY COUNT(*) DESC;
END;
GO

CREATE PROCEDURE sp_EfectueazaCumparatura
    @ID_Utilizator INT,
    @ID_Produs INT,
    @Cantitate INT,
    @SistemOperare NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;
    BEGIN TRANSACTION;
    BEGIN TRY
        IF (SELECT Stoc FROM Produse WHERE ID_Produs = @ID_Produs) >= @Cantitate
        BEGIN
            UPDATE Produse SET Stoc = Stoc - @Cantitate WHERE ID_Produs = @ID_Produs;

            INSERT INTO Comenzi (ID_Client, ID_Produs, Cantitate, PretVanzare, SistemOperare)
            SELECT 
                (SELECT ID_Client FROM Clienti WHERE ID_Utilizator = @ID_Utilizator),
                @ID_Produs, @Cantitate, 
                (SELECT Pret FROM Produse WHERE ID_Produs = @ID_Produs), @SistemOperare;

            COMMIT TRANSACTION;
            SELECT 'Success' AS Status; 
        END
        ELSE
        BEGIN
            ROLLBACK TRANSACTION;
            RAISERROR('Stoc insuficient!', 16, 1);
        END
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
GO

CREATE PROCEDURE sp_RestituireComanda
    @idComanda INT,
    @idUtilizator INT
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @idProdus INT, @cantitate INT;

    SELECT @idProdus = ID_Produs, @cantitate = Cantitate 
    FROM Comenzi WHERE ID_Comanda = @idComanda;

    IF @idProdus IS NOT NULL
    BEGIN
        DELETE FROM Comenzi 
        WHERE ID_Comanda = @idComanda 
        AND ID_Client = (SELECT ID_Client FROM Clienti WHERE ID_Utilizator = @idUtilizator);

        UPDATE Produse 
        SET Stoc = Stoc + @cantitate 
        WHERE ID_Produs = @idProdus;
    END
END;
GO

CREATE PROCEDURE sp_StergeComandaDinIstoric
    @idComanda INT,
    @idUtilizator INT
AS
BEGIN
    SET NOCOUNT ON;
    DELETE FROM Comenzi 
    WHERE ID_Comanda = @idComanda 
    AND ID_Client = (SELECT ID_Client FROM Clienti WHERE ID_Utilizator = @idUtilizator);
END;
GO
