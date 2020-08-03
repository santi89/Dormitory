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
using CrystalDecisions.ReportSource;

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

            sql = "SELECT dbo.tbstudent.studentID, dbo.tbstudent.name, dbo.tbstudent.surname, dbo.tbstudent.gender, dbo.tbstudent.province, dbo.tbstudent.phone, dbo.tbstudent.email, dbo.tbdepartment.deptname, dbo.tbfaculty.facname,dbo.tbbuilding.buildingnumber, dbo.tbfloor.floornumber, dbo.tbschool.schoolname, dbo.tbroom.room_number FROM dbo.tbschool INNER JOIN dbo.tbstudent INNER JOIN dbo.tbdepartment ON dbo.tbstudent.deptID = dbo.tbdepartment.deptID INNER JOIN dbo.tbfaculty ON dbo.tbdepartment.facID = dbo.tbfaculty.facID ON dbo.tbschool.schoolID = dbo.tbfaculty.schoolID INNER JOIN  dbo.Rentdetail ON dbo.tbstudent.studentID = dbo.Rentdetail.studentID INNER JOIN dbo.tbfloor INNER JOIN dbo.tbbuilding ON dbo.tbfloor.buildingID = dbo.tbbuilding.buildingID INNER JOIN dbo.tbroom ON dbo.tbfloor.floorID = dbo.tbroom.floorID ON dbo.Rentdetail.roomID = dbo.tbroom.roomID where startdate Between '"+datetimepick .Value .ToString ("yyyy-MM-dd")+ "' and  '" + dateTimePickerend.Value.ToString("yyyy-MM-dd") + "'";
            da = new SqlDataAdapter(sql, con);
            da.Fill(ds,"stu");
            ReportDocument rpt = new ReportDocument();
            string path = "E:\\work\\C_Sharp_2_Project\\C_Sharp_2_Project\\studentreport.rpt";
            rpt.Load(path);
            /* rpt.SetParameterValue("dend", dateTimePickerend.Value.ToString("yyyy'/'MM'/'dd"));         
             rpt.SetParameterValue("date", datetimepick.Value.ToString("yyyy'/'MM'/'dd"));*/
            rpt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.Refresh();
        }

        private void Reportstudent_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePickerend_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
