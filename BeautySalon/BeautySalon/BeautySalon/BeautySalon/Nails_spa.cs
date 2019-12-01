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
    public partial class Nails_spa : Form

    {

      
        public Nails_spa()
        {
            InitializeComponent();
        }
          DataSet nails = new DataSet();
       public SqlConnection display = new SqlConnection("Data Source=DESKTOP-7V9KK3L\\SQLEXPRESS;Initial Catalog=BeautySalon;Integrated Security=True");
         SqlDataAdapter da = new SqlDataAdapter();
         DataSet dataSet = new DataSet();
         DataTable dt = new DataTable();
        private void Nails_spa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'beautySalonDataSet.Nails_Spa' table. You can move, or remove it, as needed.
            this.nails_SpaTableAdapter.Fill(this.beautySalonDataSet.Nails_Spa);
            da.SelectCommand = new SqlCommand("SELECT location,service,manicurists FROM Nails_Spa ", display);
            da.Fill(dataSet);
            NailaData.DataSource = dataSet.Tables[0];
        }

        private void Nailsspaapptlistbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.nails_SpaTableAdapter.FillBy(this.beautySalonDataSet.Nails_Spa);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }


        private void nailspabookbtn_Click(object sender, EventArgs e)
        {
            display.Open();
            if (display.State == System.Data.ConnectionState.Open)
            {
                List<SqlCommand> appt = new List<SqlCommand>();
                SqlCommand booking = new SqlCommand("select * from Nails_spa", display);
                appt.Add(booking);

                MessageBox.Show("A remider will be sent to your phone");
               
            }

            this.Close();
        }
    }
}
