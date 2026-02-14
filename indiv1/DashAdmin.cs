using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace indiv1
{
    public partial class DashAdmin : KryptonForm
    {
        public DashAdmin()
        {
            InitializeComponent();
        }

        private void roundedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void menuPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // evenimentul de inchidere a aplicatiei
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // marirea si micsoararea aplicatiei
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void DashAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            LogIn li =  new LogIn();
            li.Show();
            this.Hide();
        }
    }
}
