using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BeautySalon
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            
        }



        private void password_Click(object sender, EventArgs e)
        {

        }

        private void userName_Click(object sender, EventArgs e)
        {

        }

        private void uName_TextChanged(object sender, EventArgs e)
        {

        }


        public string cmdpath = "Data Source=DESKTOP-7V9KK3L\\SQLEXPRESS;Initial Catalog=BeautySalon;Integrated Security=True";
        
        private void logInbtn_Click(object sender, EventArgs e)
        {
            SqlConnection login = new SqlConnection(cmdpath);
           
            login.Open();
            if (login.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    SqlCommand checkUser = new SqlCommand("SELECT * FROM [CUSTOMER1] where username=@username AND password=@password", login);
                    checkUser.Parameters.AddWithValue("@username", userlogingtxb.Text);
                    checkUser.Parameters.AddWithValue("@password", passlogingtxb.Text);
                    SqlDataReader rd = checkUser.ExecuteReader();

                    if (rd.Read())
                    {

                        new Salon().Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("You are not registered");
                        this.Close();
                        new beautySalon().Show();
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("An error occured");
                    new LogIn().Show();
                    this.Hide();

                }
               
                
            }

        }

        private void usernamelogingtxb_TextChanged(object sender, EventArgs e)
        {

        }

        private void passlogingtxb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
