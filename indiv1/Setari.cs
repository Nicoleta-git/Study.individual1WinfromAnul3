using ComponentFactory.Krypton.Toolkit;
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

namespace indiv1
{
    public partial class Setari : UserControl
    {
        private string connectionString = @"Data Source=NICOLETA\SQLEXPRESS;Initial Catalog=DarwinDB;Integrated Security=True;TrustServerCertificate=True";

        private int idUtilizatorCurent = 1;

        public Setari()
        {
            InitializeComponent();
        }

        private void Setari_Load(object sender, EventArgs e)
        {
            IncarcaDateUtilizator();
        }


        private void IncarcaDateUtilizator()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = @"SELECT U.Username, U.Parola, R.NumeRol 
                                 FROM Utilizatori U 
                                 INNER JOIN Roluri R ON U.ID_Rol = R.ID_Rol 
                                 WHERE U.ID_Utilizator = @id";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", idUtilizatorCurent);

                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        numeUtilizatorTxt.Text = dr["Username"].ToString();
                        parolaTxt.Text = dr["Parola"].ToString();
                        rolTxt.Text = dr["NumeRol"].ToString();

                        rolTxt.ReadOnly = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la incarcare: " + ex.Message);
            }
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            label1.Focus();
            if (string.IsNullOrWhiteSpace(numeUtilizatorTxt.Text) || string.IsNullOrWhiteSpace(parolaTxt.Text))
            {
                KryptonMessageBox.Show("Te rog completează toate campurile!");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string sql = "UPDATE Utilizatori SET Username = @user, Parola = @pass WHERE ID_Utilizator = @id";

                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@user", numeUtilizatorTxt.Text);
                    cmd.Parameters.AddWithValue("@pass", parolaTxt.Text);
                    cmd.Parameters.AddWithValue("@id", idUtilizatorCurent);

                    int rezultat = cmd.ExecuteNonQuery();
                    if (rezultat > 0)
                    {
                        KryptonMessageBox.Show("Datele au fost actualizate!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show("Eroare la salvare: " + ex.Message);
            }
        }


        private void AplicaTema(Color color1, Color color2)
        {
            var parentForm = this.ParentForm;

            if (parentForm is UserInterface ui)
            {
                ui.PalettePrincipala.HeaderStyles.HeaderCommon.StateCommon.Back.Color1 = color1;
                ui.PalettePrincipala.HeaderStyles.HeaderCommon.StateCommon.Back.Color2 = color2;

                ui.ButonPrincipal.StateCommon.Back.Color1 = color1;
                ui.ButonPrincipal.StateCommon.Back.Color2 = color2;
                ui.ButonPrincipal.StateCommon.Back.ColorStyle = PaletteColorStyle.Linear;
                ui.ButonPrincipal.StateCommon.Content.ShortText.Color1 = Color.White;

                ui.Invalidate();
                ui.ButonPrincipal.Invalidate();
            }
            else if (parentForm is DashAdmin admin)
            {
                admin.PalettePrincipala.HeaderStyles.HeaderCommon.StateCommon.Back.Color1 = color1;
                admin.PalettePrincipala.HeaderStyles.HeaderCommon.StateCommon.Back.Color2 = color2;

                admin.ButonPrincipal.StateCommon.Back.Color1 = color1;
                admin.ButonPrincipal.StateCommon.Back.Color2 = color2;
                admin.ButonPrincipal.StateCommon.Back.ColorStyle = PaletteColorStyle.Linear;
                admin.ButonPrincipal.StateCommon.Content.ShortText.Color1 = Color.White;

                admin.Invalidate();
                admin.ButonPrincipal.Invalidate();
            }

            label1.Focus(); 
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            AplicaTema(Color.Blue, Color.Black);
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            AplicaTema(Color.FromArgb(66, 66, 66), Color.Black);
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            AplicaTema(Color.FromArgb(143, 57, 3), Color.Black);
        }

        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            AplicaTema(Color.Purple, Color.Black);
        }

        private void roundedPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void roundedPanel2_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}