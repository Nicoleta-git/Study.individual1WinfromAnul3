<div align="center">

# Darwin

**English** · [Română](README.ro.md) · [Русский](README.ru.md)

A Windows Forms desktop application for a shop that sells electronics: catalogue, orders,
clients, employees and reports, on top of a SQL Server database.

![Project](https://img.shields.io/badge/Project-School-purple?style=for-the-badge)
![C# WinForms](https://img.shields.io/badge/Tech-C%23%20%7C%20WinForms-black?style=for-the-badge)
![SQL Server](https://img.shields.io/badge/Database-SQL%20Server-darkblue?style=for-the-badge)
![.NET Framework 4.7.2](https://img.shields.io/badge/.NET_Framework-4.7.2-512bd4?style=for-the-badge)

<img width="1536" alt="Darwin" src="https://github.com/user-attachments/assets/b6955dcb-ed6d-4e0c-b988-71946aa73289" />

</div>

---

## About

Darwin is my individual coursework for the *Visual Programming* class at CEITI. The brief was
to build a visual application using the basic controls; I turned it into a small sales system
for an electronics shop, where phones, laptops and headphones are organised by their hardware
and software specifications.

The interface is built with the Krypton Toolkit instead of the stock Windows Forms look, with
a dark purple palette, rounded custom controls and an animated side menu. Behind it, the
application talks to a SQL Server database that stores products, orders, clients, employees
and user accounts.

> The full written report, with screenshots of every screen and the explanation of the code,
> is in **[docs/RAPORT.md](docs/RAPORT.md)** (Romanian).

## Features

**Two roles, two interfaces** — the account role is read from the database at login and decides
which window opens. Administrators get the management dashboard, regular users get the shop
interface.

**Administrator**
- Dashboard with statistics and charts (sales per month, distribution by operating system)
- Full CRUD on products, including uploading a product image stored in the database
- CRUD on clients, orders and employees
- Announcements
- Three RDLC reports (clients, products, top 5 best-selling products) rendered in ReportViewer
- Account settings connected to the database

**User**
- Registration and login
- Personal dashboard, independent of other accounts
- Product catalogue with live search by name
- Order history

## Tech stack

| Layer | Used |
| --- | --- |
| Language / runtime | C#, .NET Framework 4.7.2 |
| UI | Windows Forms, Krypton Toolkit, custom controls drawn with `GraphicsPath` |
| Database | SQL Server (SQL Server Express / LocalDB), `System.Data.SqlClient` |
| Reports | Microsoft ReportViewer with RDLC report files |
| Charts | Syncfusion SfChart |
| Spatial types | Microsoft.SqlServer.Types |

## Database

The schema is in [`SQL_code/DarwinDB.sql`](SQL_code/DarwinDB.sql) and contains:

- **Tables** — `Produse`, `Comenzi`, `Clienti`, `Angajati`, `Utilizatori`, `Roluri`, `Anunturi`
- **Views** — `View_IstoricComenziUtilizator`, `v_DetaliiComenziCompleta`, `v_DetaliiComenziCorrect`
- **Stored procedures** — `sp_GetStatisticiUtilizator`, `Sp_InsereazaAngajat`, `Sp_InsereazaComanda`,
  `Sp_InsereazaComandaDupaNume`, `sp_RestituireComanda`, `sp_StergeComandaDinIstoric`,
  `sp_TopProduseVandute`

## Getting started

You need Visual Studio 2022 with .NET Framework 4.7.2 development tools, and SQL Server
Express (or LocalDB).

1. **Clone the repository**

   ```bash
   git clone https://github.com/Nicoleta-git/Study.individual1WinfromAnul3.git
   ```

2. **Create the database** — open `SQL_code/DarwinDB.sql` in SQL Server Management Studio and
   run it. It creates the `DarwinDB` database with all tables, views and procedures.

3. **Point the application at your server** — the connection string is in `indiv1/App.config`
   and currently reads:

   ```
   Data Source=NICOLETA\SQLEXPRESS;Initial Catalog=DarwinDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True
   ```

   Replace `NICOLETA\SQLEXPRESS` with the name of your own instance. The same string also
   appears inside a few forms, such as `CatalogUserForm.cs`.

4. **Add the Krypton Toolkit** — the project references the DLLs from a local copy of
   [ComponentFactory/Krypton](https://github.com/ComponentFactory/Krypton) that lives outside
   the repository. Clone it, build it, then fix the `HintPath` entries in `indiv1/indiv1.csproj`
   so they point at your `Bin` folder.

5. **Restore the NuGet packages and run** — open `indiv1.sln` and press F5. The application
   starts on the `Loading` form and then opens the login window.

## Project structure

```
indiv1/
├── Loading.cs                  splash screen shown at startup
├── LogIn.cs / Register.cs      authentication, role lookup, sign-up
├── SesiuneUtilizator.cs        static session: user id, role, username
├── DashAdmin.cs                administrator shell with the side menu
├── DashboardAdmin.cs           admin dashboard with statistics and charts
├── UserInterface.cs            user shell
├── DashUser.cs                 user dashboard
├── CatalogUserForm.cs          product catalogue and CRUD
├── Produs.cs / Comenzi.cs      products and orders management
├── ClientiManagement.cs        clients management
├── Angajati.cs                 employees management
├── Anunturi.cs                 announcements
├── Rapoarte.cs                 RDLC reports in ReportViewer
├── istoric.cs                  order history
├── Setari.cs                   account settings
├── Filtrare.cs                 filtering
├── UcCatalog.cs                catalogue user control
├── *.rdlc                      report definitions
├── CirclePanel.cs, RoundedPanel.cs, CustomProgressBar.cs,
│   CustomRoundedComboBox.cs, CustomTabControl.cs,
│   ModernDataGridViewCustom.cs, NeonMenuStrip.cs, menuPanel.cs
│                               custom controls drawn by overriding OnPaint
└── Resources/                  icons and images
SQL_code/DarwinDB.sql           full database script
docs/RAPORT.md                  the written report (Romanian)
```

## Author

Made by [Nicoleta-git](https://github.com/Nicoleta-git) — Centre of Excellence in Informatics
and Information Technologies (CEITI), Informatics I department, Chișinău, 2026.
