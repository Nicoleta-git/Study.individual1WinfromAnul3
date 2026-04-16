using System;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace indiv1
{
    public partial class DashAdmin : KryptonForm
    {
        public DashAdmin()
        {
            InitializeComponent();
            dashboardAdmin1.Visible = true;
            dashboardAdmin1.BringToFront();
        }

        bool menuExpand = false;

        int menuMaxHeight = 120;  
        int menuMinHeight = 0; 
        int menuSpeed = 10;
        public KryptonPalette PalettePrincipala
        {
            get { return kryptonPalette1; }
        }

        public KryptonButton ButonPrincipal
        {
            get { return kryptonButton1; }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Height = menuMinHeight;
        }

        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
            containerPagina.Focus();
        }

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {

                flowLayoutPanel1.Height += menuSpeed;

                if (flowLayoutPanel1.Height >= menuMaxHeight)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                flowLayoutPanel1.Height -= menuSpeed;

                if (flowLayoutPanel1.Height <= menuMinHeight)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            catalogUserForm1.Visible = false;
            dashboardAdmin1.Visible = true;
            dashboardAdmin1.BringToFront();
            containerPagina.Focus();
            rapoarte1.Visible = false;


        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            catalogUserForm1.Visible = true;
            catalogUserForm1.BringToFront();
            dashboardAdmin1.Visible = false;
            containerPagina.Focus();
            rapoarte1.Visible = false;

        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            clientiManagement1.Visible = true;
            clientiManagement1.BringToFront();

            catalogUserForm1.Visible = false;
            dashboardAdmin1.Visible = false;
            containerPagina.Focus();
            rapoarte1.Visible = false;


        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            containerPagina.Focus();
            DialogResult result = MessageBox.Show("Esti sigur ca vrei sa iesi?", "Progresul se va salva", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                LogIn li = new LogIn();
                li.Show();
            }

        }

        private void kryptonButton8_Click(object sender, EventArgs e)
        {
            setari1.Visible = true;
            setari1.BringToFront();

            catalogUserForm1.Visible = false;
            dashboardAdmin1.Visible = false;
            clientiManagement1.Visible = false;
            containerPagina.Focus();
            rapoarte1.Visible = false;

        }

        private void kryptonButton7_Click(object sender, EventArgs e)
        {
            comenzi2.Visible = true;
            comenzi2.BringToFront();

            catalogUserForm1.Visible = false;
            dashboardAdmin1.Visible = false;
            clientiManagement1.Visible = false;
            setari1.Visible = false;
            containerPagina.Focus();
            rapoarte1.Visible = false;

        }

        private void kryptonButton9_Click(object sender, EventArgs e)
        {
            angajati1.BringToFront();
            containerPagina.Focus();
            rapoarte1.Visible = false;
        }

        private void kryptonButton10_Click(object sender, EventArgs e)
        {
            anunturi1.BringToFront();
            containerPagina.Focus();
            rapoarte1.Visible = false;
        }

        // rapoarte
        private void kryptonButton11_Click(object sender, EventArgs e)
        {
            rapoarte1.Visible = true;
            rapoarte1.BringToFront();
            containerPagina.Focus();
        }

        private void DashAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}