using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace indiv1
{
    public partial class Angajati : UserControl
    {
        string connectionString = @"Data Source=NICOLETA\SQLEXPRESS;Initial Catalog=DarwinDB;Integrated Security=True;TrustServerCertificate=True";

        public Angajati()
        {
            InitializeComponent();
            IncarcaDate();
        }

        private void IncarcaDate()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT ID_Utilizator, Nume, Salariu, DataAngajare FROM Angajati";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                moderDataGridViewCustom1.DataSource = dt;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("Sp_InsereazaAngajat", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ID_Utilizator", int.Parse(idUserTxt.Text));
                    cmd.Parameters.AddWithValue("@Nume", numeTxt.Text);
                    cmd.Parameters.AddWithValue("@Salariu", decimal.Parse(salariuTxt.Text));

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Angajat salvat cu succes!");
                    IncarcaDate();
                    clearBtn_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la salvare: " + ex.Message);
            }
        }

        private void cautaTxt_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT ID_Utilizator, Nume, Salariu, DataAngajare FROM Angajati " +
                               "WHERE Nume LIKE @cauta OR CAST(ID_Utilizator AS VARCHAR) LIKE @cauta";

                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@cauta", "%" + cautaTxt.Text + "%");
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
                idUserTxt.Text = row.Cells["ID_Utilizator"].Value.ToString();
                numeTxt.Text = row.Cells["Nume"].Value.ToString();
                salariuTxt.Text = row.Cells["Salariu"].Value.ToString();
                angajareDateTimePicker1.Value = Convert.ToDateTime(row.Cells["DataAngajare"].Value);
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            idUserTxt.Clear();
            numeTxt.Clear();
            salariuTxt.Clear();
            angajareDateTimePicker1.Value = DateTime.Now;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idUserTxt.Text))
            {
                MessageBox.Show("Selectati un angajat din tabel pentru a face update.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Angajati SET Nume = @nume, Salariu = @salariu WHERE ID_Utilizator = @id";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", int.Parse(idUserTxt.Text));
                    cmd.Parameters.AddWithValue("@nume", numeTxt.Text);
                    cmd.Parameters.AddWithValue("@salariu", decimal.Parse(salariuTxt.Text));

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Datele angajatului au fost actualizate!");
                        IncarcaDate();
                    }
                    else
                    {
                        MessageBox.Show("Nu s-a putut efectua actualizarea.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la update: " + ex.Message);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idUserTxt.Text))
            {
                MessageBox.Show("Selectati un angajat din tabel.");
                return;
            }

            if (MessageBox.Show("Stergeti angajatul selectat?", "Confirmare", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Angajati WHERE ID_Utilizator = @id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", idUserTxt.Text);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    IncarcaDate();
                    clearBtn_Click(sender, e);
                }
            }
        }
    }
}