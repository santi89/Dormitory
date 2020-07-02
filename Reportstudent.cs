using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;

namespace C_Sharp_2_Project
{
    public partial class Reportstudent : Form
    {
        SqlConnection con = Connect.getconnect();
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds = new DataSet();
        string sql = "";

        public Reportstudent()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
           


        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReportDocument rpt = new ReportDocument();
            string path = "E:\\work\\C_Sharp_2_Project\\C_Sharp_2_Project\\studentreport.rpt";
            rpt.Load(path);
            rpt.SetParameterValue("date", datetimepick.Value);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }
    }
}
