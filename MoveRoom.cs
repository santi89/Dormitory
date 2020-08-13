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


namespace C_Sharp_2_Project
{
    public partial class MoveRoom : Form
    {
        public MoveRoom()
        {
            InitializeComponent();

            combotroom();
            combotroomnew();
          
        }
        SqlConnection conn = Connect.getconnect();
        SqlCommand cmdd;
        SqlCommand cmd;
        SqlCommand cmd1;
        SqlDataAdapter da;
        SqlDataReader re;
        DataSet ds = new DataSet();
        string sql = "";

        public void roomcombo()
        {
            try
            {
                sql = "select room_number from tbroom inner join tbfloor on tbroom.floorID=tbfloor.floorID where floornumber=N'" + cbfloor.SelectedItem + "'";
                cmdd = new SqlCommand(sql,conn);
                re = cmdd.ExecuteReader();
                cbroom.Items.Clear();
                while (re.Read())
                {
                    cbroom.Items.Add(re.GetString(0));
                }
                re.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void flocombo()
        {
            try
            {
                sql = "select floornumber from tbfloor inner join tbbuilding on tbbuilding.buildingID=tbfloor.buildingID where buildingnumber='" + cbbuild.SelectedItem + "'";
                cmd1 = new SqlCommand(sql, conn);
                re = cmd1.ExecuteReader();              
                cbfloor.Items.Clear();

                while (re.Read())
                {
                    cbfloor.Items.Add(re.GetString(0));

                }
                re.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        private void combotroom()
        {
            sql = "select typename from tbroomtype";
            cmd = new SqlCommand(sql, conn);
            re = cmd.ExecuteReader();
            cbtyperoom.Items.Clear();
            while (re.Read())
            {
                cbtyperoom.Items .Add(re.GetString (0));
            }
            re.Close();
           
        }
        private void builcombo()
        {
            sql = "select buildingnumber from tbbuilding inner join tbroomtype on tbroomtype.roomtypeID=tbbuilding.roomtypeID where typename= N'" + cbtyperoom.SelectedItem + "'";
            cmdd = new SqlCommand(sql, conn);
            re = cmdd.ExecuteReader();         
            cbbuild.Items.Clear();
            while (re.Read())
            {
                cbbuild.Items.Add(re.GetString(0));
            }
            re.Close();
        }
        public void roomcombonew()
        {
            try
            {
                sql = "select room_number from tbroom inner join tbfloor on tbroom.floorID=tbfloor.floorID where floornumber=N'" + cbfloornew.SelectedItem + "'";
                cmdd = new SqlCommand(sql,conn);
                re = cmdd.ExecuteReader();
                cbroomnew.Items.Clear();

                while (re.Read())
                {
                    cbroomnew.Items.Add(re.GetString(0));

                }
                re.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void flocombonew()
        {
            try
            {
                sql = "select floornumber from tbfloor inner join tbbuilding on tbbuilding.buildingID=tbfloor.buildingID where buildingnumber='" + cbbuildnew.SelectedItem + "'";
                cmd = new SqlCommand(sql, conn);
                re = cmd.ExecuteReader();
               
                cbfloornew .Items.Clear();

                while (re.Read())
                {
                    cbfloornew.Items.Add(re.GetString(0));

                }
                re.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
        private void combotroomnew()
        {
            try
            {
                sql = "select * from tbroomtype";
                cmdd = new SqlCommand(sql,conn);
                re = cmdd.ExecuteReader();
                cbtroomnew.Items.Clear();
                while (re.Read())
                {
                    cbtroomnew .Items.Add(re.GetString(1));
                }
                re.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void builcombonew()
        {
            sql = "select buildingnumber from tbbuilding inner join tbroomtype on tbroomtype.roomtypeID=tbbuilding.roomtypeID where typename= N'" + cbtroomnew.SelectedItem + "'";
            cmdd = new SqlCommand(sql,conn);
            re = cmdd.ExecuteReader();
            cbbuildnew  .Items.Clear();
            cbfloornew.Items.Clear();
            while (re.Read())
            {
                cbbuildnew.Items.Add(re.GetString(0));
            }
            re.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "SELECT dbo.tbstudent.studentID, dbo.tbstudent.name, dbo.tbstudent.surname, dbo.Rentdetail.startdate, dbo.Rentdetail.enddate FROM dbo.Rentdetail INNER JOIN dbo.tbstudent ON dbo.Rentdetail.studentID = dbo.tbstudent.studentID INNER JOIN dbo.tbroom ON dbo.Rentdetail.roomID = dbo.tbroom.roomID INNER JOIN dbo.tbfloor ON dbo.tbroom.floorID = dbo.tbfloor.floorID INNER JOIN dbo.tbbuilding ON dbo.tbfloor.buildingID = dbo.tbbuilding.buildingID INNER JOIN dbo.tbroomtype ON dbo.tbbuilding.roomtypeID = dbo.tbroomtype.roomtypeID where Rentdetail.roomID=(select roomID from tbroom where room_number='"+cbroom .SelectedItem +"')";
                da = new SqlDataAdapter(sql, conn);
                da.Fill(ds, "oldroom");
                if (ds.Tables["oldroom"] != null)
                {
                    ds.Tables.Clear();
                }
                da.Fill(ds, "oldroom");
                dgvold.DataSource = ds.Tables["oldroom"];
                dgvold.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill ;
                dgvold.Columns[0].HeaderText = "ລະຫັດນັກສຶກສາ";
                dgvold.Columns[1].HeaderText = "ຊື່";
                dgvold.Columns[2].HeaderText = "ນາມສະກຸນ";
                dgvold.Columns[3].HeaderText = "ວັນທີເຂົ້າພັກ";
                dgvold.Columns[4].HeaderText = "ວັນໝົດກຳນົດ";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void MoveRoom_Load(object sender, EventArgs e)
        {
          


        }

        private void dgvold_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lbid.Text = dgvold.CurrentRow.Cells[0].Value.ToString();
            lbname.Text = dgvold.CurrentRow.Cells[1].Value.ToString();
            lbsurname.Text = dgvold.CurrentRow.Cells[2].Value.ToString();
            lbstartdate.Text = dgvold.CurrentRow.Cells[3].Value.ToString();
            lbenddate.Text = dgvold.CurrentRow.Cells[4].Value.ToString();
        }

        private void cbtroom_SelectedIndexChanged(object sender, EventArgs e)
        {           
            builcombo();
        }

        private void cbbuild_SelectedIndexChanged(object sender, EventArgs e)
        {
            flocombo();
        }

        private void cbroom_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbtroomnew_SelectedIndexChanged(object sender, EventArgs e)
        {
            builcombonew();
        }

        private void cbbuildnew_SelectedIndexChanged(object sender, EventArgs e)
        {
            flocombonew();
        }

        private void cbfloornew_SelectedIndexChanged(object sender, EventArgs e)
        {
            roomcombonew();
        }

        private void cbroomnew_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbfloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            roomcombo();
        }

        public void shownew()
        {
            sql = "SELECT dbo.tbstudent.studentID, dbo.tbstudent.name, dbo.tbstudent.surname, dbo.Rentdetail.startdate, dbo.Rentdetail.enddate FROM dbo.Rentdetail INNER JOIN dbo.tbstudent ON dbo.Rentdetail.studentID = dbo.tbstudent.studentID INNER JOIN dbo.tbroom ON dbo.Rentdetail.roomID = dbo.tbroom.roomID INNER JOIN dbo.tbfloor ON dbo.tbroom.floorID = dbo.tbfloor.floorID INNER JOIN dbo.tbbuilding ON dbo.tbfloor.buildingID = dbo.tbbuilding.buildingID INNER JOIN dbo.tbroomtype ON dbo.tbbuilding.roomtypeID = dbo.tbroomtype.roomtypeID where Rentdetail.roomID=(select roomID from tbroom where room_number='" + cbroomnew.SelectedItem + "')";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(ds, "newroom");
            if (ds.Tables["newroom"] != null)
            {
                ds.Tables.Clear();
            }
            da.Fill(ds, "newroom");
            dgvnew.DataSource = ds.Tables["newroom"];
            dgvnew.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvnew.Columns[0].HeaderText = "ລະຫັດນັກສຶກສາ";
            dgvnew.Columns[1].HeaderText = "ຊື່";
            dgvnew.Columns[2].HeaderText = "ນາມສະກຸນ";
            dgvnew.Columns[3].HeaderText = "ວັນທີເຂົ້າພັກ";
            dgvnew.Columns[4].HeaderText = "ວັນໝົດກຳນົດ";
        }
        private void btsearch_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "SELECT dbo.tbstudent.studentID, dbo.tbstudent.name, dbo.tbstudent.surname, dbo.Rentdetail.startdate, dbo.Rentdetail.enddate FROM dbo.Rentdetail INNER JOIN dbo.tbstudent ON dbo.Rentdetail.studentID = dbo.tbstudent.studentID INNER JOIN dbo.tbroom ON dbo.Rentdetail.roomID = dbo.tbroom.roomID INNER JOIN dbo.tbfloor ON dbo.tbroom.floorID = dbo.tbfloor.floorID INNER JOIN dbo.tbbuilding ON dbo.tbfloor.buildingID = dbo.tbbuilding.buildingID INNER JOIN dbo.tbroomtype ON dbo.tbbuilding.roomtypeID = dbo.tbroomtype.roomtypeID where Rentdetail.roomID=(select roomID from tbroom where room_number='" + cbroomnew.SelectedItem + "')";
                da = new SqlDataAdapter(sql, conn);
                da.Fill(ds, "newroom");
                if (ds.Tables["newroom"] != null)
                {
                    ds.Tables.Clear();
                }
                da.Fill(ds, "newroom");
                dgvnew.DataSource = ds.Tables["newroom"];
                dgvnew.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvnew.Columns[0].HeaderText = "ລະຫັດນັກສຶກສາ";
                dgvnew.Columns[1].HeaderText = "ຊື່";
                dgvnew.Columns[2].HeaderText = "ນາມສະກຸນ";
                dgvnew.Columns[3].HeaderText = "ວັນທີເຂົ້າພັກ";
                dgvnew.Columns[4].HeaderText = "ວັນໝົດກຳນົດ";
             }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
        private void btmove_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "update Rentdetail set rotypeid=(select rotypeid from tbroomtype where typename=@rtid),roomID=(select roomID from tbroom where room_number=@roomid) where studentID=@stid";
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@rtid", cbtroomnew.SelectedItem);
                cmd.Parameters.AddWithValue("@roomid", cbroomnew.SelectedItem);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    string sql1 = "update tbroom set Student_amount=Student_amount+1 where roomID=(select roomID from tbroom where room_number=@roomid";
                    cmd = new SqlCommand(sql1, conn);
                    cmd.Parameters.AddWithValue("@roomid", cbroomnew.SelectedItem);
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        string sql2 = "update tbroom set Student_amount=Student_amount-1 where roomID=(select roomID from tbroom where room_number=@roomid";
                        cmd = new SqlCommand(sql2, conn);
                        cmd.Parameters.AddWithValue("@roomid", cbroom.SelectedItem);
                        cmd.ExecuteNonQuery();
                        shownew();
                    }
                    else
                    {
                        MessageBox.Show("ຍ້າຍບໍ່ສຳເລັດ");
                    }
                }
                else
                {
                    MessageBox.Show("ການດຳເນີນການຜິດຜາດ ກາລຸນາກວດຄືນ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }        
            }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close ();
        }
    }
   
}
    

