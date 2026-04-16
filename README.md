# Raport

<div align="center">

### Centrul de Excelență în Informatică și Tehnologii Informaționale
### Catedra Informatică I

<br><br><br><br>

## Lucrare de studiu individual Nr. 1,2
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
   * [Componente Vizuale și Layout](#componente-vizuale-si-layout-krypton-toolkit)
   * [Elemente de Control Interactive](#elemente-de-control-interactive)
   * [Vizualizarea Datelor (Charts)](#vizualizarea-datelor-charts)
   * [Managementul Produselor](#4-managementul-produselor-cataloguserform)

4. [Logica Codului](#logica-cod)
   * [Implementarea Grafică (OnPaint)](#implementarea-grafica-randarea-marginilor-rotunjite)
   * [Autentificare și Navigare](#logica-de-autentificare-si-navigare)
   * [UserControls și Animații](#navigare-prin-usercontrols-si-animatii)

5. [Baza de date și Funcționalități](#baza-de-date-darwin)
   * [Baza de date: Darwin](#baza-de-date-darwin)
   * [Proceduri](#proceduri)
   * [Vederi](#vederi)
   * [Logare Admin](#logare-admin)
   * [Dashboard](#dashboard-conectat-la-baza-de-date)
   * [Anunțuri](#anunturi)
   * [Rapoarte](#rapoarte)
     - [Raportul 1](#raportul-1)
     - [Raportul 2](#raportul-2)
     - [Raportul 3](#raportul-3)
   * [Setările contului](#setarile-contului-conectate-la-bd)

6. [Operații CRUD](#operatii-crud)
   * [Client](#client)
   * [Comenzi](#comenzi)
   * [Produse](#produse)
   * [Angajați](#angajati)

7. [Funcționalități Utilizator](#registrare-utilizator)
   * [Registrare utilizator](#registrare-utilizator)
   * [Logare utilizator](#logare-utilizator)
   * [Dashboard utilizator](#dashboard-utilizator-independent-de-sesiune)
   * [Istoric](#istoric)
   * [Catalog](#catalog)

8. [Explicare logica codului](#explicare-logica-codului)
   * [CatalogUserForm explicat prin cod](#cataloguserform-explicat-prin-cod-cu-comentarii)
   * [Încărcarea datelor în ReportViewer](#incarcarea-datelor-in-reportviewer-clienti)

9. [Concluzii](#concluzii)

10. [Bibliografie](#bibliografie--resurse-utilizate)
---

## Introducere

Această lucrare de studiu individual se concentrează pe dezvoltarea unei aplicații desktop dedicate gestiunii proceselor de vânzare pentru compania Darwin. Proiectul a fost gândit special pentru comercializarea dispozitivelor electronice, precum telefoane, laptopuri sau căști, având la bază o structură logică ce permite categorisirea produselor în funcție de specificațiile lor hardware și software.

Din punct de vedere tehnic, am pus un accent deosebit pe crearea unei interfețe grafice moderne, motiv pentru care am ales să folosesc suita de componente Krypton Toolkit. Aceasta mi-a permis să depășesc limitările vizuale standard ale Windows Forms și să implementez elemente mai avansate, cum ar fi paletele de culori personalizate, butoane cu design stilizat și tranziții mai fluide între meniuri, oferind astfel o experiență de utilizare mult mai calitativă. Aplicația are la bază o arhitectură solidă conectată la o bază de date, ceea ce garantează că toate informațiile despre stocuri, conturile utilizatorilor și istoricul comenzilor sunt salvate corect și pot fi accesate oricând.

Un aspect esențial al sistemului este securitatea, realizată printr-o separare clară a rolurilor de acces. Utilizatorii obișnuiți pot naviga prin catalogul de produse și își pot gestiona istoricul personal, în timp ce interfața de administrator oferă un control total. Din panoul de admin, pot fi adăugate sau șterse produse, se pot modifica prețurile în timp real și se poate gestiona întreaga bază de date a clienților.

În final, obiectivele principale pe care le-am urmărit prin acest proiect au fost optimizarea experienței de navigare prin elemente vizuale interactive, eficientizarea modului în care Darwin își gestionează inventarul și, nu în ultimul rând, asigurarea integrității datelor printr-un sistem de autentificare simplu, dar sigur.

---

# Introducere Prezentare generala
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
<img width="1178" height="792" alt="{BA3BEF53-284D-4BA1-A1E8-B4A71FEA22DF}" src="https://github.com/user-attachments/assets/d566af87-829f-401f-8ccf-7969f8ed4b0e" />
<img width="1162" height="777" alt="image" src="https://github.com/user-attachments/assets/b8241620-0439-4b7a-9198-e162fcfc988c" />
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

# Partea 2 – Lucru individual

## Baza de date: Darwin
![BD Darwin](https://github.com/user-attachments/assets/cec83264-1a25-4619-a4a1-260941b04909)

---

## Proceduri
![Proceduri](https://github.com/user-attachments/assets/01edb7ae-29e4-4cd4-89c9-7e855ca8da61)

## Vederi
![Vederi](https://github.com/user-attachments/assets/79019af1-51b5-4201-aed8-0d8a6c7ba16f)

---

## Logare Admin
![Logare Admin](https://github.com/user-attachments/assets/456416b5-c1ea-47d3-b209-86d84b2b33f7)

## Dashboard (conectat la baza de date)
![Dashboard](https://github.com/user-attachments/assets/66d400a0-d2bd-4694-9910-7054aab8f21c)

## Anunțuri
![Anunturi](https://github.com/user-attachments/assets/f8178c9c-06d8-45dd-be90-4d6473cf5cf9)

---

## Rapoarte

### Raportul 1
![Raport 1](https://github.com/user-attachments/assets/3030e4bf-17f6-4089-a75f-467df02bd6c3)

### Raportul 2
![Raport 2](https://github.com/user-attachments/assets/ecaeccba-a354-40a8-87c3-095e036b9939)

![Raport 2 - detalii](https://github.com/user-attachments/assets/1adf444a-e6e5-4ff6-afe5-df4c09a81e22)

### Raportul 3
<img width="1164" height="787" alt="{D3E05C7B-9F7E-4818-A2FE-9D93FC8E7999}" src="https://github.com/user-attachments/assets/3643e3aa-4fb8-4e7b-8fb7-d8fd6a7ecbb7" />

---

## Setările contului (conectate la BD)
![Setari cont](https://github.com/user-attachments/assets/851737eb-1082-4c3d-8dfe-6f6a2f61d5e4)

---

## Operații CRUD

### Client
![Client](https://github.com/user-attachments/assets/278a3feb-31c0-407b-8fdd-7977b251841a)

### Comenzi
![Comenzi](https://github.com/user-attachments/assets/1c608606-35ab-4d5a-9f91-b07442f63791)

### Produse
![Produse](https://github.com/user-attachments/assets/f68606ff-d0ea-4eb6-ba4c-cbd936fb2306)

### Angajați
![Angajati](https://github.com/user-attachments/assets/b932f76b-a5b6-4416-84d9-6e98f4c0d3cf)

---

## Registrare utilizator
<img width="851" height="750" alt="{0DB92E8B-AB48-4B76-953F-6794B87E5448}" src="https://github.com/user-attachments/assets/0e534a29-cbcb-40bd-bcd0-62a7d5bbef05" />

## Logare utilizator
![Logare utilizator](https://github.com/user-attachments/assets/7c340b70-5aa7-4cd2-998f-198cf090f02b)

## Dashboard utilizator (independent de sesiune)
![Dashboard utilizator](https://github.com/user-attachments/assets/54098874-db27-42bb-99f3-ede267f4bc57)

## Istoric
![Istoric](https://github.com/user-attachments/assets/2e85eaf2-c76a-44f6-abe0-2e420e50a179)

## Catalog
<img width="1169" height="787" alt="image" src="https://github.com/user-attachments/assets/2c31c0f2-dc9d-4c0c-b2dd-6422237855a5" />
<img width="1162" height="783" alt="image" src="https://github.com/user-attachments/assets/518b2eab-2eb7-4863-a892-03971cce83cc" />
<img width="1160" height="780" alt="image" src="https://github.com/user-attachments/assets/ebfa70cb-7f12-482e-aeb2-6d2be652f012" />


# Explicare logica codului

Clasa pentru a cunoste cine este logat si ce interfata sa fie prezentata  
Independenta de rol avem Admin si utilizatorul obisnuit(client,angajat)  
Fiecare utilizator are interfata personalizata independenta de produsele cumparate si altele  

```csharp
public static class SesiuneUtilizator
{
    public static int ID_Utilizator { get; set; }
    public static int ID_Rol { get; set; } 
    public static string Username { get; set; }
}
```

# CatalogUserForm explicat prin cod (cu comentarii)

```csharp
// string de conexiune catre baza de date SQL Server
// contine serverul, baza de date si metoda de autentificare
string connectionString = @"Data Source=NICOLETA\SQLEXPRESS;Initial Catalog=DarwinDB;Integrated Security=True;TrustServerCertificate=True";
````

---

```csharp
// constructorul clasei
// se apeleaza automat la crearea controlului
public CatalogUserForm()
{
    InitializeComponent(); // initializeaza componentele UI
    DisplayProducts();     // afiseaza produsele la start
}
```

---

```csharp
// metoda care incarca toate produsele din baza de date
public void DisplayProducts()
{
    try
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open(); // deschide conexiunea

            string query = "SELECT * FROM Produse"; // ia toate produsele

            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();

            da.Fill(dt); // umple tabelul cu date din BD

            if (dataGridView1 != null)
                dataGridView1.DataSource = dt; // afiseaza in tabel
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("Eroare la incarcare: " + ex.Message);
    }
}
```

---

```csharp
// cautare produse in timp real dupa nume
private void cautaTxt_TextChanged_1(object sender, EventArgs e)
{
    try
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();

            // LIKE permite cautare partiala
            string query = "SELECT * FROM Produse WHERE NumeProdus LIKE @search";

            SqlDataAdapter da = new SqlDataAdapter(query, conn);

            // adauga parametrul cu % pentru cautare
            da.SelectCommand.Parameters.AddWithValue("@search", "%" + cautaTxt.Text + "%");

            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridView1.DataSource = dt; // actualizeaza tabelul
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}
```

---

```csharp
// selectare imagine din calculator
private void importBtn_Click(object sender, EventArgs e)
{
    OpenFileDialog ofd = new OpenFileDialog();

    ofd.Title = "Selecteaza o imagine";
    ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

    // daca userul a ales o imagine
    if (ofd.ShowDialog() == DialogResult.OK)
        ImgProdus.Image = Image.FromFile(ofd.FileName); // afiseaza imaginea
}
```

---

```csharp
// salvare produs nou in baza de date
private void saveBtn_Click(object sender, EventArgs e)
{
    label1.Focus(); // scoate focusul din textbox

    try
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();

            // insert cu parametri (mai sigur decat concatenare)
            string query = @"INSERT INTO Produse 
            (NumeProdus, Categorie, Producator, Pret, Stoc, Specificatii_Software, Specificatii_Hardware, ImagineProdus, DataAdaugare) 
            VALUES (@nume, @cat, @prod, @pret, @stoc, @soft, @hard, @img, GETDATE())";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                // preia datele din textbox-uri
                cmd.Parameters.AddWithValue("@nume", numeProdusTxt.Text);
                cmd.Parameters.AddWithValue("@cat", categorieProdusTxt.Text);
                cmd.Parameters.AddWithValue("@prod", producatorTxt.Text);
                cmd.Parameters.AddWithValue("@pret", decimal.Parse(pretTxt.Text));
                cmd.Parameters.AddWithValue("@stoc", int.Parse(StocTxt.Text));
                cmd.Parameters.AddWithValue("@soft", softwareTxt.Text);
                cmd.Parameters.AddWithValue("@hard", HardwareTxt.Text);

                // converteste imaginea in byte[] pentru BD
                cmd.Parameters.AddWithValue("@img", ImageToByteArray(ImgProdus.Image));

                cmd.ExecuteNonQuery(); // executa insert

                MessageBox.Show("Produs salvat cu succes!");

                DisplayProducts();      // refresh tabel
                clearBtn_Click(null,null); // golire campuri
            }
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("Eroare la salvare: " + ex.Message);
    }
}
```

---

```csharp
// update produs existent
private void updateBtn_Click(object sender, EventArgs e)
{
    label1.Focus();

    try
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();

            // update dupa ID
            string query = @"UPDATE Produse SET 
            NumeProdus=@nume, Categorie=@cat, Producator=@prod, 
            Pret=@pret, Stoc=@stoc, Specificatii_Software=@soft, 
            Specificatii_Hardware=@hard, ImagineProdus=@img 
            WHERE ID_Produs=@id";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", idProdusTxt.Text);

                // valori noi
                cmd.Parameters.AddWithValue("@nume", numeProdusTxt.Text);
                cmd.Parameters.AddWithValue("@cat", categorieProdusTxt.Text);
                cmd.Parameters.AddWithValue("@prod", producatorTxt.Text);
                cmd.Parameters.AddWithValue("@pret", decimal.Parse(pretTxt.Text));
                cmd.Parameters.AddWithValue("@stoc", int.Parse(StocTxt.Text));
                cmd.Parameters.AddWithValue("@soft", softwareTxt.Text);
                cmd.Parameters.AddWithValue("@hard", HardwareTxt.Text);
                cmd.Parameters.AddWithValue("@img", ImageToByteArray(ImgProdus.Image));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Produs actualizat!");
                DisplayProducts();
            }
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("Eroare la update: " + ex.Message);
    }
}
```

---

```csharp
// stergere produs
private void deleteBtn_Click(object sender, EventArgs e)
{
    label1.Focus();

    // verifica daca exista ID selectat
    if (string.IsNullOrEmpty(idProdusTxt.Text))
    {
        MessageBox.Show("Selecteaza un produs!");
        return;
    }

    // confirmare
    DialogResult result = MessageBox.Show("Sigur stergi acest produs?", "Confirmare", MessageBoxButtons.YesNo);
    if (result == DialogResult.No) return;

    try
    {
        using (SqlConnection conn = new SqlConnection(connectionString))
        {
            conn.Open();

            string query = "DELETE FROM Produse WHERE ID_Produs=@id";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", idProdusTxt.Text);
                cmd.ExecuteNonQuery();

                DisplayProducts(); // refresh
                clearBtn_Click(null,null);
            }
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("Eroare: " + ex.Message);
    }
}
```

---

```csharp
// golire campuri
private void clearBtn_Click(object sender, EventArgs e)
{
    label1.Focus();

    idProdusTxt.Clear();
    numeProdusTxt.Clear();
    categorieProdusTxt.Clear();
    producatorTxt.Clear();
    pretTxt.Clear();
    StocTxt.Clear();
    softwareTxt.Clear();
    HardwareTxt.Clear();

    ImgProdus.Image = null; // sterge imaginea
}
```

---

```csharp
// cand se da click pe un rand din tabel
private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
{
    if (e.RowIndex >= 0)
    {
        DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

        // incarca datele in textbox-uri
        idProdusTxt.Text = row.Cells["ID_Produs"].Value.ToString();
        numeProdusTxt.Text = row.Cells["NumeProdus"].Value.ToString();
        categorieProdusTxt.Text = row.Cells["Categorie"].Value.ToString();
        producatorTxt.Text = row.Cells["Producator"].Value.ToString();
        pretTxt.Text = row.Cells["Pret"].Value.ToString();
        StocTxt.Text = row.Cells["Stoc"].Value.ToString();
        softwareTxt.Text = row.Cells["Specificatii_Software"].Value.ToString();
        HardwareTxt.Text = row.Cells["Specificatii_Hardware"].Value.ToString();

        // conversie imagine din BD
        if (row.Cells["ImagineProdus"].Value != DBNull.Value)
        {
            byte[] imgData = (byte[])row.Cells["ImagineProdus"].Value;

            using (MemoryStream ms = new MemoryStream(imgData))
            {
                ImgProdus.Image = Image.FromStream(ms);
            }
        }
        else
        {
            ImgProdus.Image = null;
        }
    }
}
```

---

```csharp
// functie care transforma Image in byte[]
// necesara pentru salvare in baza de date
private byte[] ImageToByteArray(Image image)
{
    if (image == null) return null;

    using (MemoryStream ms = new MemoryStream())
    {
        Bitmap bmp = new Bitmap(image);

        // salveaza imaginea in format PNG in memorie
        bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

        return ms.ToArray(); // returneaza byte[]
    }
}
```
### Încărcarea datelor în ReportViewer (Clienti)

```csharp
// Se incarca datele din tabelul "Clienti" din baza de date
// în DataSet-ul local (darwinDBDataSet)
this.clientiTableAdapter1.Fill(this.darwinDBDataSet.Clienti);

// Se sterg orice surse de date existente din ReportViewer
// (evită dublarea sau conflictele de date)
this.reportViewer3.LocalReport.DataSources.Clear();

// Se creează o noua sursa de date pentru raport
// "DataSet1" trebuie sa corespundă EXACT cu numele din fișierul .rdlc
// Se folosește DefaultView pentru a permite filtrare/sortare dacă e nevoie
ReportDataSource rds = new ReportDataSource(
    "DataSet1",
    this.darwinDBDataSet.Clienti.DefaultView
);

// Se adauga noua sursă de date la ReportViewer
this.reportViewer3.LocalReport.DataSources.Add(rds);

// Se reîncarcă raportul pentru a afișa datele actualizate
this.reportViewer3.RefreshReport();
```

## Concluzii

Finalizarea acestui proiect a reprezentat o experiență de învățare intensă, marcată de provocări care au depășit cu mult simpla scriere a codului. Cea mai dificilă etapă nu a fost doar implementarea tehnică, ci faza de concepție a întregii lucrări. A fost necesar un efort intelectual considerabil pentru a structura viziunea aplicației „Darwin”, astfel încât să integreze armonios fluxul de vânzare pentru dispozitive electronice cu un sistem de securitate riguros între Admin și Utilizator.

Procesul de design a fost unul extrem de anevoios, în special din cauza utilizării bibliotecii Krypton Toolkit. Ceea ce la început părea o alegere estetică, s-a dovedit a fi o luptă continuă cu configurarea paletelor de culori și a proprietăților vizuale. Realizarea panoului personalizat de navigare a fost, probabil, cel mai critic punct al dezvoltării; a necesitat ore întregi de muncă migăloasă, transformate în zile de încercări și erori pentru a obține o interfață care să nu fie doar funcțională, ci și fluidă și modernă. 

Instalarea componentelor și depanarea conflictelor de design au consumat o cantitate uriașă de timp, forțându-mă să caut soluții complexe pentru probleme care păreau inițial nerezolvabile. Fiecare detaliu al interfeței grafice a fost gândit și răzgândit de zeci de ori pentru a asigura o experiență de utilizare coerentă.

În partea 2 am reușit să construiesc o aplicație completă, care funcționează în legătură directă cu baza de date Darwin. Am implementat toate operațiile importante (adăugare, modificare, ștergere și afișare), iar datele sunt actualizate în timp real în interfață.

Am înțeles mai bine cum se face conexiunea la baza de date, cum se folosesc comenzile SQL în C# și cum se transmit datele între aplicație și SQL Server. De asemenea, am lucrat cu imagini, rapoarte și am realizat o separare clară între utilizator și admin, fiecare având funcționalități diferite.

Dificultățile întâlnite în această parte au fost în principal legate de crearea mai multor dataseturi, ceea ce a generat diverse erori și probleme de sincronizare. De asemenea, a fost dificilă realizarea în paralel a procedurilor din baza de date și a codului C#, deoarece trebuiau corelate corect. Acest proces a fost destul de lent și obositor, necesitând multă atenție la detalii pentru a evita erorile.

Prin urmare, această lucrare a fost un test de rezistență și creativitate. Timpul investit reflectă dorința de a nu accepta soluții mediocre, ci de a crea un produs software complet, care să demonstreze atât competențe de gestionare a bazelor de date, cât și o stăpânire avansată a designului de interfață în C#. Deși parcursul a fost foarte greu și plin de obstacole, satisfacția de a vedea un sistem complex funcționând stabil justifică fiecare zi de efort.


## Webografii / Resurse Utilizate

| Sursa / Canal               | Tip Resursă          | Link / Referință                                                                                                              |
| :-------------------------- | :------------------- | :---------------------------------------------------------------------------------------------------------------------------- |
| **Darwin**                  | Documentație Produse | [darwin.md](https://darwin.md/)                                                                                               |
| **C# Artan Academy**        | Tutorial Video       | [Vizualizare Video](https://youtu.be/vxc5GopCOMQ?si=wh8ARV_2dQF_gGLC)                                                         |
| **PCODEP**                  | Tutorial Video       | [Partea 1](https://youtu.be/ul8zQeqid7I?si=KlUeBuySws3xMfM7) / [Partea 2](https://youtu.be/mWKSXocPDOU?si=EwPqV4EhTj30ecMh)   |
| **Marcoman**                | Tutorial Video       | [Vizualizare Video](https://youtu.be/F2eEO1lxvbg?si=kBjDuO4sMOsAaP77)                                                         |
| **Coding Ideas**            | Tutorial Video       | [Vizualizare Video](https://youtu.be/Ns0pBlbBZmE?si=kaS5E04r4CDMZ19t)                                                         |
| **Code Cracks**             | Tutorial Video       | [Vizualizare Video](https://youtu.be/IF2HHacgjAU?si=Ex7yHkdcVrnKQd4M)                                                         |
| **Microsoft Learn**         | Documentație         | [Control.OnPaint](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.control.onpaint)                          |
| **Microsoft Learn**         | Documentație         | [System.Drawing.Pen](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.pen)                                         |
| **Microsoft Learn**         | Ghid Tehnic          | [UserControl Overview](https://learn.microsoft.com/en-us/dotnet/desktop/winforms/controls-design/usercontrol-overview)        |
| **StackOverflow**           | Forum Tehnic         | [WinForms Smooth Animations](https://stackoverflow.com/questions/62701593/winforms-smooth-animations)                         |
| **StackOverflow**           | Forum Tehnic         | [Circular Panels in C#](https://stackoverflow.com/questions/3226136/turn-a-panel-into-a-circle-in-c-sharp-visual-studio-2010) |
| **Krypton Toolkit**         | Design               | [Github repo](https://github.com/ComponentFactory/Krypton.git)                                                                |
| **Sourav Mondal** | Tutorial Video       | [Vizualizare Video](https://youtu.be/SE9_ZzjsLqs?si=YuW0PBasNwJLKeVR)                                                         |
| **Sourav Mondal** | Tutorial Video       | [Vizualizare Video](https://youtu.be/LFMtBKpv9Nc?si=ziXO4-ca_vyVz4Fk)                                                         |

