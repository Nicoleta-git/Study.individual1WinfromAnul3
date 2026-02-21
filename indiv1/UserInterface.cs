using System;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace indiv1
{
    public partial class UserInterface : KryptonForm
    {
        bool menuExpand = false;

        int menuMaxHeight = 90;  // inaltime maxima cand e deschis
        int menuMinHeight = 0;    // inaltime minima cand e inchis
        int menuSpeed = 10;       // viteza animatie

        public UserInterface()
        {
            InitializeComponent();

            dashUser1.Visible = true;
            dashUser1.BringToFront();
        }

        private void UserInterface_Load(object sender, EventArgs e)
        {
            // porneste inchis
            flowLayoutPanel1.Height = menuMinHeight;

            HideAllPages();
            dashUser1.Visible = true;
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

        private void HideAllPages()
        {
            dashUser1.Visible = false;
            laptopuri1.Visible = false;
            telefoane1.Visible = false;
            casti1.Visible = false;
            istoric1.Visible = false;
            setari1.Visible = false;
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            HideAllPages();
            dashUser1.Visible = true;
            dashUser1.BringToFront();
            containerPagina.Focus();
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            HideAllPages();
            laptopuri1.Visible = true;
            laptopuri1.BringToFront();
            containerPagina.Focus();
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            HideAllPages();
            telefoane1.Visible = true;
            telefoane1.BringToFront();
            containerPagina.Focus();
        }

        private void kryptonButton7_Click(object sender, EventArgs e)
        {
            HideAllPages();
            casti1.Visible = true;
            casti1.BringToFront();
            containerPagina.Focus();
        }

        private void kryptonButton8_Click(object sender, EventArgs e)
        {
            HideAllPages();
            setari1.Visible = true;
            setari1.BringToFront();
            containerPagina.Focus();
        }

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
    }
}