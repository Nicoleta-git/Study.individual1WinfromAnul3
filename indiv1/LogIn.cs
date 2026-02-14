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
    public partial class LogIn : KryptonForm
    {



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
            string username = userTxt.Text;
            string password = PassTxt.Text;


            if (username == "admin" && password == "1234")
            {
                DashAdmin da = new DashAdmin();
                da.Show();
                this.Hide();
            }
            else {
                lblEroare.ForeColor = Color.Red;
                lblEroare.Text = "Username sau parolă incorecte!";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.ShowDialog();
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
