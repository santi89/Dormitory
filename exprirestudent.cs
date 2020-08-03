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
using CrystalDecisions.CrystalReports.Engine;

namespace C_Sharp_2_Project
{
    public partial class exprirestudent : Form
    {
        public exprirestudent()
        {
            InitializeComponent();
        }
        SqlConnection con = Connect.getconnect();
        SqlDataAdapter da;
        SqlCommand cmd;

        DataSet ds = new DataSet();
        string sql = "";
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "SELECT dbo.Rentdetail.studentID, dbo.tbstudent.name, dbo.tbstudent.surname, dbo.Rentdetail.enddate, dbo.tbroom.room_number, dbo.tbfloor.floornumber, dbo.tbbuilding.buildingnumber FROM dbo.tbfloor INNER JOIN dbo.tbbuilding ON dbo.tbfloor.buildingID = dbo.tbbuilding.buildingID INNER JOIN  dbo.tbroom ON dbo.tbfloor.floorID = dbo.tbroom.floorID INNER JOIN dbo.Rentdetail INNER JOIN dbo.tbstudent ON dbo.Rentdetail.studentID = dbo.tbstudent.studentID ON dbo.tbroom.roomID = dbo.Rentdetail.roomID where enddate between '"+ dateTimePicker1 .Value .ToString ("yyyy-MM-dd")+ "' and '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "'";
                da = new SqlDataAdapter(sql, con);
                da.Fill(ds, "exprice");
                ReportDocument rpt = new ReportDocument();
            string path = "E:\\work\\C_Sharp_2_Project\\C_Sharp_2_Project\\expriredate.rpt";
            rpt.Load(path);
                rpt.SetDataSource (ds);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
