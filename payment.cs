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
using System.Data.Sql;

namespace C_Sharp_2_Project
{
    public partial class payment : Form
    {
        SqlConnection con = Connect.getconnect();
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataSet ds = new DataSet();
        string sql = "";
        public payment()
        {
            InitializeComponent();
            

            troomcombo();
            builcombo();
            flocombo();
            roomcombo();
        }

        public void roomcombo()
        {
            try
            {
 sql = "select * from tbroom inner join tbfloor on tbfloor.floorID=tbfloor.floorID where floornumber=N'" + cbfloor.SelectedItem + "' and ";
            cmd = new SqlCommand(sql, con);
            dr = cmd.ExecuteReader();
                while (dr.Read())
            {
                cbroom.Items.Add(dr.GetString(1));

            }dr.Close();
            }
            catch (Exception ex)
            {
                throw;
            }         
        }
       public void flocombo()
        {
            try
            {
            sql = "select floornumber from tbfloor inner join tbbuilding on tbbuilding.buildingID=tbfloor.buildingID where buildingnumber='"+cbbuilding .SelectedItem +"'";
            cmd = new SqlCommand(sql, con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbfloor.Items.Add(dr.GetString(0));

            }dr.Close();
            }
            catch (Exception ex)
            {
                throw;
            }
            
        }
        private void troomcombo()
        {
            try
            {
                sql = "select * from tbroomtype";
                cmd = new SqlCommand(sql, con);
                dr = cmd.ExecuteReader();
                cbtroom.Items.Clear();
               
                while (dr.Read())
                {
                    cbtroom.Items.Add(dr.GetString(1));
                    
                }
                dr.Close();
                
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        private void builcombo()
        {
            sql = "select buildingnumber from tbbuilding inner join tbroomtype on tbroomtype.roomtypeID=tbbuilding.roomtypeID where typename= N'"+cbtroom.SelectedItem +"'";
            cmd=new SqlCommand (sql, con);
            dr = cmd.ExecuteReader();
            cbbuilding.Items.Clear();
            while (dr.Read())
            {
                cbbuilding.Items.Add(dr.GetString(0));
            }dr.Close();

                    }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {   if (txtsearch .Text =="" ){
                    return;
                    }
                if (rbcontinues.Checked == true)
                {
                    sql = "SELECT rentID,studentID,typename,buildingnumber,floornumber,room_number,startdate,enddate,cost FROM Rentdetail inner join tbbuilding on tbbuilding.buildingID =Rentdetail.buildingID inner join tbfloor on tbfloor.floorID= Rentdetail.floorID inner join tbroomtype on tbroomtype.roomtypeID=Rentdetail.rotypeid  inner join tbroom on tbroom.roomID= Rentdetail.roomIDwhere studentID like '%" + txtsearch.Text + "'";
                    cmd = new SqlCommand(sql, con);
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "stud");
                    if (ds.Tables["stud"] != null) {
                        ds.Tables.Clear();
                        da.Fill(ds, "stud");
                        dgvpayment.DataSource = ds.Tables["stud"];
                    } 
                }

                else if (rbnewadd.Checked == true) {
                    sql = "select studentID,name,surname,gender,schoolname,facname,deptname from tbstudent inner join tbschool on tbschool.schoolID=tbstudent.schoolID inner join tbfaculty on tbfaculty.facID=tbstudent.facID inner join tbdepartment on tbdepartment.deptID=tbstudent.deptID where studentID like N'%" + txtsearch.Text + "%' or name like '%" + txtsearch.Text + "%'";
                    cmd = new SqlCommand(sql, con);
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "student");
                    if (ds.Tables["student"] != null)
                    {
                        ds.Tables.Clear();
                        da.Fill(ds, "student");
                        dgvpayment.DataSource = ds.Tables["student"];

                    }

                }                           

            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void dgvpayment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtstid.Text = dgvpayment.CurrentRow.Cells[0].Value.ToString();
            txtstname.Text = dgvpayment.CurrentRow.Cells[1].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbcontinues .Checked ==true)
                {

               sql = "update tbrendetail set studentID= @stid,(select roomtypeID from tbroomtype where typename=@troom),(select buildingID from tbbuilding buildingnumber=@bui),(select floorID from tbfloor where floornumber=@flo),(select roomID from tbroom where room_number=@room),startdate=@now,enddate=@enddate,cost=@cost where remtID=@rentID";
                    cmd = new SqlCommand(sql, con);
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@stid", txtstid.Text);
                    cmd.Parameters.AddWithValue("@troom", cbtroom.SelectedItem);
                    cmd.Parameters.AddWithValue("@bui", cbbuilding.SelectedItem);
                    cmd.Parameters.AddWithValue("@flo",cbfloor.SelectedItem );
                    cmd.Parameters.AddWithValue("@room", cbroom.SelectedItem);
                    cmd.Parameters.AddWithValue("@now", startdate.Value);
                    cmd.Parameters.AddWithValue("@enddate", enddate.Value);
                    cmd.Parameters.AddWithValue("@cost", txtcost.Text);
                    cmd.Parameters.AddWithValue("@rentID", txtid.Text);
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("ສຳເລັດ");
                    }
                    

                }else if (rbnewadd.Checked ==true)
                {
                 sql = "insert into tbrendetail values (@id,@stid,@troom,@bui,@flo,@room,@now,@enddate,@cost";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id",txtid .Text );
                cmd.Parameters.AddWithValue("@stid", txtstid.Text);
                cmd.Parameters.AddWithValue("@troom", cbtroom.SelectedItem);
                cmd.Parameters.AddWithValue("@bui", cbbuilding.SelectedItem);
                cmd.Parameters.AddWithValue("@flo", cbfloor.SelectedItem);
                cmd.Parameters.AddWithValue("@room", cbroom.SelectedItem);
                cmd.Parameters.AddWithValue("@now", startdate.Value);
                cmd.Parameters.AddWithValue("@enddate", enddate.Value);
                cmd.Parameters.AddWithValue("@cost", txtcost.Text);
                cmd.ExecuteNonQuery();

                }else
                {
                    return;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void cbtroom_SelectedIndexChanged(object sender, EventArgs e)
        {
            builcombo();
            string ssl = "select roomprice from tbroomtype where typename= N'" + cbtroom.SelectedItem + "'";
            SqlCommand cmdd = new SqlCommand(ssl, con);
            dr = cmdd.ExecuteReader();
            txtcost.Clear();
            while (dr.Read())
            {
                txtcost.Text = dr.GetDecimal(0).ToString();
                
            }
            dr.Close();
        }


        private void cbtroom_TextUpdate(object sender, EventArgs e)
        {
            
        }

        private void txtcost_TextChanged(object sender, EventArgs e)
        {
        }

        private void cbfloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            roomcombo();
        }

