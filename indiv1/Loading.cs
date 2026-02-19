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
    public partial class Loading : KryptonForm
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void Loading_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            customProgressBar1.Increment(3);
            if (customProgressBar1.Value == 100) {
                timer1.Enabled = false;
                LogIn li = new LogIn();
                li.Show();
                this.Hide();
            }
        }
    }
}
