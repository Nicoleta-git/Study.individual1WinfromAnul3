using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace indiv1
{
    public partial class CatalogUserForm : UserControl
    {
        public CatalogUserForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd=new OpenFileDialog();

            ofd.Title = "Selecteaza o imagine";
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (ofd.ShowDialog() == DialogResult.OK)
                pictureBox1.Image = Image.FromFile(ofd.FileName);
        }
    }
}
