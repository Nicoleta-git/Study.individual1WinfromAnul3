<div align="center">

# Darwin

[English](README.md) · **Română** · [Русский](README.ru.md)

Aplicație desktop Windows Forms pentru un magazin de electronice: catalog, comenzi, clienți,
angajați și rapoarte, peste o bază de date SQL Server.

![Proiect](https://img.shields.io/badge/Proiect-Școală-purple?style=for-the-badge)
![C# WinForms](https://img.shields.io/badge/Tehnologii-C%23%20%7C%20WinForms-black?style=for-the-badge)
![SQL Server](https://img.shields.io/badge/Baz%C4%83_de_date-SQL%20Server-darkblue?style=for-the-badge)
![.NET Framework 4.7.2](https://img.shields.io/badge/.NET_Framework-4.7.2-512bd4?style=for-the-badge)

<img width="1536" alt="Darwin" src="https://github.com/user-attachments/assets/b6955dcb-ed6d-4e0c-b988-71946aa73289" />

</div>

---

## Despre proiect

Darwin este lucrarea mea de studiu individual la disciplina *Programarea vizuală*, la CEITI.
Tema a fost realizarea unei aplicații vizuale cu utilizarea controalelor de bază; am transformat-o
într-un sistem de vânzări pentru un magazin de electronice, unde telefoanele, laptopurile și
căștile sunt organizate după specificațiile lor hardware și software.

Interfața este construită cu Krypton Toolkit în locul aspectului standard Windows Forms, cu o
paletă mov-închis, controale personalizate cu colțuri rotunjite și un meniu lateral animat. În
spate, aplicația comunică cu o bază de date SQL Server care păstrează produsele, comenzile,
clienții, angajații și conturile utilizatorilor.

> Raportul complet, cu capturi de ecran de la fiecare fereastră și explicarea codului, se află
> în **[docs/RAPORT.md](docs/RAPORT.md)**.

## Funcționalități

**Două roluri, două interfețe** — rolul contului este citit din baza de date la autentificare și
decide ce fereastră se deschide. Administratorii primesc panoul de management, utilizatorii
obișnuiți primesc interfața de magazin.

**Administrator**
- Dashboard cu statistici și grafice (vânzări pe luni, distribuția după sistemul de operare)
- CRUD complet pe produse, inclusiv încărcarea unei imagini salvate în baza de date
- CRUD pe clienți, comenzi și angajați
- Anunțuri
- Trei rapoarte RDLC (clienți, produse, top 5 produse vândute) afișate în ReportViewer
- Setările contului, conectate la baza de date

**Utilizator**
- Înregistrare și autentificare
- Dashboard personal, independent de celelalte conturi
- Catalog de produse cu căutare în timp real după nume
- Istoricul comenzilor

## Tehnologii folosite

| Nivel | Folosit |
| --- | --- |
| Limbaj / runtime | C#, .NET Framework 4.7.2 |
| Interfață | Windows Forms, Krypton Toolkit, controale desenate cu `GraphicsPath` |
| Bază de date | SQL Server (SQL Server Express / LocalDB), `System.Data.SqlClient` |
| Rapoarte | Microsoft ReportViewer cu fișiere RDLC |
| Grafice | Syncfusion SfChart |
| Tipuri spațiale | Microsoft.SqlServer.Types |

## Baza de date

Schema se află în [`SQL_code/DarwinDB.sql`](SQL_code/DarwinDB.sql) și conține:

- **Tabele** — `Produse`, `Comenzi`, `Clienti`, `Angajati`, `Utilizatori`, `Roluri`, `Anunturi`
- **Vederi** — `View_IstoricComenziUtilizator`, `v_DetaliiComenziCompleta`, `v_DetaliiComenziCorrect`
- **Proceduri stocate** — `sp_GetStatisticiUtilizator`, `Sp_InsereazaAngajat`, `Sp_InsereazaComanda`,
  `Sp_InsereazaComandaDupaNume`, `sp_RestituireComanda`, `sp_StergeComandaDinIstoric`,
  `sp_TopProduseVandute`

## Cum pornești proiectul

Ai nevoie de Visual Studio 2022 cu uneltele pentru .NET Framework 4.7.2 și de SQL Server
Express (sau LocalDB).

1. **Clonează depozitul**

   ```bash
   git clone https://github.com/Nicoleta-git/Study.individual1WinfromAnul3.git
   ```

2. **Creează baza de date** — deschide `SQL_code/DarwinDB.sql` în SQL Server Management Studio
   și rulează-l. Scriptul creează baza `DarwinDB` cu toate tabelele, vederile și procedurile.

3. **Indică serverul tău** — string-ul de conexiune se află în `indiv1/App.config` și este acum:

   ```
   Data Source=NICOLETA\SQLEXPRESS;Initial Catalog=DarwinDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True
   ```

   Înlocuiește `NICOLETA\SQLEXPRESS` cu numele instanței tale. Același string apare și în
   câteva formulare, de exemplu în `CatalogUserForm.cs`.

4. **Adaugă Krypton Toolkit** — proiectul referențiază DLL-urile dintr-o copie locală a
   [ComponentFactory/Krypton](https://github.com/ComponentFactory/Krypton) aflată în afara
   depozitului. Clonează-o, compileaz-o, apoi corectează căile `HintPath` din
   `indiv1/indiv1.csproj` ca să indice spre folderul tău `Bin`.

5. **Restaurează pachetele NuGet și rulează** — deschide `indiv1.sln` și apasă F5. Aplicația
   pornește cu formularul `Loading`, apoi deschide fereastra de autentificare.

## Structura proiectului

```
indiv1/
├── Loading.cs                  ecranul de pornire
├── LogIn.cs / Register.cs      autentificare, citirea rolului, înregistrare
├── SesiuneUtilizator.cs        sesiune statică: id utilizator, rol, username
├── DashAdmin.cs                fereastra de administrator cu meniul lateral
├── DashboardAdmin.cs           dashboard-ul de admin cu statistici și grafice
├── UserInterface.cs            fereastra utilizatorului
├── DashUser.cs                 dashboard-ul utilizatorului
├── CatalogUserForm.cs          catalogul de produse și operațiile CRUD
├── Produs.cs / Comenzi.cs      gestiunea produselor și a comenzilor
├── ClientiManagement.cs        gestiunea clienților
├── Angajati.cs                 gestiunea angajaților
├── Anunturi.cs                 anunțuri
├── Rapoarte.cs                 rapoarte RDLC în ReportViewer
├── istoric.cs                  istoricul comenzilor
├── Setari.cs                   setările contului
├── Filtrare.cs                 filtrare
├── UcCatalog.cs                user control pentru catalog
├── *.rdlc                      definițiile rapoartelor
├── CirclePanel.cs, RoundedPanel.cs, CustomProgressBar.cs,
│   CustomRoundedComboBox.cs, CustomTabControl.cs,
│   ModernDataGridViewCustom.cs, NeonMenuStrip.cs, menuPanel.cs
│                               controale personalizate desenate prin OnPaint
└── Resources/                  iconițe și imagini
SQL_code/DarwinDB.sql           scriptul complet al bazei de date
docs/RAPORT.md                  raportul scris
```

## Autor

Realizat de [Nicoleta-git](https://github.com/Nicoleta-git) — Centrul de Excelență în
Informatică și Tehnologii Informaționale (CEITI), Catedra Informatică I, Chișinău, 2026.
