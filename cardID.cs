using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_2_Project
{
    public partial class cardID : Form
    {
        public cardID()
        {
            InitializeComponent();
        }

        private void ReportViewer1_Load(object sender, EventArgs e)
        {

        }
        public string ids = "";
        private void cardID_Load(object sender, EventArgs e)
        {
            ReportDocument rpt = new ReportDocument();
            string path = "E:\\work\\C_Sharp_2_Project\\C_Sharp_2_Project\\Crystalcard.rpt";
            rpt.Load(path);
            rpt.SetParameterValue("id",ids);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }
    }
}
