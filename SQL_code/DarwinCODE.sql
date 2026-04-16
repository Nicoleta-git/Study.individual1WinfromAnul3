-- =========================================
-- 1. CREARE BAZA DE DATE
-- =========================================
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'DarwinDB')
BEGIN
    CREATE DATABASE DarwinDB;
END
GO

USE DarwinDB;
GO

-- =========================================
-- 2. TABELE
-- =========================================

-- 1. Roluri
CREATE TABLE Roluri (
    ID_Rol INT PRIMARY KEY IDENTITY(1,1),
    NumeRol NVARCHAR(50) NOT NULL 
        CHECK (NumeRol IN ('Admin','User'))
);

-- 2. Utilizatori
CREATE TABLE Utilizatori (
    ID_Utilizator INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(100) UNIQUE NOT NULL,
    Parola NVARCHAR(255) NOT NULL,
    Email NVARCHAR(150) UNIQUE NOT NULL,
    ID_Rol INT NOT NULL,
    DataCreare DATETIME DEFAULT GETDATE(),

    FOREIGN KEY (ID_Rol) REFERENCES Roluri(ID_Rol)
);

-- 3. Angajati (LEGAT 1-la-1 cu Utilizatori)
CREATE TABLE Angajati (
    ID_Angajat INT PRIMARY KEY IDENTITY(1,1),

    ID_Utilizator INT UNIQUE NOT NULL,

    Nume NVARCHAR(100) NOT NULL,
    Prenume NVARCHAR(100) NOT NULL,
    Salariu DECIMAL(18,2),
    DataAngajare DATETIME DEFAULT GETDATE(),

    FOREIGN KEY (ID_Utilizator) 
        REFERENCES Utilizatori(ID_Utilizator)
        ON DELETE CASCADE
);

-- 4. Clienti (LEGAT 1-la-1 cu Utilizatori)
CREATE TABLE Clienti (
    ID_Client INT PRIMARY KEY IDENTITY(1,1),

    ID_Utilizator INT UNIQUE NOT NULL,

    Nume NVARCHAR(100),
    Prenume NVARCHAR(100),
    Gen NVARCHAR(10)
        CHECK (Gen IN ('Masculin','Feminin')),
    Telefon NVARCHAR(20),

    FOREIGN KEY (ID_Utilizator)
        REFERENCES Utilizatori(ID_Utilizator)
        ON DELETE CASCADE
);

-- 5. Produse
CREATE TABLE Produse (
    ID_Produs INT PRIMARY KEY IDENTITY(1,1),
    NumeProdus NVARCHAR(200) NOT NULL,
    Categorie NVARCHAR(100) NOT NULL
        CHECK (Categorie IN ('Laptop','Telefon','Casti')),
    Producator NVARCHAR(100),
    Pret DECIMAL(18,2) NOT NULL,
    Stoc INT DEFAULT 0,

    Specificatii_Software NVARCHAR(MAX),
    Specificatii_Hardware NVARCHAR(MAX),

    ImagineProdus VARBINARY(MAX),
    DataAdaugare DATETIME DEFAULT GETDATE()
);

-- 6. Comenzi
CREATE TABLE Comenzi (
    ID_Comanda INT PRIMARY KEY IDENTITY(1,1),

    ID_Client INT NOT NULL,
    ID_Produs INT NOT NULL,

    Cantitate INT NOT NULL,
    PretVanzare DECIMAL(18,2),

    PretTotal AS (Cantitate * PretVanzare),

    DataComanda DATETIME DEFAULT GETDATE(),
    SistemOperare NVARCHAR(50),

    FOREIGN KEY (ID_Client) REFERENCES Clienti(ID_Client),
    FOREIGN KEY (ID_Produs) REFERENCES Produse(ID_Produs)
);

-- 7. Anunturi (postate de admin)
CREATE TABLE Anunturi (
    ID_Anunt INT PRIMARY KEY IDENTITY(1,1),
    Mesaj NVARCHAR(MAX) NOT NULL,
    DataPublicare DATETIME DEFAULT GETDATE(),

    ID_Admin INT,

    FOREIGN KEY (ID_Admin) 
        REFERENCES Utilizatori(ID_Utilizator)
);
GO

-- =========================================
-- 3. POPULARE INITIALA (OBLIGATORIE)
-- =========================================
INSERT INTO Roluri (NumeRol) VALUES ('Admin'), ('User');
GO
-- =========================================
-- 3. LOGICA PENTRU ADMIN (DASHBOARD)
-- =========================================

CREATE PROCEDURE sp_GetDashboardStats
AS
BEGIN
    SET NOCOUNT ON;
    
    -- Panouri de sus
    SELECT 
        (SELECT COUNT(*) FROM Utilizatori) AS TotalUtilizatori,
        ISNULL((SELECT SUM(PretTotal) FROM Comenzi), 0) AS VenitTotal,
        (SELECT 8900) AS VizitatoriTotali;

    -- Grafic OS
    SELECT SistemOperare, COUNT(*) as Numar FROM Comenzi GROUP BY SistemOperare;

    -- Grafic Vanzari Luni
    SELECT 
        DATENAME(MONTH, DataComanda) as Luna, 
        SUM(Cantitate) as TotalVanzari
    FROM Comenzi
    WHERE DataComanda >= DATEADD(MONTH, -4, GETDATE())
    GROUP BY DATENAME(MONTH, DataComanda), MONTH(DataComanda)
    ORDER BY MONTH(DataComanda) DESC;
END;
GO

-- Vederi
CREATE VIEW v_RaportStocCritic AS
SELECT NumeProdus, Stoc, Categorie FROM Produse WHERE Stoc < 5;
GO

CREATE VIEW v_PerformantaCategorii AS
SELECT Categorie, SUM(Cantitate) as UnitatiVandute, ISNULL(SUM(PretTotal), 0) as TotalIncasat
FROM Produse P
JOIN Comenzi C ON P.ID_Produs = C.ID_Produs
GROUP BY Categorie;
GO

-- =========================================
-- 4. LOGICA USER & TRANZACTII
-- =========================================

-- Logare cu Hash
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

-- Statistici User
CREATE PROCEDURE sp_GetUserDashboardStats
    @ID_Utilizator INT
AS
BEGIN
    SET NOCOUNT ON;
    SELECT 
        COUNT(C.ID_Comanda) AS TotalCumparaturi,
        ISNULL(SUM(C.PretTotal), 0) AS BaniCheltuiti
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

-- Cumparare
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