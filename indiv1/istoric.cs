using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace indiv1
{
    public partial class istoric : UserControl
    {
        string connectionString = @"Data Source=NICOLETA\SQLEXPRESS;Initial Catalog=DarwinDB;Integrated Security=True;TrustServerCertificate=True";

        public istoric()
        {
            InitializeComponent();
        }

        public void IncarcaIstoric()
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"SELECT 
                                C.ID_Comanda, 
                                P.NumeProdus, 
                                C.Cantitate, 
                                C.PretTotal, 
                                C.DataComanda 
                             FROM Comenzi C
                             INNER JOIN Produse P ON C.ID_Produs = P.ID_Produs
                             WHERE C.ID_Client = @userID 
                             ORDER BY C.DataComanda DESC";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                    adapter.SelectCommand.Parameters.AddWithValue("@userID", SesiuneUtilizator.ID_Utilizator);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    moderDataGridViewCustom1.DataSource = dt;

                    if (moderDataGridViewCustom1.Columns.Contains("ID_Comanda"))
                        moderDataGridViewCustom1.Columns["ID_Comanda"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la incarcarea istoricului: " + ex.Message);
            }
        }

        private void istoric_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                IncarcaIstoric();
            }
        }

        private void stergeIstoricBtn_Click(object sender, EventArgs e)
        {
            label1.Focus();
            if (moderDataGridViewCustom1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Va rugam selectati o comanda din tabel!");
                return;
            }

            int idComanda = Convert.ToInt32(moderDataGridViewCustom1.SelectedRows[0].Cells["ID_Comanda"].Value);

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_StergeComandaDinIstoric", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idComanda", idComanda);
                    cmd.Parameters.AddWithValue("@idUtilizator", SesiuneUtilizator.ID_Utilizator);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Comanda a fost stearsa din istoric.");
                    IncarcaIstoric();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la stergere: " + ex.Message);
            }
        }

        private void calctotalBtn_Click(object sender, EventArgs e)
        {
            label1.Focus();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("sp_GetStatisticiUtilizator", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idUtilizator", SesiuneUtilizator.ID_Utilizator);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        string statistici = $"Total Cheltuit: {reader["TotalCheltuit"]} MDL\n" +
                                            $"Produse cumparate: {reader["TotalProduseCumparate"]}\n" +
                                            $"Numar total comenzi: {reader["NumarComenzi"]}";

                        MessageBox.Show(statistici, "Statistici Cumparaturi");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la calcul: " + ex.Message);
            }
        }

        private void restitueBtn_Click(object sender, EventArgs e)
        {
            label1.Focus();
            if (moderDataGridViewCustom1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selectati comanda pentru retur!");
                return;
            }

            int idComanda = Convert.ToInt32(moderDataGridViewCustom1.SelectedRows[0].Cells["ID_Comanda"].Value);
            var confirm = MessageBox.Show("Sunteti sigur ca doriti returnarea produsului?", "Confirmare Retur", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("sp_RestituireComanda", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idComanda", idComanda);
                        cmd.Parameters.AddWithValue("@idUtilizator", SesiuneUtilizator.ID_Utilizator);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Produsul a fost restituit si stocul actualizat!");
                        IncarcaIstoric();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la restituire: " + ex.Message);
                }
            }
        }

        private void VeziDetaliiBtn_Click(object sender, EventArgs e)
        {
            label1.Focus();
            if (moderDataGridViewCustom1.SelectedRows.Count > 0)
            {
                string nume = moderDataGridViewCustom1.SelectedRows[0].Cells["NumeProdus"].Value.ToString();
                string data = moderDataGridViewCustom1.SelectedRows[0].Cells["DataComanda"].Value.ToString();
                string total = moderDataGridViewCustom1.SelectedRows[0].Cells["PretTotal"].Value.ToString();

                MessageBox.Show($"Produs: {nume}\nData Achizitiei: {data}\nTotal Achitat: {total} MDL", "Detalii Comanda");
            }
            else
            {
                MessageBox.Show("Selectati un rand pentru a vedea detaliile.");
            }
        }
    }
}