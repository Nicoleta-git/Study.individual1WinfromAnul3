# Raport

<div align="center">

### Centrul de Excelență în Informatică și Tehnologii Informaționale
### Catedra Informatică I

<br><br><br><br>

## Lucrare de studiu individual Nr. 1
**Disciplina:** Programarea vizuală 

**Tema:** Aplicație vizuală cu utilizarea controllerelor de bază

<br><br><br><br>

</div>

<div align="right">

**Realizat:** Titei Nicoleta, gr. P-2333
<br>
**Verificat:** Covali Eugenia
<br>
**Nota:** _______________

</div>

<br><br><br><br>

<div align="center">

**Chișinău 2026**

</div>
<br><br><br><br>

## Cuprins
1. [Introducere](#introducere)
2. [Prezentare Generală (Interfață)](#introducere-prezentare-generala)
   * [Loading.cs](#loadingcs)
   * [LogIn.cs](#logincs)
   * [Register.cs](#registercs)
   * [AdminDashbord.cs](#admindashbordcs)
   * [UserInterface.cs](#userinterfacecs)
3. [Componente Utilizate](#comonente-utlizate)
   * [Componente Vizuale și Layout](#componente-vizuale-și-layout-krypton-toolkit)
   * [Elemente de Control Interactive](#elemente-de-control-interactive)
   * [Vizualizarea Datelor (Charts)](#vizualizarea-datelor-charts)
   * [Managementul Produselor](#4-managementul-produselor-cataloguserform)
4. [Logica Codului](#logica-cod)
   * [Implementarea Grafică (OnPaint)](#implementarea-grafică-randarea-marginilor-rotunjite)
   * [Autentificare și Navigare](#logica-de-autentificare-și-navigare)
   * [UserControls și Animații](#navigare-prin-usercontrols-și-animații)
5. [Concluzii](#concluzii)
6. [Bibliografie](#bibliografie--resurse-utilizate)

---

## Introducere

Această lucrare de studiu individual se concentrează pe dezvoltarea unei aplicații desktop dedicate gestiunii proceselor de vânzare pentru compania Darwin. Proiectul a fost gândit special pentru comercializarea dispozitivelor electronice, precum telefoane, laptopuri sau căști, având la bază o structură logică ce permite categorisirea produselor în funcție de specificațiile lor hardware și software.

Din punct de vedere tehnic, am pus un accent deosebit pe crearea unei interfețe grafice moderne, motiv pentru care am ales să folosesc suita de componente Krypton Toolkit. Aceasta mi-a permis să depășesc limitările vizuale standard ale Windows Forms și să implementez elemente mai avansate, cum ar fi paletele de culori personalizate, butoane cu design stilizat și tranziții mai fluide între meniuri, oferind astfel o experiență de utilizare mult mai calitativă. Aplicația are la bază o arhitectură solidă conectată la o bază de date, ceea ce garantează că toate informațiile despre stocuri, conturile utilizatorilor și istoricul comenzilor sunt salvate corect și pot fi accesate oricând.

Un aspect esențial al sistemului este securitatea, realizată printr-o separare clară a rolurilor de acces. Utilizatorii obișnuiți pot naviga prin catalogul de produse și își pot gestiona istoricul personal, în timp ce interfața de administrator oferă un control total. Din panoul de admin, pot fi adăugate sau șterse produse, se pot modifica prețurile în timp real și se poate gestiona întreaga bază de date a clienților.

În final, obiectivele principale pe care le-am urmărit prin acest proiect au fost optimizarea experienței de navigare prin elemente vizuale interactive, eficientizarea modului în care Darwin își gestionează inventarul și, nu în ultimul rând, asigurarea integrității datelor printr-un sistem de autentificare simplu, dar sigur.

---

## Introducere Prezentare generala
### Loading.cs
<img width="836" height="548" alt="{5CEBEFF5-B2DB-4394-AC1A-B0E51A5F8E57}" src="https://github.com/user-attachments/assets/bba91d0c-d989-4d39-a4b0-e01de226285e" />

### LogIn.cs
<img width="399" height="671" alt="{62754516-7B7E-4211-B5F7-314C10DA0D60}" src="https://github.com/user-attachments/assets/9323a53e-a18f-43bf-bc17-4b4eec964235" />

### Register.cs
<img width="386" height="735" alt="{0203B250-3567-4C6C-9F6D-868FEC187A73}" src="https://github.com/user-attachments/assets/9b159aa9-efe0-4da7-bfb3-8595410a3c56" />

### AdminDashbord.cs
<img width="1161" height="781" alt="image" src="https://github.com/user-attachments/assets/51fdceca-7c6a-4f9d-9322-de72643dd76f" />
<img width="1162" height="776" alt="image" src="https://github.com/user-attachments/assets/6d74762e-0b82-438b-840d-aae0cc34dd2a" />
<img width="1158" height="781" alt="image" src="https://github.com/user-attachments/assets/fa924b99-2410-4b4a-b74b-dead7e5d5f5b" />
<img width="1170" height="778" alt="image" src="https://github.com/user-attachments/assets/20402f28-0216-487c-8bc7-b84a189701e5" />
<img width="1171" height="782" alt="image" src="https://github.com/user-attachments/assets/7e581932-0848-4d64-8b5f-666b30e09811" />
<img width="1167" height="782" alt="image" src="https://github.com/user-attachments/assets/3fac8959-47c3-4bd3-bbba-0c9672b74b5b" />
<img width="1158" height="779" alt="image" src="https://github.com/user-attachments/assets/21cbc019-652e-4be0-ba42-3917428ffb50" />

### UserInterface.cs
<img width="1162" height="777" alt="image" src="https://github.com/user-attachments/assets/b8241620-0439-4b7a-9198-e162fcfc988c" />
<img width="1168" height="781" alt="image" src="https://github.com/user-attachments/assets/eb183e4e-0ebe-46b7-a339-ed68bb7331af" />
<img width="1158" height="773" alt="image" src="https://github.com/user-attachments/assets/b64082a4-9652-46b0-b88f-fdc0ce26a3e0" />

## Comonente utlizate
<img width="1181" height="795" alt="image" src="https://github.com/user-attachments/assets/55ba0a09-71de-4cac-a37f-f7f320b9fc6b" />


### **Componente Vizuale și Layout (Krypton Toolkit)**

* **KryptonForm:** Fereastra principală a aplicației care permite personalizarea marginilor și a barei de titlu pentru un aspect modern.
* **KryptonPalette:** Componenta invizibilă care definește tema de culori (negru, mov, gri) aplicată unitar pe toate elementele de control.
* **FlowLayoutPanel (sidebar):** Panoul din partea stângă utilizat pentru alinierea verticală automată a butoanelor de navigare.
* **KryptonPanel (panouri statistice):** Containerele individuale din partea superioară care afișează indicatori precum "Număr utilizatori" sau "Venit total".
* **KryptonGroup / Panel (containere chart):** Zonele delimitate pentru organizarea graficelor.

### **Elemente de Control Interactive**

* **KryptonButton (meniu):** Butoanele din sidebar (Dashboard, Anunțuri, Rapoarte, etc.) care includ iconițe și text, având stări vizuale diferite la trecerea mouse-ului (hover).
* **KryptonButton (Log Out):** Butonul cu colțuri rotunjite (radius mare) și gradient mov situat în partea de jos a meniului.
* **KryptonLabel:** Utilizat pentru titlurile secțiunilor (Pannel, Userform) și pentru afișarea cifrelor statistice mari (ex: 11090, 100k).
* **PictureBox:** Utilizat pentru afișarea logo-ului "Darwin" și a iconițelor reprezentative pentru utilizatori, grafice și grupuri.

### **Vizualizarea Datelor (Charts)**

* **Pie Chart (Grafic circular):** Utilizat pentru distribuția sistemelor de operare (Mac, Windows, Linux).
* **Bar Chart (Grafic cu bare):** Graficul orizontal din partea dreaptă care monitorizează evoluția vânzărilor ("Sales") pe luni (Ianuarie - Aprilie).
* **Legend:** Elementul care explică culorile utilizate în grafice.

### **Organizarea Logică a Interfeței**

* **Header:** Bara superioară unde apare titlul formularului.
* **Sidebar Navigation:** Meniul lateral care separă funcțiile de bază de cele de management (Produse, Clienți, Angajați).
* **Dashboard Body:** Zona centrală unde sunt grupate panourile informative și graficele de analiză a datelor.

<img width="1181" height="795" alt="image (1)" src="https://github.com/user-attachments/assets/477e3c1c-e256-4a96-8056-e57ebb0516d8" />

### 4. Managementul Produselor (CatalogUserForm)

* **DataGridView:** Elementul central marcat în imagine, responsabil pentru afișarea datelor brute din baza de date SQL/LocalDB. Permite sortarea și selectarea rapidă a dispozitivelor.
* **KryptonTextBox:** Câmpurile de editare (`Id produs`, `Nume produs`, `Stock`, etc.) care au marginile personalizate (Mov) pentru a menține estetica **Krypton Palette**.
* **PictureBox (Product Preview):** Zona din dreapta destinată previzualizării imaginii dispozitivului selectat sau pentru importul de noi imagini în baza de date.
* **KryptonButton (CRUD):** Butoanele `Save`, `Update`, `Delete` și `Clear`, grupate orizontal pentru o gestionare eficientă a inventarului.

---

## Logica cod

###  Implementarea Grafică: Randarea Marginilor Rotunjite

Pentru a obține un design modern în cadrul aplicației **Darwin**, am utilizat tehnica de desenare personalizată prin suprascrierea metodei `OnPaint`. Aceasta permite controlul total asupra geometriei elementelor de interfață.

#### Secvența de Cod:

```csharp
protected override void OnPaint(PaintEventArgs e)
{
    base.OnPaint(e);

    // Activăm Anti-Aliasing pentru margini netede (fără efect de scară)
    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias; 

    int inset = 1; // Ajustare pentru precizia conturului
    int r = BorderRadius; // Variabilă pentru raza de curbură

    using (GraphicsPath path = new GraphicsPath())
    {
        path.StartFigure();
        // Definirea celor 4 colțuri prin segmente de arc (90°)
        path.AddArc(inset, inset, r, r, 180, 90);                         // Sus-Stânga
        path.AddArc(Width - r - inset, inset, r, r, 270, 90);              // Sus-Dreapta
        path.AddArc(Width - r - inset, Height - r - inset, r, r, 0, 90);   // Jos-Dreapta
        path.AddArc(inset, Height - r - inset, r, r, 90, 90);             // Jos-Stânga
        path.CloseFigure();

        // Aplicăm forma rezultată asupra regiunii interactive a controlului
        this.Region = new Region(path);
    }
}

```

#### Descriere:

* **`SmoothingMode.AntiAlias`**: Elimină aspectul pixelat al marginilor, oferind un finisaj profesional.
* **`GraphicsPath`**: Construiește un traseu matematic închis care definește noua formă a obiectului.
* **`AddArc`**: Calculează curbura fiecărui colț pe baza razei stabilite (`BorderRadius`), transformând dreptunghiul standard într-o formă fluidă.
* **`this.Region`**: Restrânge zona de afișare și aria de click la perimetrul definit de `path`, asigurând că butoanele răspund corect la interacțiune doar în interiorul formei rotunjite.

---

## LogIn.cs
### Logica de Autentificare și Navigare

**1. Verificarea credențialelor și redirecționarea pe roluri (Admin/User):**
Aplicația validează datele de intrare și deschide interfața corespunzătoare folosind metodele `.Show()` și `.Hide()`.

```csharp
if (username == "admin" && password == "1234") {
    DashAdmin da = new DashAdmin(); da.Show(); this.Hide();
} else if (username == "user" && password == "1234") { 
    UserInterface ui = new UserInterface(); ui.Show(); this.Hide();
} else {
    lblEroare.ForeColor = Color.Red; lblEroare.Text = "Username sau parolă incorecte!";
}

```

**2. Navigarea către formularul de înregistrare:**
Permite utilizatorului să comute rapid către interfața de creare cont prin ascunderea ferestrei curente.

```csharp
private void label3_Click(object sender, EventArgs e) {
    Register r = new Register(); r.Show(); this.Hide();
}

```

**3. Gestionarea vizibilității parolei:**
Modifică proprietatea `UseSystemPasswordChar` pentru a afișa sau masca parola în timp real.

```csharp
private void checkBox1_CheckedChanged(object sender, EventArgs e) {
    PassTxt.UseSystemPasswordChar = !checkBox1.Checked;
}

```

---

### Navigare prin UserControls și Animații

Pentru o aplicație rapidă, am utilizat **UserControls** în loc de ferestre multiple, optimizând astfel consumul de memorie.

#### 1. Schimbarea paginilor (Switching)

Folosesc `.Visible` și `.BringToFront()` pentru a afișa instant conținutul dorit în containerul principal.

```csharp
catalogUserForm1.Visible = true;
catalogUserForm1.BringToFront(); // Aduce pagina în față
dashboardAdmin1.Visible = false; // Ascunde restul

```

**Rol:** Evită deschiderea de procese noi și păstrează datele încărcate în fundal.

#### 2. Meniul animat (Dropdown)

Am creat o tranziție fluidă folosind un `Timer` care modifică înălțimea (`Height`) panoului lateral.

```csharp
if (!menuExpand) {
    flowLayoutPanel1.Height += menuSpeed; // Extinde
    if (flowLayoutPanel1.Height >= menuMaxHeight) menuTransition.Stop();
} else {
    flowLayoutPanel1.Height -= menuSpeed; // Retrage
    if (flowLayoutPanel1.Height <= menuMinHeight) menuTransition.Stop();
}

```

**Rol:** Economisește spațiu în interfață și oferă un aspect modern de "acordeon".

#### 3. Securizarea sesiunii

Butonul de **Log Out** include un `MessageBox` de confirmare pentru a preveni închiderea accidentală a aplicației Darwin.

---

---

## Concluzii

Finalizarea acestui proiect a reprezentat o experiență de învățare intensă, marcată de provocări care au depășit cu mult simpla scriere a codului. Cea mai dificilă etapă nu a fost doar implementarea tehnică, ci faza de concepție a întregii lucrări. A fost necesar un efort intelectual considerabil pentru a structura viziunea aplicației „Darwin”, astfel încât să integreze armonios fluxul de vânzare pentru dispozitive electronice cu un sistem de securitate riguros între Admin și Utilizator.

Procesul de design a fost unul extrem de anevoios, în special din cauza utilizării bibliotecii Krypton Toolkit. Ceea ce la început părea o alegere estetică, s-a dovedit a fi o luptă continuă cu configurarea paletelor de culori și a proprietăților vizuale. Realizarea panoului personalizat de navigare a fost, probabil, cel mai critic punct al dezvoltării; a necesitat ore întregi de muncă migăloasă, transformate în zile de încercări și erori pentru a obține o interfață care să nu fie doar funcțională, ci și fluidă și modernă. 

Instalarea componentelor și depanarea conflictelor de design au consumat o cantitate uriașă de timp, forțându-mă să caut soluții complexe pentru probleme care păreau inițial nerezolvabile. Fiecare detaliu al interfeței grafice a fost gândit și răzgândit de zeci de ori pentru a asigura o experiență de utilizare coerentă.

În concluzie, această lucrare a fost un test de rezistență și creativitate. Timpul investit reflectă dorința de a nu accepta soluții mediocre, ci de a crea un produs software complet, care să demonstreze atât competențe de gestionare a bazelor de date, cât și o stăpânire avansată a designului de interfață în C#. Deși parcursul a fost foarte greu și plin de obstacole, satisfacția de a vedea un sistem complex funcționând stabil justifică fiecare zi de efort.


## Bibliografie / Resurse Utilizate

| Sursa / Canal | Tip Resursă | Link / Referință |
| :--- | :--- | :--- |
| **Darwin** | Documentație Produse | [darwin.md](https://darwin.md/) |
| **C# Artan Academy** | Tutorial Video | [Vizualizare Video](https://youtu.be/vxc5GopCOMQ?si=wh8ARV_2dQF_gGLC) |
| **PCODEP** | Tutorial Video | [Partea 1](https://youtu.be/ul8zQeqid7I?si=KlUeBuySws3xMfM7) / [Partea 2](https://youtu.be/mWKSXocPDOU?si=EwPqV4EhTj30ecMh) |
| **Marcoman** | Tutorial Video | [Vizualizare Video](https://youtu.be/F2eEO1lxvbg?si=kBjDuO4sMOsAaP77) |
| **Coding Ideas** | Tutorial Video | [Vizualizare Video](https://youtu.be/Ns0pBlbBZmE?si=kaS5E04r4CDMZ19t) |
| **Code Cracks** | Tutorial Video | [Vizualizare Video](https://youtu.be/IF2HHacgjAU?si=Ex7yHkdcVrnKQd4M) |
| **Microsoft Learn** | Documentație API | [Control.OnPaint](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.control.onpaint) |
| **Microsoft Learn** | Documentație API | [System.Drawing.Pen](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.pen) |
| **Microsoft Learn** | Ghid Tehnic | [UserControl Overview](https://learn.microsoft.com/en-us/dotnet/desktop/winforms/controls-design/usercontrol-overview) |
| **StackOverflow** | Forum Tehnic | [WinForms Smooth Animations](https://stackoverflow.com/questions/62701593/winforms-smooth-animations) |
| **StackOverflow** | Forum Tehnic | [Circular Panels in C#](https://stackoverflow.com/questions/3226136/turn-a-panel-into-a-circle-in-c-sharp-visual-studio-2010) |



