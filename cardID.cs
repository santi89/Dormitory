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
using System.Data.SqlClient;


namespace C_Sharp_2_Project
{
    public partial class cardID : Form
    {
        public cardID()
        {
            InitializeComponent();
        }
        SqlConnection con = Connect.getconnect();
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds = new DataSet();
        string sql = "";

        private void ReportViewer1_Load(object sender, EventArgs e)
        {

        }
        public string ids ="";
        private void cardID_Load(object sender, EventArgs e)
        {

            sql = "SELECT dbo.Rentdetail.studentID, dbo.Rentdetail.startdate, dbo.Rentdetail.enddate, dbo.tbroom.room_number, dbo.tbstudent.name, dbo.tbstudent.surname, dbo.tbstudent.picture, dbo.tbbuilding.buildingnumber, dbo.tbfloor.floornumber,dbo.tbdepartment.deptname, dbo.tbfaculty.facname, dbo.tbschool.schoolnameFROM    dbo.tbroom INNER JOIN dbo.tbfloor INNER JOIN dbo.tbbuilding ON dbo.tbfloor.buildingID = dbo.tbbuilding.buildingID ON dbo.tbroom.floorID = dbo.tbfloor.floorID INNER JOIN dbo.Rentdetail ON dbo.tbroom.roomID = dbo.Rentdetail.roomID INNER JOIN dbo.tbroomtype ON dbo.tbbuilding.roomtypeID = dbo.tbroomtype.roomtypeID INNER JOIN dbo.tbstudent ON dbo.Rentdetail.studentID = dbo.tbstudent.studentID INNER JOIN dbo.tbfaculty INNER JOIN dbo.tbdepartment ON dbo.tbfaculty.facID = dbo.tbdepartment.facID INNER JOIN dbo.tbschool ON dbo.tbfaculty.schoolID = dbo.tbschool.schoolID ON dbo.tbstudent.deptID = dbo.tbdepartment.deptID where studentID='"+ids+"'";
            cmd = new SqlCommand(sql, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds,"Datatable3");
            if (ds.Tables ["Datatable3"] != null)
            {
                ds.Tables.Clear();
            }
            da.Fill(ds, "Datatable3");

            ReportDocument rpt = new ReportDocument();
            string path = "E:\\work\\C_Sharp_2_Project\\C_Sharp_2_Project\\Crystalcard.rpt";
            rpt.Load(path);
            rpt.SetDataSource (ds);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
