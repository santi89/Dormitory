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
            sql = " SELECT dbo.tbstudent.studentID,dbo.tbstudent.name, dbo.tbstudent.surname,dbo.tbstudent.province, dbo.tbschool.schoolname,dbo.tbfaculty.facname,dbo.tbdepartment.deptname,dbo.tbroom.room_number,dbo.tbfloor.floornumber ,dbo.tbbuilding.buildingnumber,startdate,enddate FROM dbo.tbschool INNER JOIN dbo.tbstudent INNER JOIN dbo.tbdepartment ON dbo.tbstudent.deptID = dbo.tbdepartment.deptID INNER JOIN dbo.tbfaculty ON dbo.tbdepartment.facID = dbo.tbfaculty.facID ON dbo.tbschool.schoolID = dbo.tbfaculty.schoolID INNER JOIN  dbo.Rentdetail ON dbo.tbstudent.studentID = dbo.Rentdetail.studentID INNER JOIN dbo.tbfloor INNER JOIN dbo.tbbuilding ON dbo.tbfloor.buildingID = dbo.tbbuilding.buildingID INNER JOIN dbo.tbroom ON dbo.tbfloor.floorID = dbo.tbroom.floorID ON dbo.Rentdetail.roomID = dbo.tbroom.roomID where startdate Between '" + datetimepick.Value.ToString("yyyy-MM-dd")+ "' and '" + dateTimePickerend.Value.ToString("yyyy-MM-dd") + "'";
            da = new SqlDataAdapter(sql, con);
            da.Fill(ds, "DataTable1");
            if (ds.Tables["DataTable1"] != null)
            {
               ds.Tables.Clear();
            }
            da.Fill(ds, "DataTable1");
            ReportDocument rpt = new ReportDocument();
            string path = "E:\\work\\C_Sharp_2_Project\\C_Sharp_2_Project\\studentreport.rpt";
            rpt.Load(path);              
            rpt.SetDataSource(ds);
           
            crystalReportV.ReportSource = rpt;
            rpt.Refresh();
            crystalReportV.Refresh();           
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

        private void datetimepick_ValueChanged(object sender, EventArgs e)
        {
            if (datetimepick .Value > dateTimePickerend.Value)
            {
                MessageBox.Show("ເວລາເລີມຕົ້ນກາຍເວລາສຸດທ້າຍ");
                
            }
            dateTimePickerend.Value.AddDays(10);
        }
    }
}
