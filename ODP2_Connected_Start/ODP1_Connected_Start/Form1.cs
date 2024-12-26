using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ODP1_Connected_Start
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    this.Hide();
        //    Form3 f3 = new Form3();
        //    f3.ShowDialog();
        //}
        //forms
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_appoinment a = new Add_appoinment();
            a.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Add_appoinment a = new Add_appoinment();
            a.ShowDialog();

        }
        //report1
        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form31cs f3 = new Form31cs();
            f3.ShowDialog();
        }
    }
}
