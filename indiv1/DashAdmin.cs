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
            AfiseazaPagina(dashboardAdmin1);
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

        private void AscundeToatePagini()
        {
            dashboardAdmin1.Visible = false;
            catalogUserForm1.Visible = false;
            clientiManagement1.Visible = false;
            setari1.Visible = false;
            comenzi2.Visible = false;
            angajati1.Visible = false;
            anunturi1.Visible = false;
            rapoarte1.Visible = false;
        }

        private void AfiseazaPagina(UserControl pagina)
        {
            AscundeToatePagini();
            pagina.Visible = true;
            pagina.BringToFront();
            containerPagina.Focus();
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
            AfiseazaPagina(dashboardAdmin1);
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            AfiseazaPagina(catalogUserForm1);
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            AfiseazaPagina(clientiManagement1);
        }

        private void kryptonButton8_Click(object sender, EventArgs e)
        {
            AfiseazaPagina(setari1);
        }

        private void kryptonButton7_Click(object sender, EventArgs e)
        {
            AfiseazaPagina(comenzi2);
        }

        private void kryptonButton9_Click(object sender, EventArgs e)
        {
            AfiseazaPagina(angajati1);
        }

        private void kryptonButton10_Click(object sender, EventArgs e)
        {
            AfiseazaPagina(anunturi1);
        }

        private void kryptonButton11_Click(object sender, EventArgs e)
        {
            AfiseazaPagina(rapoarte1);
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

        private void DashAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}