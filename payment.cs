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
using CrystalDecisions.CrystalReports.Engine;

namespace C_Sharp_2_Project
{
    public partial class payment : Form
    {
        cardID cd = new cardID();
        SqlConnection con = Connect.getconnect();
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataSet ds = new DataSet();
        string sql1 = "";
        SqlCommand cmd1;
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
            sql = "select room_number from tbroom inner join tbfloor on tbroom.floorID=tbfloor.floorID where floornumber=N'" + cbfloor.SelectedItem + "' and Student_amount<4 ";
            cmd = new SqlCommand(sql, con);
            dr = cmd.ExecuteReader();
                cbroom.Items.Clear();

                while (dr.Read())
            {
                cbroom.Items.Add(dr.GetString(0));

            }dr.Close();
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
            sql = "select floornumber from tbfloor inner join tbbuilding on tbbuilding.buildingID=tbfloor.buildingID where buildingnumber='"+cbbuilding .SelectedItem +"'";
            cmd = new SqlCommand(sql, con);
            dr = cmd.ExecuteReader();
                cbroom.Items.Clear();
                cbfloor.Items.Clear();

                while (dr.Read())
            {
                cbfloor.Items.Add(dr.GetString(0));

            }dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

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
                MessageBox.Show(ex.Message);
            }
        }
        private void builcombo()
        {
            sql = "select buildingnumber from tbbuilding inner join tbroomtype on tbroomtype.roomtypeID=tbbuilding.roomtypeID where typename= N'"+cbtroom.SelectedItem +"'";
            cmd=new SqlCommand (sql, con);
            dr = cmd.ExecuteReader();
            cbbuilding.Items.Clear();
            cbfloor.Items.Clear();
            while (dr.Read())
            {
                cbbuilding.Items.Add(dr.GetString(0));
            }dr.Close();

                    }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void dgvpayment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtstid.Text = dgvpayment.CurrentRow.Cells[0].Value.ToString();
            txtstname.Text = dgvpayment.CurrentRow.Cells[1].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
         
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
           
        }

        private void payment_Load(object sender, EventArgs e)
        {
            rbnewadd.Checked = true;
           

          
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void cbroom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Addstudent ads = new Addstudent();
            ads.Show();
            this.Hide();
        }

        private void rbcontinues_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label12_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbnewadd_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbnewadd .Checked ==true)
            {
                txtsearch.Enabled = false;
                datesearch.Enabled = true;

            }else if (rbcontinues.Checked ==true)
            {
                txtsearch.Enabled = true;
                datesearch.Enabled = false;

            }


        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           try
            {
               
                if (txtsearch.Text == "")
                {
                    return;
                }
                if (rbcontinues.Checked == true)
                {
                    sql = "SELECT rentID,studentID,typename,buildingnumber,floornumber,room_number,startdate,enddate,cost FROM Rentdetail inner join tbroom on tbroom.roomID= Rentdetail.roomID inner join tbfloor on tbfloor.floorID= tbroom.floorID inner join tbbuilding on tbbuilding.buildingID =tbfloor.buildingID inner join tbroomtype on tbroomtype.roomtypeID=Rentdetail.rotypeid where studentID like '%" + txtsearch.Text + "'";
                    cmd = new SqlCommand(sql, con);
                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "stud");
                    if (ds.Tables["stud"] != null)
                    {
                        ds.Tables.Clear();                                  
                    }  da.Fill(ds, "stud");
                        dgvpayment.DataSource = ds.Tables["stud"];   
                    dgvpayment.Columns[0].HeaderText = "ລະຫັດ";
                    dgvpayment.Columns[1].HeaderText = "ລະຫັດນັກສຶກສາ";
                    dgvpayment.Columns[2].HeaderText = "ປະເພດຫ້ອງ";
                    dgvpayment.Columns[3].HeaderText = "ຕຶກ";
                    dgvpayment.Columns[4].HeaderText = "ຊັ້ນ";
                    dgvpayment.Columns[5].HeaderText = "ຫ້ອງ";
                    dgvpayment.Columns[6].HeaderText = "ວັນເຂົ້າ";
                    dgvpayment.Columns[7].HeaderText = "ວັນໝົດກຳນົດ";
                    dgvpayment.Columns[8].HeaderText = "ລາຄາ";
                    dgvpayment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }

                else if(rbnewadd.Checked == true)
                {

                    sql = "select studentID,name,surname,gender,schoolname,facname,deptname from tbstudent inner join tbschool on tbschool.schoolID=tbstudent.schoolID inner join tbfaculty on tbfaculty.facID=tbstudent.facID inner join tbdepartment on tbdepartment.deptID=tbstudent.deptID where datesignin=@dd and studentID !=(select studentID from Rentdetail)";
                    cmd = new SqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@dd", datesearch.Value.ToString("yyyy'/'MM'/'dd"));

                    da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "student");
                    if (ds.Tables["student"] != null)
                    {
                        ds.Tables.Clear();
                    }
                    da.Fill(ds, "student");
                    dgvpayment.DataSource = ds.Tables["student"];

                    dgvpayment.Columns[0].HeaderText = "ລະຫັດນັກສຶກສາ";
                    dgvpayment.Columns[1].HeaderText = "ຊື່";
                    dgvpayment.Columns[2].HeaderText = "ນາມສະກຸນ";
                    dgvpayment.Columns[3].HeaderText = "ເພດ";
                    dgvpayment.Columns[4].HeaderText = "ສະຖາບັນ";
                    dgvpayment.Columns[5].HeaderText = "ຄະນະ";
                    dgvpayment.Columns[6].HeaderText = "ພາກວິຊາ";
                    dgvpayment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void rbcontinues_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rbcontinues .Checked ==true)
            {
                datesearch.Enabled = false;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (rbcontinues.Checked == true)
                {

                    sql = "update Rentdetail set studentID= @stid,roomtypeID=(select roomtypeID from tbroomtype where typename=@troom),roomID=(select roomID from tbroom where room_number=@room),startdate=@now,enddate=@enddate where rentID=@rentID"; //,buildingID=(select buildingID from tbbuilding buildingnumber=@bui),floorID=(select floorID from tbfloor where floornumber=@flo),,cost=@cs
                    cmd = new SqlCommand(sql, con);
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@stid", txtstid.Text);
                    cmd.Parameters.AddWithValue("@troom", cbtroom.SelectedItem);
                    /*cmd.Parameters.AddWithValue("@bui", cbbuilding.SelectedItem);
                    cmd.Parameters.AddWithValue("@flo", cbfloor.SelectedItem);*/
                    cmd.Parameters.AddWithValue("@room", cbroom.SelectedItem);
                    cmd.Parameters.AddWithValue("@now", startdate.Value);
                    cmd.Parameters.AddWithValue("@enddate", enddate.Value);
                   // cmd.Parameters.AddWithValue("@cs", Convert.ToInt32(txtcost.Text ));
                    cmd.Parameters.AddWithValue("@rentID", txtid.Text);
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("ສຳເລັດ");
                        cd.ids = txtstid.Text;
                        sql1 = "update tbroom set Student_amount=Student_amount +1 where room_number='" + cbroom.SelectedItem + "'";
                    cmd1 = new SqlCommand(sql1, con);
                    cmd1.ExecuteNonQuery();                  
                    cd.Show();
                    }
                    else
                    {          
                            MessageBox.Show("ບັນທຶກຜິດຜາດກະລຸນາກວດສອບຂໍ້ມູນຄືນ");                    
                    }
                    
                }
                else if (rbnewadd.Checked == true)
                {
                    sql = "insert into Rentdetail values (@stid,(select roomtypeID from tbroomtype where typename=@troom),(select roomID from tbroom where room_number=@room),@now,@enddate)";
                    cmd = new SqlCommand(sql, con);
                    cmd.Parameters.Clear();                  
                    cmd.Parameters.AddWithValue("@stid", txtstid.Text);
                    cmd.Parameters.AddWithValue("@troom", cbtroom.SelectedItem);
                   /* cmd.Parameters.AddWithValue("@bui", cbbuilding.SelectedItem);
                    cmd.Parameters.AddWithValue("@flo", cbfloor.SelectedItem);*/
                    cmd.Parameters.AddWithValue("@room", cbroom.SelectedItem);
                    cmd.Parameters.AddWithValue("@now", startdate.Value);
                    cmd.Parameters.AddWithValue("@enddate", enddate.Value);
                   // cmd.Parameters.AddWithValue("@cost", txtcost.Text);
                    if (cmd.ExecuteNonQuery() == 1) { 

                    sql1 = "update tbroom set Student_amount=Student_amount +1 where room_number='" + cbroom.SelectedItem + "'";
                    cmd1 = new SqlCommand(sql1, con);
                    cmd1.ExecuteNonQuery();                   
                    cd.ids = txtstid.Text;                                  
                    cd.Show();
                    }
                    else
                    {                      
                            MessageBox.Show("ບັນທຶກຜິດຜາດ");                    

                    }
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            txtcost.Clear();
            txtid.Clear();
            txtstid.Clear();
            txtstname.Clear();
            cbbuilding.Items.Clear();
            cbfloor.Items.Clear();
            cbroom.Items.Clear();
            cbtroom.Items.Clear();
            
        }

        private void dgvpayment_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (rbcontinues .Checked ==true)
            {
                txtstid.Text = dgvpayment.CurrentRow.Cells[1].Value.ToString();
                sql = "select name from tbstudent where studentID ='" + txtstid.Text + "'";
                cmd = new SqlCommand(sql, con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                   txtstname.Text = dr.GetString (0);
                }dr.Close();
                cbtroom.SelectedItem = dgvpayment.CurrentRow.Cells[2].Value.ToString();
                cbbuilding.SelectedItem = dgvpayment.CurrentRow.Cells[3].Value.ToString();
                cbfloor.SelectedItem = dgvpayment.CurrentRow.Cells[4].Value.ToString();
                cbroom.SelectedItem = dgvpayment.CurrentRow.Cells[5].Value.ToString();
                startdate.Value = DateTime.Now;
                cbtroom.Enabled = false;
                cbroom.Enabled = false;
                cbbuilding.Enabled = false;
                cbfloor.Enabled = false;
            }
            else
            {
            txtstid.Text = dgvpayment.CurrentRow.Cells[0].Value.ToString();
            txtstname.Text = dgvpayment.CurrentRow.Cells[1].Value.ToString();
            }
           
        }

        private void cbtroom_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
            builcombo();
            string ssl = "select roomprice from tbroomtype where typename= N'" + cbtroom.SelectedItem + "'";
            SqlCommand cmdd = new SqlCommand(ssl, con);
            dr = cmdd.ExecuteReader();
            txtcost.Clear();
            while (dr.Read())
            {
                txtcost.Text = dr.GetInt32 (0).ToString();
            }
            dr.Close();
            cbbuilding.Refresh();
        }

        private void cbbuilding_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            flocombo();
            cbfloor.Refresh();
        }

        private void cbfloor_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            roomcombo();
            Refresh();
        }

        private void cbroom_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void startdate_ValueChanged(object sender, EventArgs e)
        {
            if (startdate.Value < DateTime.Now)
            {
                MessageBox.Show("ວັນທີຈະຕ້ອງເລີມແຕ່ມື້ນີ້ຫຼືພາຍໃນອາທິດນີ້ເທົ່ານັ້ນ", "ແຈ້ງເຕືອນ");
                startdate.Value = DateTime.Today;

            }
            else
            {
                enddate.Value = startdate.Value.AddDays(300);

            }
        }

        private void txtcost_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void datesearch_ValueChanged(object sender, EventArgs e)
        {
           /* datesearch.Format = DateTimePickerFormat.Custom;
            datesearch.CustomFormat = "yyyy-MM-dd";
            datesearch.Value = DateTime.Now;*/
            sql = "select studentID,name,surname,gender,schoolname,facname,deptname from tbstudent inner join tbschool on tbschool.schoolID=tbstudent.schoolID inner join tbfaculty on tbfaculty.facID=tbstudent.facID inner join tbdepartment on tbdepartment.deptID=tbstudent.deptID where datesignin=@dd and studentID !=(select studentID from Rentdetail)";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@dd", datesearch.Value.ToString("yyyy'/'MM'/'dd"));      
            
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "student");
            if (ds.Tables["student"] != null)
            {
                ds.Tables.Clear();
            }
            da.Fill(ds, "student");
            dgvpayment.DataSource = ds.Tables["student"];

            dgvpayment.Columns[0].HeaderText = "ລະຫັດນັກສຶກສາ";
            dgvpayment.Columns[1].HeaderText = "ຊື່";
            dgvpayment.Columns[2].HeaderText = "ນາມສະກຸນ";
            dgvpayment.Columns[3].HeaderText = "ເພດ";
            dgvpayment.Columns[4].HeaderText = "ສະຖາບັນ";
            dgvpayment.Columns[5].HeaderText = "ຄະນະ";
            dgvpayment.Columns[6].HeaderText = "ພາກວິຊາ";


            dgvpayment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
