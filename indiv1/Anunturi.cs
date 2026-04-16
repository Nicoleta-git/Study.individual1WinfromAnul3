using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace indiv1
{
    public partial class Anunturi : UserControl
    {
        string connection = @"Data Source=NICOLETA\SQLEXPRESS;Initial Catalog=DarwinDB;Integrated Security=True;TrustServerCertificate=True";

        public Anunturi()
        {
            InitializeComponent();
            IncarcaDateAnunturi();
        }

        private void IncarcaDateAnunturi()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    string query = "SELECT * FROM Anunturi";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    moderDataGridViewCustom2.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare: " + ex.Message);
            }
        }

        private void trimiteBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mesajTextBox.Text))
            {
                MessageBox.Show("Introduceti un mesaj!");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();
                    string sql = "INSERT INTO Anunturi (Mesaj, DataPublicare) VALUES (@mesaj, @data)";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@mesaj", mesajTextBox.Text);
                        cmd.Parameters.AddWithValue("@data", DateTime.Now);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Anuntul a fost inregistrat!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            mesajTextBox.Clear();
                            IDAnuntTextBoxI.Clear();
                            IncarcaDateAnunturi();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la salvare: " + ex.Message);
            }
        }

        private void moderDataGridViewCustom2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = moderDataGridViewCustom2.Rows[e.RowIndex];

                IDAnuntTextBoxI.Text = row.Cells["ID_Anunt"].Value.ToString();
                mesajTextBox.Text = row.Cells["Mesaj"].Value.ToString();
            }
        }
    }
}