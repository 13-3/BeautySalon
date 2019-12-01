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
   
    public partial class MaisonDeJoelle : Form
    {
        
       
        public MaisonDeJoelle()
        {
            InitializeComponent();
        }
        
        SqlConnection display = new SqlConnection("Data Source=DESKTOP-7V9KK3L\\SQLEXPRESS;Initial Catalog=BeautySalon;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet dataSet = new DataSet();
        private void MaisonDeJoelle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'beautySalonDataSet1.Maison_de_joelle' table. You can move, or remove it, as needed.
            this.maison_de_joelleTableAdapter.Fill(this.beautySalonDataSet1.Maison_de_joelle);

            da.SelectCommand = new SqlCommand("SELECT location,service,stylist FROM Maison_De_Joelle",display);
            da.Fill(dataSet);
           
            
            MaisonData.DataSource = dataSet.Tables[0];
            
            }

        private void MaisonData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.maison_de_joelleTableAdapter.FillBy(this.beautySalonDataSet1.Maison_de_joelle);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void maisonBookbtn_Click(object sender, EventArgs e)
        {
            display.Open();
            if (display.State == System.Data.ConnectionState.Open)
            {
                List<SqlCommand> appt = new List<SqlCommand>();
                SqlCommand booking = new SqlCommand("select * from maison_de_joelle",display);
                
                appt.Add(booking);
                MessageBox.Show("A reminder will be sent to your phone");
                
            }

            this.Close();
        }

        private void Maisondeapptslisbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

