<div align="center">

# Darwin

[English](README.md) · [Română](README.ro.md) · **Русский**

Настольное приложение на Windows Forms для магазина электроники: каталог, заказы, клиенты,
сотрудники и отчёты поверх базы данных SQL Server.

![Проект](https://img.shields.io/badge/%D0%9F%D1%80%D0%BE%D0%B5%D0%BA%D1%82-%D0%A3%D1%87%D0%B5%D0%B1%D0%BD%D1%8B%D0%B9-purple?style=for-the-badge)
![C# WinForms](https://img.shields.io/badge/%D0%A2%D0%B5%D1%85%D0%BD%D0%BE%D0%BB%D0%BE%D0%B3%D0%B8%D0%B8-C%23%20%7C%20WinForms-black?style=for-the-badge)
![SQL Server](https://img.shields.io/badge/%D0%91%D0%B0%D0%B7%D0%B0_%D0%B4%D0%B0%D0%BD%D0%BD%D1%8B%D1%85-SQL%20Server-darkblue?style=for-the-badge)
![.NET Framework 4.7.2](https://img.shields.io/badge/.NET_Framework-4.7.2-512bd4?style=for-the-badge)

<img width="1536" alt="Darwin" src="https://github.com/user-attachments/assets/b6955dcb-ed6d-4e0c-b988-71946aa73289" />

</div>

---

## О проекте

Darwin — моя индивидуальная работа по предмету *Визуальное программирование* в CEITI. По
заданию нужно было сделать визуальное приложение на базовых элементах управления; я развила
его в небольшую систему продаж для магазина электроники, где телефоны, ноутбуки и наушники
распределены по аппаратным и программным характеристикам.

Интерфейс построен на Krypton Toolkit вместо стандартного вида Windows Forms: тёмно-фиолетовая
палитра, собственные элементы управления со скруглёнными углами и анимированное боковое меню.
За интерфейсом приложение работает с базой SQL Server, где хранятся товары, заказы, клиенты,
сотрудники и учётные записи пользователей.

> Полный отчёт со снимками всех экранов и разбором кода находится в
> **[docs/RAPORT.md](docs/RAPORT.md)** (на румынском языке).

## Возможности

**Две роли — два интерфейса.** Роль учётной записи считывается из базы при входе и определяет,
какое окно откроется. Администратор попадает в панель управления, обычный пользователь — в
интерфейс магазина.

**Администратор**
- Панель со статистикой и графиками (продажи по месяцам, распределение по операционным системам)
- Полный CRUD по товарам, включая загрузку изображения, которое хранится в базе данных
- CRUD по клиентам, заказам и сотрудникам
- Объявления
- Три отчёта RDLC (клиенты, товары, топ-5 продаваемых товаров) в ReportViewer
- Настройки учётной записи, связанные с базой данных

**Пользователь**
- Регистрация и вход
- Личная панель, независимая от других учётных записей
- Каталог товаров с поиском по названию в реальном времени
- История заказов

## Технологии

| Уровень | Используется |
| --- | --- |
| Язык / среда | C#, .NET Framework 4.7.2 |
| Интерфейс | Windows Forms, Krypton Toolkit, элементы управления, отрисованные через `GraphicsPath` |
| База данных | SQL Server (SQL Server Express / LocalDB), `System.Data.SqlClient` |
| Отчёты | Microsoft ReportViewer и файлы RDLC |
| Графики | Syncfusion SfChart |
| Пространственные типы | Microsoft.SqlServer.Types |

## База данных

Схема лежит в [`SQL_code/DarwinDB.sql`](SQL_code/DarwinDB.sql) и содержит:

- **Таблицы** — `Produse`, `Comenzi`, `Clienti`, `Angajati`, `Utilizatori`, `Roluri`, `Anunturi`
- **Представления** — `View_IstoricComenziUtilizator`, `v_DetaliiComenziCompleta`, `v_DetaliiComenziCorrect`
- **Хранимые процедуры** — `sp_GetStatisticiUtilizator`, `Sp_InsereazaAngajat`, `Sp_InsereazaComanda`,
  `Sp_InsereazaComandaDupaNume`, `sp_RestituireComanda`, `sp_StergeComandaDinIstoric`,
  `sp_TopProduseVandute`

## Как запустить

Понадобятся Visual Studio 2022 с инструментами для .NET Framework 4.7.2 и SQL Server Express
(или LocalDB).

1. **Клонируйте репозиторий**

   ```bash
   git clone https://github.com/Nicoleta-git/Study.individual1WinfromAnul3.git
   ```

2. **Создайте базу данных** — откройте `SQL_code/DarwinDB.sql` в SQL Server Management Studio и
   выполните его. Скрипт создаёт базу `DarwinDB` со всеми таблицами, представлениями и процедурами.

3. **Укажите свой сервер** — строка подключения находится в `indiv1/App.config` и сейчас выглядит так:

   ```
   Data Source=NICOLETA\SQLEXPRESS;Initial Catalog=DarwinDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True
   ```

   Замените `NICOLETA\SQLEXPRESS` на имя своего экземпляра. Та же строка встречается и внутри
   нескольких форм, например в `CatalogUserForm.cs`.

4. **Подключите Krypton Toolkit** — проект ссылается на DLL из локальной копии
   [ComponentFactory/Krypton](https://github.com/ComponentFactory/Krypton), которая лежит вне
   репозитория. Склонируйте её, соберите, затем поправьте пути `HintPath` в
   `indiv1/indiv1.csproj`, чтобы они указывали на вашу папку `Bin`.

5. **Восстановите пакеты NuGet и запустите** — откройте `indiv1.sln` и нажмите F5. Приложение
   стартует с формы `Loading`, а затем открывает окно входа.

## Структура проекта

```
indiv1/
├── Loading.cs                  заставка при запуске
├── LogIn.cs / Register.cs      вход, чтение роли, регистрация
├── SesiuneUtilizator.cs        статическая сессия: id пользователя, роль, логин
├── DashAdmin.cs                окно администратора с боковым меню
├── DashboardAdmin.cs           панель администратора со статистикой и графиками
├── UserInterface.cs            окно пользователя
├── DashUser.cs                 панель пользователя
├── CatalogUserForm.cs          каталог товаров и операции CRUD
├── Produs.cs / Comenzi.cs      управление товарами и заказами
├── ClientiManagement.cs        управление клиентами
├── Angajati.cs                 управление сотрудниками
├── Anunturi.cs                 объявления
├── Rapoarte.cs                 отчёты RDLC в ReportViewer
├── istoric.cs                  история заказов
├── Setari.cs                   настройки учётной записи
├── Filtrare.cs                 фильтрация
├── UcCatalog.cs                пользовательский элемент для каталога
├── *.rdlc                      описания отчётов
├── CirclePanel.cs, RoundedPanel.cs, CustomProgressBar.cs,
│   CustomRoundedComboBox.cs, CustomTabControl.cs,
│   ModernDataGridViewCustom.cs, NeonMenuStrip.cs, menuPanel.cs
│                               собственные элементы, отрисованные через OnPaint
└── Resources/                  иконки и изображения
SQL_code/DarwinDB.sql           полный скрипт базы данных
docs/RAPORT.md                  письменный отчёт
```

## Автор

Автор — [Nicoleta-git](https://github.com/Nicoleta-git), Центр передового опыта в информатике и
информационных технологиях (CEITI), кафедра «Информатика I», Кишинёв, 2026.
