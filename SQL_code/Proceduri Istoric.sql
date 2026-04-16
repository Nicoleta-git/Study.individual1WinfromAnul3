CREATE PROCEDURE sp_StergeComandaDinIstoric
    @idComanda INT,
    @idUtilizator INT
AS
BEGIN
    DELETE FROM Comenzi 
    WHERE ID_Comanda = @idComanda AND ID_Client = @idUtilizator;
END;


CREATE PROCEDURE sp_StergeComandaDinIstoric
    @idComanda INT,
    @idUtilizator INT
AS
BEGIN
    DELETE FROM Comenzi 
    WHERE ID_Comanda = @idComanda AND ID_Client = @idUtilizator;
END;


CREATE PROCEDURE sp_GetStatisticiUtilizator
    @idUtilizator INT
AS
BEGIN
    SELECT 
        ISNULL(SUM(PretTotal), 0) AS TotalCheltuit,
        ISNULL(SUM(Cantitate), 0) AS TotalProduseCumparate,
        COUNT(ID_Comanda) AS NumarComenzi
    FROM Comenzi
    WHERE ID_Client = @idUtilizator;
END;


CREATE PROCEDURE sp_RestituireComanda
    @idComanda INT,
    @idUtilizator INT
AS
BEGIN
    DECLARE @idProdus INT, @cantitate INT;

    SELECT @idProdus = ID_Produs, @cantitate = Cantitate 
    FROM Comenzi WHERE ID_Comanda = @idComanda;

    -- 1. Ștergem comanda
    DELETE FROM Comenzi WHERE ID_Comanda = @idComanda AND ID_Client = @idUtilizator;

    UPDATE Produse 
    SET Stoc = Stoc + @cantitate 
    WHERE ID_Produs = @idProdus;
END;