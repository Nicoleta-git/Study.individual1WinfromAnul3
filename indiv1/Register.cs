using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace indiv1
{
    public partial class Register : KryptonForm
    {
        string connection = @"Data Source=NICOLETA\SQLEXPRESS;Initial Catalog=DarwinDB;Integrated Security=True;TrustServerCertificate=True";

        public Register()
        {
            InitializeComponent();
            PassTxt.UseSystemPasswordChar = true;
            PassTxt2.UseSystemPasswordChar = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            LogIn li = new LogIn();
            li.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool showPass = checkBox1.Checked;
            PassTxt.UseSystemPasswordChar = !showPass;
            PassTxt2.UseSystemPasswordChar = !showPass;
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            label1.Focus();
            lblEroare.Text = "";

            if (!acordCuTermeni.Checked)
            {
                lblEroare.ForeColor = Color.Red;
                lblEroare.Text = "Trebuie sa fiti de acord cu termenii!";
                return;
            }

            string username = userTxt.Text.Trim();
            string pass = PassTxt.Text.Trim();
            string email = emailTextBox.Text.Trim();

            if (string.IsNullOrEmpty(username) || pass != PassTxt2.Text.Trim() || !email.Contains("@"))
            {
                lblEroare.ForeColor = Color.Red;
                lblEroare.Text = "Date invalide! Verifica user, parola si email.";
                return;
            }

            lblEroare.ForeColor = Color.Blue;
            lblEroare.Text = "Se creeaza contul...";

            this.Refresh();

            try
            {
                using (SqlConnection conn = new SqlConnection(connection))
                {
                    conn.Open();

                    string sqlU = "INSERT INTO Utilizatori (Username, Parola, Email, ID_Rol, DataCreare) " +
                                  "OUTPUT INSERTED.ID_Utilizator VALUES (@u, @p, @e, 2, GETDATE())";

                    SqlCommand cmdU = new SqlCommand(sqlU, conn);
                    cmdU.Parameters.AddWithValue("@u", username);
                    cmdU.Parameters.AddWithValue("@p", pass);
                    cmdU.Parameters.AddWithValue("@e", email);

                    int userId = (int)cmdU.ExecuteScalar();

                    string sqlC = "INSERT INTO Clienti (ID_Utilizator, Nume, Telefon, DataNastere, IntereseSuplimentare) " +
                                  "VALUES (@id, @nume, @tel, @dn, @is)";

                    SqlCommand cmdC = new SqlCommand(sqlC, conn);
                    cmdC.Parameters.AddWithValue("@id", userId);
                    cmdC.Parameters.AddWithValue("@nume", username);
                    cmdC.Parameters.AddWithValue("@tel", TelefonTextBox.Text.Trim());
                    cmdC.Parameters.AddWithValue("@dn", kryptonDateTimePicker1.Value);
                    cmdC.Parameters.AddWithValue("@is", dataliiSuplimentareTextBox1.Text.Trim());

                    cmdC.ExecuteNonQuery();

                    MessageBox.Show("Inregistrare reusita!", "DarwinDB", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    new LogIn().Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                lblEroare.ForeColor = Color.Red;
                lblEroare.Text = "Eroare: " + ex.Message;
            }
        }


        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string titlu = "Termeni și Condiții DarwinDB";
            string mesaj = "Bun venit în comunitatea Darwin!\n\n" +
                           "Prin crearea acestui cont, confirmi că ești de acord cu Politica noastră de Confidențialitate. " +
                           "Datele tale sunt colectate în siguranță exclusiv pentru:\n" +
                           "• Gestionarea profilului de utilizator;\n" +
                           "• Procesarea comenzilor și plăților;\n" +
                           "• Securitatea tranzacțiilor tale.\n\n" +
                           "Ne angajăm să nu transmitem datele tale către terți fără acordul tău explicit.";

            MessageBox.Show(mesaj, titlu, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}