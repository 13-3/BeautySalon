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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public string cmdpath = "Data Source=DESKTOP-7V9KK3L\\SQLEXPRESS;Initial Catalog=BeautySalon;Integrated Security=True";
       
        
        private void save_btn_Click(object sender, EventArgs e)
        {
            SqlConnection save = new SqlConnection(cmdpath);
            save.Open();
            if (save.State == System.Data.ConnectionState.Open)
            {
                
                string userName = usernametbx.Text.ToString();
              
                string firstName = firstNametbx.Text.ToString();
                string lastName = lastNametbx.Text.ToString();
                string phoneNumber = phoneNumbertxb.Text.ToString();
                
                string password = passwordtxb.Text.ToString();
                string email = emailtxb.Text.ToString();


                customer signUp = new customer(firstName, lastName, phoneNumber,email,userName,password);

                string signupValues = "insert into customer1(username,first_name,last_name,phone_number,password,email)values('" + userName + "','" 
                    + firstName + "','" + lastName + "','" + phoneNumber + "','"+password+ "','" +email+ "')";

                SqlCommand signUpcommand = new SqlCommand(signupValues,save);
                signUpcommand.ExecuteNonQuery();

                MessageBox.Show("saved as "+ signUp.GetType());
                this.Close();

            }

                new beautySalon().Show();
           
        }

        public void ad(customer signup)
        {

        }

        private void firstnmlbl_Click(object sender, EventArgs e)
        {

        }

        private void idlbl_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void usernametbx_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void lastNametbx_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
