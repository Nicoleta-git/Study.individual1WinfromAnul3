using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace indiv1
{
    public partial class Comenzi : UserControl
    {
        string connectionString = @"Data Source=NICOLETA\SQLEXPRESS;Initial Catalog=DarwinDB;Integrated Security=True;TrustServerCertificate=True";

        public Comenzi()
        {
            InitializeComponent();
            IncarcaDate();
        }

        private void IncarcaDate()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT c.ID_Comanda, cl.Nume AS NumeClient, p.NumeProdus, c.Cantitate FROM Comenzi c JOIN Produse p ON c.ID_Produs = p.ID_Produs JOIN Clienti cl ON c.ID_Client = cl.ID_Utilizator";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                moderDataGridViewCustom1.DataSource = dt;
            }
        }

        private void moderDataGridViewCustom1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = moderDataGridViewCustom1.Rows[e.RowIndex];
                idComandTxt.Text = row.Cells["ID_Comanda"].Value.ToString();
                numeClTxt.Text = row.Cells["NumeClient"].Value.ToString();
                numeTxt.Text = row.Cells["NumeProdus"].Value.ToString();
                cantitateTxt.Text = row.Cells["Cantitate"].Value.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            label1.Focus();
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("Sp_InsereazaComanda", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@NumeClient", numeClTxt.Text);
                    cmd.Parameters.AddWithValue("@NumeProdus", numeTxt.Text);
                    cmd.Parameters.AddWithValue("@Cantitate", int.Parse(cantitateTxt.Text));

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Comanda salvata cu succes!");
                    IncarcaDate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la salvare: " + ex.Message);
            }
        }

        private void cautaTextBox_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT c.ID_Comanda, cl.Nume AS NumeClient, p.NumeProdus, c.Cantitate " +
                               "FROM Comenzi c JOIN Produse p ON c.ID_Produs = p.ID_Produs " +
                               "JOIN Clienti cl ON c.ID_Client = cl.ID_Utilizator " +
                               "WHERE p.NumeProdus LIKE @cauta OR cl.Nume LIKE @cauta";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@cauta", "%" + cautaTextBox.Text + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                moderDataGridViewCustom1.DataSource = dt;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            label1.Focus();
            idComandTxt.Clear();
            numeTxt.Clear();
            cantitateTxt.Clear();
            numeClTxt.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            label1.Focus();
            if (string.IsNullOrEmpty(idComandTxt.Text))
            {
                MessageBox.Show("Va rugam sa selectati o comanda din tabel pentru a o sterge.");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Sunteti sigur ca doriti sa stergeti aceasta comanda?", "Confirmare Stergere", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM Comenzi WHERE ID_Comanda = @id";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@id", idComandTxt.Text);

                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Comanda a fost stearsa cu succes!");
                            btnClear_Click(sender, e);
                            IncarcaDate();
                        }
                        else
                        {
                            MessageBox.Show("Comanda nu a putut fi gasita in baza de date.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la stergere: " + ex.Message);
                }
            }
        }
    }
}