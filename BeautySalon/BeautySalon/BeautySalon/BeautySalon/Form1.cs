using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautySalon
{
    public partial class beautySalon : Form
    {
        public beautySalon()
        {
            InitializeComponent();
        }

        private void beautySalon_Load(object sender, EventArgs e)
        {

        }

        private void signUp_Click(object sender, EventArgs e)
        {

        }

        private void logIn_Click(object sender, EventArgs e)
        {
            new LogIn().Show();
            this.Hide();
        }

        private void signUp_Click_1(object sender, EventArgs e)
        {
            new SignUp().Show();
            this.Hide();
        }
    }
}
