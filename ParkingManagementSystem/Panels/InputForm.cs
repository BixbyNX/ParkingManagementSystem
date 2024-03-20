using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ParkingManagementSystem.Panels
{
    public partial class InputForm : Form
    {

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-DLTS2CD\SQLEXPRESS;Initial Catalog=LoginDatabaseTemp;Integrated Security=True");
        PictureBox numberButtons;
        public InputForm()
        {
            InitializeComponent();
        }
        public InputForm(PictureBox p)
        {
            InitializeComponent();
            numberButtons = p;
        }

        private void InputForm_Load(object sender, EventArgs e)
        {

            try
            {
                conn.Open();
                SqlCommand slot_num = new SqlCommand("SELECT SlotNumber FROM SlotNumDb WHERE Status = 'Available'", conn);
                SqlDataReader slot_reader = slot_num.ExecuteReader();

                DataTable dtslots = new DataTable();
                dtslots.Columns.Add("SlotNumber", typeof(string));
                dtslots.Load(slot_reader);

                comboBox1.ValueMember = "SlotNumber";
                comboBox1.DataSource = dtslots;
                conn.Close();

            }
            catch (Exception)
            {


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            conn.Open();
            SqlCommand querry = new SqlCommand("UPDATE  SlotNumDb SET Status = 'Unavailable' WHERE SlotNumber = '" + comboBox1.Text + "'",conn); //query 
            SqlDataReader reader = querry.ExecuteReader();
            conn.Close();
    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand querry = new SqlCommand("UPDATE  SlotNumDb SET Status = 'Available' WHERE SlotNumber = '" + comboBox1.Text + "'", conn); //query 
            SqlDataReader reader = querry.ExecuteReader();
            conn.Close();

        }
    }

 }

