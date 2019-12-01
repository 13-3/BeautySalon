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
    public partial class Services : Form
    {
        public Services()

        {
            InitializeComponent();
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        string path = "Data Source=DESKTOP-7V9KK3L\\SQLEXPRESS;Initial Catalog=BeautySalon;Integrated Security=True";
        DataSet appts = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        
        private void nextbtn_Click(object sender, EventArgs e)
        {
            SqlConnection nextbtn = new SqlConnection(path);
            nextbtn.Open();
            if (nextbtn.State == System.Data.ConnectionState.Open)
            {

                if (salonNameslistbx.SelectedItem.Equals("Maison de Joelle"))
                {
                    new MaisonDeJoelle().Show();
                    this.Hide();
                }
                else if(salonNameslistbx.SelectedItem.Equals("Nails Spa"))

                {
                    new Nails_spa().Show();
                    
                    this.Hide();
                }

            }

            

        }
    }
}
