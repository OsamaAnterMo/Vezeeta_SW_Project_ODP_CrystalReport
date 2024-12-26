using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Types;
using Oracle.DataAccess.Client;

namespace ODP1_Connected_Start
{
    public partial class Add_appoinment : Form
    {
        string ordb = "Data Source= orcl; User id=scott;Password=tiger;";
        OracleConnection conn;
        public Add_appoinment()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //add appoinment
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = conn.CreateCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select APPOINTMENT_NUMBER from APPOINTMENT ";
            //"select APPOINTMENT_NUMBER from APPOINTMENT where PATIENT_ID =: ID";
            //cmd.Parameters.Add("id",);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox4.Items.Add(dr[0]);
            }
          
            ////////////
            
            OracleCommand c = conn.CreateCommand();
            c.Connection = conn;
            c.CommandText = "select SPEC_ID from SPECIALIZATION";
            //"select APPOINTMENT_NUMBER from APPOINTMENT where PATIENT_ID =: ID";
            //cmd.Parameters.Add("id",);
            while (dr.Read())
            {
                comboBox4.Items.Add(dr[0]);
            }
            dr.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //speciallzation list
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        //load appointmet number 
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