        private void cbbuilding_SelectedIndexChanged(object sender, EventArgs e)
        {
            flocombo();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (startdate .Value <= DateTime.Now)
            {
                MessageBox.Show("ວັນທີຈະຕ້ອງເລີມແຕ່ມື້ນີ້ຫຼືພາຍໃນອາທິດນີ້ເທົ່ານັ້ນ", "ແຈ້ງເຕືອນ");
                startdate.Value = DateTime.Today;

            }else
            {
                enddate.Value = startdate.Value.AddDays(365);

            }
        }

        private void rbnewadd_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbnewadd .Checked ==true)
                {
                sql = "select studentID,name,surname,gender,schoolname,facname,deptname from tbstudent inner join tbschool on tbschool.schoolID=tbstudent.schoolID inner join tbfaculty on tbfaculty.facID=tbstudent.facID inner join tbdepartment on tbdepartment.deptID=tbstudent.deptID  ";
            cmd = new SqlCommand(sql, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "student");
            if (ds.Tables["student"] != null)
            {
                ds.Tables.Clear();
                da.Fill(ds, "student");
                dgvpayment.DataSource = ds.Tables["student"];

            }
                }
                else
                {
                    dgvpayment.DataSource = "";
                }
            }
            catch (Exception ex )
            {

                throw;
            } 
        }

        private void payment_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtsearch.Text == "")
                {
                    return;
                }
                if (rbcontinues.Checked == true)
                {
                    sql = "SELECT rentID,studentID,typename,buildingnumber,floornumber,room_number,startdate,enddate,cost FROM Rentdetail inner join tbbuilding on tbbuilding.buildingID =Rentdetail.buildingID inner join tbfloor on tbfloor.floorID= Rentdetail.floorID inner join tbroomtype on tbroomtype.roomtypeID=Rentdetail.rotypeid  inner join tbroom on tbroom.roomID= Rentdetail.roomIDwhere studentID like '%" + txtsearch.Text + "'";
                    cmd = new SqlCommand(sql, con);
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "stud");
                    if (ds.Tables["stud"] != null)
                    {
                        ds.Tables.Clear();
                        da.Fill(ds, "stud");
                        dgvpayment.DataSource = ds.Tables["stud"];
                    }
                }

                else if (rbnewadd.Checked == true)
                {
                    sql = "select studentID,name,surname,gender,schoolname,facname,deptname from tbstudent inner join tbschool on tbschool.schoolID=tbstudent.schoolID inner join tbfaculty on tbfaculty.facID=tbstudent.facID inner join tbdepartment on tbdepartment.deptID=tbstudent.deptID where studentID like N'%" + txtsearch.Text + "%' or name like '%" + txtsearch.Text + "%'";
                    cmd = new SqlCommand(sql, con);
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "student");
                    if (ds.Tables["student"] != null)
                    {
                        ds.Tables.Clear();
                        da.Fill(ds, "student");
                        dgvpayment.DataSource = ds.Tables["student"];

                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void cbroom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
