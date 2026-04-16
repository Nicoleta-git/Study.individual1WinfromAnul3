using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace indiv1
{

    public partial class LogIn : KryptonForm
    {
        string connection = @"Data Source=NICOLETA\SQLEXPRESS;Initial Catalog=DarwinDB;Integrated Security=True;TrustServerCertificate=True";

        public LogIn()
        {
            InitializeComponent();
            PassTxt.UseSystemPasswordChar = true;
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }


        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            string username = userTxt.Text.Trim();
            string password = PassTxt.Text.Trim();

            userTxt.Focus();

            try
            {
                using (SqlConnection connect = new SqlConnection(connection))
                {
                    connect.Open();

                    string query = @"SELECT ID_Utilizator, ID_Rol 
                             FROM Utilizatori 
                             WHERE Username = @username 
                             AND Parola = @password";

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) 
                            {

                                SesiuneUtilizator.ID_Utilizator = Convert.ToInt32(reader["ID_Utilizator"]);
                                SesiuneUtilizator.ID_Rol = Convert.ToInt32(reader["ID_Rol"]);
                                SesiuneUtilizator.Username = username;

                                lblEroare.ForeColor = Color.Green;
                                lblEroare.Text = "Autentificare reusita!";

                                if (SesiuneUtilizator.ID_Rol == 2) 
                                {
                                    UserInterface ui = new UserInterface();
                                    ui.Show();
                                }
                                else if (SesiuneUtilizator.ID_Rol == 1) 
                                {
                                    DashAdmin admin = new DashAdmin();
                                    admin.Show();
                                }

                                this.Hide();
                            }
                            else
                            {
                                lblEroare.ForeColor = Color.Red;
                                lblEroare.Text = "Username sau parola incorecta!";
                                PassTxt.Clear();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la conectarea cu baza de date: " + ex.Message);
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                PassTxt.UseSystemPasswordChar = false;
            }
            else {
                PassTxt.UseSystemPasswordChar = true;
            }
        }

        private void PassTxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
