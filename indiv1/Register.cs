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
    public partial class Register : KryptonForm
    {
        public Register()
        {
            InitializeComponent();
            PassTxt.UseSystemPasswordChar = true;
            PassTxt2.UseSystemPasswordChar = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            LogIn li = new LogIn();
            li.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                PassTxt.UseSystemPasswordChar = false;
                PassTxt2.UseSystemPasswordChar = false;
            }
            else
            {
                PassTxt.UseSystemPasswordChar = true;
                PassTxt2.UseSystemPasswordChar = true;
            }
        }


        // Registarea un BD
        private async void kryptonButton2_Click(object sender, EventArgs e)
        {
            string username = userTxt.Text;
            string password1 = PassTxt.Text;
            string password2 = PassTxt2.Text;

            if (string.IsNullOrWhiteSpace(username)) {
                lblEroare.ForeColor = Color.Red;
                lblEroare.Text = "Trebuie sa introduceti o denumire de utilizator";
                return;
            }

            // Mai tarziu: Verificare daca nu este in BD
            // aici ...
            

            if (password1 != password2) {
                lblEroare.Text = "Parolele nu se potrivesc";
                return;
            }

            if (password1.Length > 8) {
                lblEroare.Text = "Parola trebuie sa aiba 8 caractere";
                return;
             }

            bool hasUpper = false;
            foreach (char c in password1) {
                if (char.IsUpper(c)) { 
                    hasUpper=true; 
                    break;
                }
            }
            if (!hasUpper) {
                lblEroare.Text = "Parola trebuie sa contina macar un caracter mare";
                return;
            }

            string special= "!@#$%^&*()_+-=[]{};':\"\\|,.<>/?";
            bool hasSpecial = false;

            foreach (char c in password1) {
                if (special.Contains(c)) { 
                    hasSpecial=true;
                    break;
                }
            }

            if (!hasSpecial)
            {
                lblEroare.Text = "Parola trebuie sa contina cel putin un caracter special";
                return;
            }

            lblEroare.ForeColor = Color.Green;
            lblEroare.Text = "Parola este corecta, acum te loghezi!";

            // asteptam ca sa vedem mesajul
            await Task.Delay(1000);

            LogIn li = new LogIn();
            li.Show();
            this.Hide();

        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
