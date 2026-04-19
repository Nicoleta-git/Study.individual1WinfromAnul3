using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace indiv1
{
    public partial class DashUser : UserControl
    {
        string connection = @"Data Source=NICOLETA\SQLEXPRESS;Initial Catalog=DarwinDB;Integrated Security=True;TrustServerCertificate=True";

        public DashUser()
        {
            InitializeComponent();
        }

        private void DashUser_Load_1(object sender, EventArgs e)
        {
            IncarcaDateDashboard();

        }


        public void IncarcaDateDashboard()
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(connection))
                {
                    connect.Open();

                    string queryProduse = "SELECT COUNT(*) FROM Produse";
                    using (SqlCommand cmd1 = new SqlCommand(queryProduse, connect))
                    {
                        object result = cmd1.ExecuteScalar();
                        TotalProduse.Text = result != null ? result.ToString() : "0";
                    }

                    string querySuma = @"SELECT ISNULL(SUM(PretTotal), 0) 
                                        FROM Comenzi 
                                        WHERE ID_Client = @userID";

                    using (SqlCommand cmd2 = new SqlCommand(querySuma, connect))
                    {
                        cmd2.Parameters.AddWithValue("@userID", SesiuneUtilizator.ID_Utilizator);

                        decimal suma = Convert.ToDecimal(cmd2.ExecuteScalar());

                        if (suma >= 1000)
                        {
                            TotalSum.Text = (suma / 1000).ToString("0.#") + "k MDL";
                        }
                        else
                        {
                            TotalSum.Text = suma.ToString("0.#") + " MDL";
                        }
                    }

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
                MessageBox.Show("Eroare la încărcarea datelor în Dashboard: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}