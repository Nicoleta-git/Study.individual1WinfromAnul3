using System;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace indiv1
{
    public partial class UserInterface : KryptonForm
    {
        bool menuExpand = false;
        int menuMaxHeight = 90;
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

        public UserInterface()
        {
            InitializeComponent();

            dashUser1.Visible = true;
            dashUser1.BringToFront();
            ucCatalog1.Visible = false;
            istoric1.Visible = false;
        }

        private void UserInterface_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Height = menuMinHeight;
            HideAllPages();
            dashUser1.Visible = true;
            istoric1.Visible = false;
        }

        private void AfiseazaCatalog(string categorie)
        {
            HideAllPages();
            ucCatalog1.ActualizeazaCategorie(categorie);
            ucCatalog1.Visible = true;
            ucCatalog1.BringToFront();
            containerPagina.Focus();
            istoric1.Visible = false;
        }

        private void HideAllPages()
        {
            dashUser1.Visible = false;
            ucCatalog1.Visible = false;
            istoric1.Visible = false;
            setari1.Visible = false;
            istoric1.Visible = false;
        }

        private void kryptonButton5_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
            containerPagina.Focus();
        }

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (!menuExpand)
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
            HideAllPages();
            dashUser1.Visible = true;
            dashUser1.BringToFront();
            containerPagina.Focus();
            istoric1.Visible = false;
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            AfiseazaCatalog("Laptop");
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            AfiseazaCatalog("Telefon");
        }

        private void kryptonButton7_Click(object sender, EventArgs e)
        {
            AfiseazaCatalog("Casti");
        }

        private void kryptonButton8_Click(object sender, EventArgs e)
        {
            HideAllPages();
            setari1.Visible = true;
            setari1.BringToFront();
            containerPagina.Focus();
            istoric1.Visible = false;
        }


        //istoric
        private void kryptonButton11_Click(object sender, EventArgs e)
        {
            HideAllPages();
            istoric1.Visible = true;
            istoric1.BringToFront();
            containerPagina.Focus();
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

        private void UserInterface_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}