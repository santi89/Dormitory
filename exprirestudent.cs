using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace C_Sharp_2_Project
{
    public partial class exprirestudent : Form
    {
        public exprirestudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ReportDocument rpt = new ReportDocument();
            string path = "E:\\work\\C_Sharp_2_Project\\C_Sharp_2_Project\\expriredate.rpt";
            rpt.Load(path);
            rpt.SetParameterValue("date", dateTimePicker1.Value);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
            }
            catch (Exception)
            {

                throw;
            }
           
        }
    }
}
