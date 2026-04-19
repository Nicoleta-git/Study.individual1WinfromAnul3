USE DarwinDB;
GO

CREATE VIEW v_DetaliiComenziCompleta AS
SELECT 
    C.ID_Comanda,
    CL.Nume + ' ' + CL.Prenume AS NumeClient,
    P.NumeProdus,
    P.Categorie,
    C.Cantitate,
    C.PretVanzare,
    C.PretTotal,
    C.DataComanda,
    C.SistemOperare
FROM Comenzi C
JOIN Clienti CL ON C.ID_Client = CL.ID_Client
JOIN Produse P ON C.ID_Produs = P.ID_Produs;
GO

CREATE VIEW v_DetaliiComenziCorrect AS
SELECT 
    C.ID_Comanda,
    P.NumeProdus,
    P.Producator,
    C.PretVanzare,
    C.Cantitate,
    C.PretTotal,
    C.DataComanda
FROM Comenzi C
JOIN Produse P ON C.ID_Produs = P.ID_Produs;
GO

CREATE VIEW View_IstoricComenziUtilizator AS
SELECT 
    CL.ID_Utilizator,
    P.NumeProdus,
    C.Cantitate,
    C.PretTotal,
    C.DataComanda,
    C.SistemOperare
FROM Comenzi C
JOIN Clienti CL ON C.ID_Client = CL.ID_Client
JOIN Produse P ON C.ID_Produs = P.ID_Produs;
GO
