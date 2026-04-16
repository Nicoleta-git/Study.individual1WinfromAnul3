using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace indiv1
{
    public partial class Produs : UserControl
    {
        public event EventHandler OnAdaugaInCos;

        public string NumeProdus { get; private set; }
        public double PretProdus { get; private set; }

        public Produs()
        {
            InitializeComponent();
        }

        public void IncarcaDate(string nume, double pret, int stoc, byte[] imagineRaw)
        {
            this.NumeProdus = nume;
            this.PretProdus = pret;

            productTxt.Text = nume;
            priceTxt.Text = pret.ToString("N2") + " MDL";

            ToolTip tt = new ToolTip();
            tt.SetToolTip(productTxt, nume);

            if (imagineRaw != null && imagineRaw.Length > 0)
            {
                try
                {
                    using (MemoryStream ms = new MemoryStream(imagineRaw))
                    {
                        imgProdus.Image = Image.FromStream(ms);
                        imgProdus.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }
                catch (Exception) { 
                
                }
            }
        }

        private void Produs_Load(object sender, EventArgs e)
        {
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            priceTxt.Focus();
            if (OnAdaugaInCos != null)
            {
                OnAdaugaInCos(this, EventArgs.Empty);
            }
        }
    }
}