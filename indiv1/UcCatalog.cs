using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace indiv1
{
    public partial class UcCatalog : UserControl
    {
        string connectionString = @"Data Source=NICOLETA\SQLEXPRESS;Initial Catalog=DarwinDB;Integrated Security=True;TrustServerCertificate=True";
        DataTable cos = new DataTable();
        private string _categorieCurenta = "";

        public UcCatalog()
        {
            InitializeComponent();
            SeteazaCos();
        }

        public void ActualizeazaCategorie(string categorie)
        {
            _categorieCurenta = categorie;
            label1.Text = categorie;
            IncarcaProduse();
        }

        void SeteazaCos()
        {
            if (cos.Columns.Count == 0)
            {
                cos.Columns.Add("ID", typeof(int));
                cos.Columns.Add("Produs");
                cos.Columns.Add("Pret", typeof(double));
                cos.Columns.Add("Cantitate", typeof(int));
                cos.Columns.Add("Total", typeof(double));
            }
            moderDataGridViewCustom1.DataSource = cos;
        }

        void IncarcaProduse()
        {
            flowLayoutPanel1.Controls.Clear();
            string query = "SELECT ID_Produs, NumeProdus, Pret, Stoc, ImagineProdus FROM Produse WHERE Categorie = @cat";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@cat", _categorieCurenta);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Produs p = new Produs();
                        p.IncarcaDate(
                            reader["NumeProdus"].ToString(),
                            Convert.ToDouble(reader["Pret"]),
                            Convert.ToInt32(reader["Stoc"]),
                            reader["ImagineProdus"] as byte[]
                        );

                        p.Tag = Convert.ToInt32(reader["ID_Produs"]);
                        p.OnAdaugaInCos += AdaugaInCos;
                        flowLayoutPanel1.Controls.Add(p);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        void AdaugaInCos(object sender, EventArgs e)
        {
            Produs p = (Produs)sender;
            int id = (int)p.Tag;
            bool gasit = false;

            foreach (DataRow row in cos.Rows)
            {
                if ((int)row["ID"] == id)
                {
                    int cant = (int)row["Cantitate"] + 1;
                    row["Cantitate"] = cant;
                    row["Total"] = Math.Round(cant * p.PretProdus, 2);
                    gasit = true;
                    break;
                }
            }

            if (!gasit)
            {
                cos.Rows.Add(id, p.NumeProdus, p.PretProdus, 1, p.PretProdus);
            }

            CalculeazaTotal();
        }

        void CalculeazaTotal()
        {
            double suma = 0;
            foreach (DataRow row in cos.Rows)
            {
                suma += Convert.ToDouble(row["Total"]);
            }
            lblTotal.Text = "Total: " + Math.Round(suma, 2) + " MDL";
        }

        private void btn_cumpara_Click(object sender, EventArgs e)
        {
            lblTotal.Focus();
            if (cos.Rows.Count == 0) return;
            if (SesiuneUtilizator.ID_Utilizator <= 0)
            {
                MessageBox.Show("Eroare sesiune: Reautentificați-vă!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string checkClientQuery = "IF NOT EXISTS (SELECT 1 FROM Clienti WHERE ID_Utilizator = @id) " +
                                              "INSERT INTO Clienti (ID_Utilizator, Nume, Telefon) VALUES (@id, 'Client Nou', '00000000')";
                    SqlCommand cmdCheck = new SqlCommand(checkClientQuery, conn);
                    cmdCheck.Parameters.AddWithValue("@id", SesiuneUtilizator.ID_Utilizator);
                    cmdCheck.ExecuteNonQuery();

                    foreach (DataRow row in cos.Rows)
                    {
                        string query = "INSERT INTO Comenzi (ID_Client, ID_Produs, Cantitate, PretTotal, DataComanda) " +
                                       "VALUES (@c, @p, @cant, @t, GETDATE())";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@c", SesiuneUtilizator.ID_Utilizator);
                        cmd.Parameters.AddWithValue("@p", row["ID"]);
                        cmd.Parameters.AddWithValue("@cant", row["Cantitate"]);
                        cmd.Parameters.AddWithValue("@t", row["Total"]);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Comanda a fost procesată cu succes!");
                    cos.Clear();
                    CalculeazaTotal();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la finalizarea comenzii: " + ex.Message);
                }
            }
        }

        private void btn_check_Click(object sender, EventArgs e)
        {
            lblTotal.Focus();
            if (cos.Rows.Count == 0)
            {
                MessageBox.Show("Cosul este gol!");
                return;
            }

            string text = "----- BON FISCAL -----\n";
            foreach (DataRow row in cos.Rows)
            {
                text += $"{row["Produs"]} | x{row["Cantitate"]} | {row["Total"]} MDL\n";
            }
            text += "----------------------\n";
            text += lblTotal.Text;
            MessageBox.Show(text, "Sumar Coș");
        }
    }
}