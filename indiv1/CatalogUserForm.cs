using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace indiv1
{
    public partial class CatalogUserForm : UserControl
    {
        string connectionString = @"Data Source=NICOLETA\SQLEXPRESS;Initial Catalog=DarwinDB;Integrated Security=True;TrustServerCertificate=True";

        public CatalogUserForm()
        {
            InitializeComponent();
            DisplayProducts();
        }

        public void DisplayProducts()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Produse";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dataGridView1 != null)
                        dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la incarcare: " + ex.Message);
            }
        }

        private void cautaTxt_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Produse WHERE NumeProdus LIKE @search";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    da.SelectCommand.Parameters.AddWithValue("@search", "%" + cautaTxt.Text + "%");
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void importBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Selecteaza o imagine";
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
                ImgProdus.Image = Image.FromFile(ofd.FileName);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            label1.Focus();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"INSERT INTO Produse (NumeProdus, Categorie, Producator, Pret, Stoc, Specificatii_Software, Specificatii_Hardware, ImagineProdus, DataAdaugare) 
                                   VALUES (@nume, @cat, @prod, @pret, @stoc, @soft, @hard, @img, GETDATE())";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nume", numeProdusTxt.Text);
                        cmd.Parameters.AddWithValue("@cat", categorieProdusTxt.Text);
                        cmd.Parameters.AddWithValue("@prod", producatorTxt.Text);
                        cmd.Parameters.AddWithValue("@pret", decimal.Parse(pretTxt.Text));
                        cmd.Parameters.AddWithValue("@stoc", int.Parse(StocTxt.Text)); 
                        cmd.Parameters.AddWithValue("@soft", softwareTxt.Text);
                        cmd.Parameters.AddWithValue("@hard", HardwareTxt.Text);
                        cmd.Parameters.AddWithValue("@img", ImageToByteArray(ImgProdus.Image));

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Produs salvat cu succes!");
                        DisplayProducts();
                        clearBtn_Click(null, null);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Eroare la salvare: " + ex.Message); }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            label1.Focus();
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"UPDATE Produse SET NumeProdus=@nume, Categorie=@cat, Producator=@prod, 
                                   Pret=@pret, Stoc=@stoc, Specificatii_Software=@soft, Specificatii_Hardware=@hard, ImagineProdus=@img 
                                   WHERE ID_Produs=@id";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idProdusTxt.Text);
                        cmd.Parameters.AddWithValue("@nume", numeProdusTxt.Text);
                        cmd.Parameters.AddWithValue("@cat", categorieProdusTxt.Text);
                        cmd.Parameters.AddWithValue("@prod", producatorTxt.Text);
                        cmd.Parameters.AddWithValue("@pret", decimal.Parse(pretTxt.Text));
                        cmd.Parameters.AddWithValue("@stoc", int.Parse(StocTxt.Text)); 
                        cmd.Parameters.AddWithValue("@soft", softwareTxt.Text);
                        cmd.Parameters.AddWithValue("@hard", HardwareTxt.Text);
                        cmd.Parameters.AddWithValue("@img", ImageToByteArray(ImgProdus.Image));

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Produs actualizat!");
                        DisplayProducts();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Eroare la update: " + ex.Message); }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            label1.Focus();
            if (string.IsNullOrEmpty(idProdusTxt.Text)) { MessageBox.Show("Selecteaza un produs!"); return; }

            DialogResult result = MessageBox.Show("Sigur stergi acest produs?", "Confirmare", MessageBoxButtons.YesNo);
            if (result == DialogResult.No) return;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Produse WHERE ID_Produs=@id";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", idProdusTxt.Text);
                        cmd.ExecuteNonQuery();
                        DisplayProducts();
                        clearBtn_Click(null, null);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Eroare: " + ex.Message); }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            label1.Focus();
            idProdusTxt.Clear();
            numeProdusTxt.Clear();
            categorieProdusTxt.Clear();
            producatorTxt.Clear();
            pretTxt.Clear();
            StocTxt.Clear(); 
            softwareTxt.Clear();
            HardwareTxt.Clear();
            ImgProdus.Image = null;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                idProdusTxt.Text = row.Cells["ID_Produs"].Value.ToString();
                numeProdusTxt.Text = row.Cells["NumeProdus"].Value.ToString();
                categorieProdusTxt.Text = row.Cells["Categorie"].Value.ToString();
                producatorTxt.Text = row.Cells["Producator"].Value.ToString();
                pretTxt.Text = row.Cells["Pret"].Value.ToString();
                StocTxt.Text = row.Cells["Stoc"].Value.ToString();
                softwareTxt.Text = row.Cells["Specificatii_Software"].Value.ToString();
                HardwareTxt.Text = row.Cells["Specificatii_Hardware"].Value.ToString();

                if (row.Cells["ImagineProdus"].Value != DBNull.Value)
                {
                    byte[] imgData = (byte[])row.Cells["ImagineProdus"].Value;
                    using (MemoryStream ms = new MemoryStream(imgData))
                    {
                        ImgProdus.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    ImgProdus.Image = null;
                }
            }
        }

        private byte[] ImageToByteArray(Image image)
        {
            if (image == null) return null;
            using (MemoryStream ms = new MemoryStream())
            {
                Bitmap bmp = new Bitmap(image);
                bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }


    }
}