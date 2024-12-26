using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace ODP1_Connected_Start
{
    public partial class Form31cs : Form
    {
        CrystalReport2 cr2;
        public Form31cs()
        {
            InitializeComponent();
        }

        private void Form31cs_Load(object sender, EventArgs e)
        {
            cr2 = new CrystalReport2();
            foreach(ParameterDiscreteValue v in cr2.ParameterFields[0].DefaultValues)
            {
                comboBox1.Items.Add(v.Value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cr2.SetParameterValue(0, comboBox1.Text);
            crystalReportViewer1.ReportSource = cr2;
        }
    }
}
