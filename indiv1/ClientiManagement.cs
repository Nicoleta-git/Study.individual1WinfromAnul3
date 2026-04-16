using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace indiv1
{
    public partial class ClientiManagement : UserControl
    {
        // Stringul de conexiune rămâne neschimbat
        string connectionString = @"Data Source=NICOLETA\SQLEXPRESS;Initial Catalog=DarwinDB;Integrated Security=True;TrustServerCertificate=True";

        public ClientiManagement()
        {
            InitializeComponent();
        }

        private void ClientiManagement_Load(object sender, EventArgs e)
        {
            IncarcaDate();
            // Opțional: Dezactivăm idClientTxt pentru a arăta că e gestionat de sistem
            idClientTxt.ReadOnly = true;
        }

        private void IncarcaDate(string filtru = "")
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Clienti";
                    if (!string.IsNullOrEmpty(filtru))
                    {
                        query += " WHERE Nume LIKE @filtru OR Telefon LIKE @filtru OR CAST(ID_Utilizator AS VARCHAR) LIKE @filtru";
                    }

                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    if (!string.IsNullOrEmpty(filtru))
                        da.SelectCommand.Parameters.AddWithValue("@filtru", "%" + filtru + "%");

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    moderDataGridViewCustom1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la incarcare: " + ex.Message);
            }
        }

        private void cautaTxt_TextChanged(object sender, EventArgs e)
        {
            IncarcaDate(cautaTxt.Text);
        }

        private void moderDataGridViewCustom1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = moderDataGridViewCustom1.Rows[e.RowIndex];

                idClientTxt.Text = row.Cells["ID_Utilizator"].Value?.ToString() ?? "";
                numeTextBox.Text = row.Cells["Nume"].Value?.ToString() ?? "";
                telefonTextBox.Text = row.Cells["Telefon"].Value?.ToString() ?? "";

                if (row.Cells["DataNastere"].Value != DBNull.Value && row.Cells["DataNastere"].Value != null)
                    dataNasteriiDateTimePicker.Value = Convert.ToDateTime(row.Cells["DataNastere"].Value);
                else
                    dataNasteriiDateTimePicker.Value = DateTime.Now;

                intereseSuplimentareTxt.Text = row.Cells["IntereseSuplimentare"].Value?.ToString() ?? "";

                string prefString = row.Cells["Preferinte"].Value?.ToString() ?? "";
                for (int i = 0; i < checkedListBoxPreferinte.Items.Count; i++)
                {
                    string itemText = checkedListBoxPreferinte.Items[i].ToString();
                    checkedListBoxPreferinte.SetItemChecked(i, prefString.Contains(itemText));
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            clientiLbl.Focus();
            if (string.IsNullOrEmpty(numeTextBox.Text))
            {
                MessageBox.Show("Introduceți cel puțin numele clientului!");
                return;
            }

            try
            {
                List<string> selectedPrefs = new List<string>();
                foreach (var item in checkedListBoxPreferinte.CheckedItems)
                    selectedPrefs.Add(item.ToString());

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlTransaction transaction = conn.BeginTransaction())
                    {
                        try
                        {
                            string queryUser = @"INSERT INTO Utilizatori (Username, Parola, Email, ID_Rol, DataCreare) 
                                               OUTPUT INSERTED.ID_Utilizator 
                                               VALUES (@user, @pass, @mail, 2, GETDATE())";

                            int newUserId;
                            using (SqlCommand cmdUser = new SqlCommand(queryUser, conn, transaction))
                            {
                                cmdUser.Parameters.AddWithValue("@user", numeTextBox.Text);
                                cmdUser.Parameters.AddWithValue("@pass", "Darwin" + DateTime.Now.Year);
                                cmdUser.Parameters.AddWithValue("@mail", numeTextBox.Text.Replace(" ", "").ToLower() + "@darwin.md");
                                newUserId = (int)cmdUser.ExecuteScalar();
                            }

                            string queryClient = @"INSERT INTO Clienti (ID_Utilizator, Nume, Telefon, DataNastere, IntereseSuplimentare, Preferinte) 
                                                 VALUES (@id, @nume, @tel, @data, @interese, @pref)";

                            using (SqlCommand cmdClient = new SqlCommand(queryClient, conn, transaction))
                            {
                                cmdClient.Parameters.AddWithValue("@id", newUserId);
                                cmdClient.Parameters.AddWithValue("@nume", numeTextBox.Text);
                                cmdClient.Parameters.AddWithValue("@tel", telefonTextBox.Text);
                                cmdClient.Parameters.AddWithValue("@data", dataNasteriiDateTimePicker.Value);
                                cmdClient.Parameters.AddWithValue("@interese", intereseSuplimentareTxt.Text);
                                cmdClient.Parameters.AddWithValue("@pref", string.Join(", ", selectedPrefs));

                                cmdClient.ExecuteNonQuery();
                            }

                            transaction.Commit();
                            MessageBox.Show("Client salvat cu succes!");
                            IncarcaDate();
                            ClearFields();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            throw ex;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la salvare: " + ex.Message);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            clientiLbl.Focus();
            if (string.IsNullOrEmpty(idClientTxt.Text))
            {
                MessageBox.Show("Selectați un client din tabel pentru a-l actualiza!");
                return;
            }

            try
            {
                List<string> selectedPrefs = new List<string>();
                foreach (var item in checkedListBoxPreferinte.CheckedItems)
                    selectedPrefs.Add(item.ToString());

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Clienti SET Nume=@nume, Telefon=@tel, DataNastere=@data, " +
                                 "IntereseSuplimentare=@interese, Preferinte=@pref WHERE ID_Utilizator=@id";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", idClientTxt.Text);
                    cmd.Parameters.AddWithValue("@nume", numeTextBox.Text);
                    cmd.Parameters.AddWithValue("@tel", telefonTextBox.Text);
                    cmd.Parameters.AddWithValue("@data", dataNasteriiDateTimePicker.Value);
                    cmd.Parameters.AddWithValue("@interese", intereseSuplimentareTxt.Text);
                    cmd.Parameters.AddWithValue("@pref", string.Join(", ", selectedPrefs));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Informațiile clientului au fost actualizate!");
                    IncarcaDate();
                }
            }
            catch (Exception ex) { MessageBox.Show("Eroare la update: " + ex.Message); }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            clientiLbl.Focus();
            if (string.IsNullOrEmpty(idClientTxt.Text)) return;

            if (MessageBox.Show("Stergeti definitiv acest client?", "Confirmare", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("DELETE FROM Clienti WHERE ID_Utilizator=@id", conn);
                        cmd.Parameters.AddWithValue("@id", idClientTxt.Text);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Client șters!");
                        IncarcaDate();
                        ClearFields();
                    }
                }
                catch (Exception ex) { MessageBox.Show("Eroare la stergere: " + ex.Message); }
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            clientiLbl.Focus();
            ClearFields();
        }

        private void ClearFields()
        {
            idClientTxt.Clear();
            numeTextBox.Clear();
            telefonTextBox.Clear();
            intereseSuplimentareTxt.Clear();
            dataNasteriiDateTimePicker.Value = DateTime.Now;
            for (int i = 0; i < checkedListBoxPreferinte.Items.Count; i++)
                checkedListBoxPreferinte.SetItemChecked(i, false);
        }
    }
}