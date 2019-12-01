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
    public partial class Salon : Form
    {
        public Salon()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection("Data Source=DESKTOP-7V9KK3L\\SQLEXPRESS;Initial Catalog=BeautySalon;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet dataSet = new DataSet();
        private void cancelbtn_Click(object sender, EventArgs e)
        {
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                SqlCommand cancell = new SqlCommand("select * from appoointment",con);
                cancell.Cancel();

                MessageBox.Show("cancelled");
                
            }
            // cancel an appotinment
            
            

        }



       
        private void searchbtn_Click(object sender, EventArgs e)
        {
            new Services().Show();
            this.Hide();

        }

        private void Salon_Load(object sender, EventArgs e)
        {

        }
    }
}
