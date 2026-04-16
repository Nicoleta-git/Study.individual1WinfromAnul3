using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace indiv1
{
    public partial class DashUser : UserControl
    {
        // Șirul de conexiune
        string connection = @"Data Source=NICOLETA\SQLEXPRESS;Initial Catalog=DarwinDB;Integrated Security=True;TrustServerCertificate=True";

        public DashUser()
        {
            InitializeComponent();
            // Înregistrăm manual evenimentul Load pentru a fi siguri că se execută la afișare
            this.Load += new EventHandler(DashUser_Load);
        }

        private void DashUser_Load(object sender, EventArgs e)
        {
            IncarcaDateDashboard();
        }

        // Metoda publică pentru a putea fi apelată și din exterior (de exemplu la Refresh)
        public void IncarcaDateDashboard()
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(connection))
                {
                    connect.Open();

                    // 1. Total Produse Existente în Magazin
                    string queryProduse = "SELECT COUNT(*) FROM Produse";
                    using (SqlCommand cmd1 = new SqlCommand(queryProduse, connect))
                    {
                        object result = cmd1.ExecuteScalar();
                        TotalProduse.Text = result != null ? result.ToString() : "0";
                    }

                    // 2. Suma Totală Cheltuită de utilizatorul logat
                    // Verificăm direct ID_Client în Comenzi (unde salvăm ID_Utilizator din sesiune)
                    string querySuma = @"SELECT ISNULL(SUM(PretTotal), 0) 
                                        FROM Comenzi 
                                        WHERE ID_Client = @userID";

                    using (SqlCommand cmd2 = new SqlCommand(querySuma, connect))
                    {
                        // Luăm ID-ul din clasa globală de sesiune
                        cmd2.Parameters.AddWithValue("@userID", SesiuneUtilizator.ID_Utilizator);

                        decimal suma = Convert.ToDecimal(cmd2.ExecuteScalar());
                        TotalSum.Text = suma.ToString("N2") + " MDL";
                    }

                    // 3. Numărul total de comenzi efectuate de utilizator
                    string queryComenzi = @"SELECT COUNT(*) 
                                           FROM Comenzi 
                                           WHERE ID_Client = @userID";

                    using (SqlCommand cmd3 = new SqlCommand(queryComenzi, connect))
                    {
                        cmd3.Parameters.AddWithValue("@userID", SesiuneUtilizator.ID_Utilizator);

                        object countResult = cmd3.ExecuteScalar();
                        TotalShopCount.Text = countResult != null ? countResult.ToString() : "0";
                    }
                }
            }
            catch (Exception ex)
            {
                // Afișăm eroarea exactă pentru a vedea dacă e problemă de conexiune sau nume de coloane
                MessageBox.Show("Eroare la încărcarea datelor în Dashboard: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Opțional: Dacă ai un buton de Refresh pe Dashboard
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            IncarcaDateDashboard();
        }
    }
}