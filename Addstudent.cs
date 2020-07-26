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
using System.IO;

namespace C_Sharp_2_Project
{
    public partial class Addstudent : Form
    {
        public Addstudent()
        {
            InitializeComponent();
        }
        SqlConnection con = Connect.getconnect();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        string sql = "";
        SqlDataReader dr;
        AutoCompleteStringCollection auto = new AutoCompleteStringCollection();

        string [] str = {"ລະຫັດນັກສຶກສາ", "ຊື່", "ນາມສະກຸນ", "ເພດ", "ວັນເດືອນປີເກີດ", "ບ້ານ", "ເມືອງ", "ແຂວງ", "ອີເມວ", "ເບີໂທ", "ສະຖາບັນ", "ຄະນະ", "ພາກວິຊາ", "ປີຮຽນ", "ຊື່ຜູ້ຕິດຕໍສຸກເສີນ", "ນາມສະກຸນ", "ອາຍຸ", "ບ້ານ", "ເມືອງ", "ແຂວງ", "ເຮັດວຽກ", "ເບີໂທ", "ສາຍສຳພັນ", "ຮູບຕົນເອງ" };

        public void showstudent()
        {
            try
            {
                sql = @"SELECT studentID,name,surname,gender,birthofdate,village,district,province,email,phone,schoolname,facname,deptname,session,emgcname,emgcsurname,emgcage,emgcvillage,emgcdistrict,emgcprovince,emgcjob,emgctel,relationship,picture FROM tbstudent inner join tbschool on tbstudent.schoolID=tbschool.schoolID inner join tbfaculty  on tbfaculty.facID=tbstudent.facID inner join tbdepartment on tbstudent.deptID=tbdepartment.deptID";
                cmd = new SqlCommand(sql, con);
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "ime");
                if (ds.Tables["im"] != null)
                {
                   ds.Tables.Clear();
                }
                da.Fill(ds, "im");

                dgvregister.DataSource = ds.Tables["im"];
                for (int i = 0; i < str.Length; i++)
                {
                    dgvregister.Columns[i].HeaderText = str[i];
                    // dgvroom.Columns[i].Width = siz[i];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        int  schoID;
        string scho;
        
        public void showconoboxschool()
        {
            
            sql = @"select * from tbschool";
            cmd = new SqlCommand(sql, con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            cbschool.Items.Clear();
            while (reader.Read())
            {   schoID = reader.GetInt32(0);
                scho = reader.GetString(1);
               
                cbschool.Items.Add(scho);
            }
            reader.Close();

            // sql = "select * from tbstudent ";
            //da = new SqlDataAdapter(sql, con);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //DataRow ro = dt.NewRow();
            //ro[0] = 0;           
            //ro[1] = "please select";
            //dt.Rows.InsertAt (ro, 0);
            //cbschool.DataSource = dt;
            // cbschool.DisplayMember = "schoolname";
            //cbschool.ValueMember = "schoolID";





        }
        int facID;
        public void faccombo()
        {
            sql = "select facID,facname from tbfaculty  inner join tbschool on tbschool.schoolID=tbfaculty.schoolID where schoolname='" + cbschool.SelectedItem + "'";
            cmd = new SqlCommand(sql, con);
           // cmd.Parameters.AddWithValue("@schoolname", cbschool.SelectedItem);
            
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            cbfac.Items.Clear();
            while (reader.Read())
            {
               string facn = reader.GetString(1);
                 facID = reader.GetInt32(0);
                cbfac.Items.Add(facn);
            }
            reader.Close();
        }
        public void depcombo()
        {
            sql="select * from tbdepartment inner join tbfaculty on tbfaculty.facID=tbdepartment.facID where facname='"+ cbfac .SelectedItem +"'";
            cmd = new SqlCommand(sql, con);
            SqlDataReader reada;
            reada = cmd.ExecuteReader();
            cbdep.Items.Clear();
            while (reada .Read())
            {
                string dep = reada.GetString(1);
                cbdep.Items.Add(dep);
            }reada.Close();

        }

        private void txtregister_Click(object sender, EventArgs e)
        {
            try
            {
                date2 = Form1.date1;
                
                if (txtstid .Text ==null && txtstname .Text ==null && txtstsurname.Text ==null && txtvillage .Text==null && txtdistrict .Text ==null && cbprovince .SelectedItem ==null && txtemail .Text ==null && txttel .Text ==null && txtyearstudy .Text ==null && txtemername .Text ==null && txtemersurname .Text ==null && txtemerage.Text ==null && txtemervillage.Text ==null && txtemerdistrict.Text ==null && txtemerjob .Text ==null && txtemertel.Text ==null &&txtemerrelationship .Text ==null)
                {
                    return;
                }else { 


                sql = "INSERT INTO tbstudent VALUEs (@studentID,@name,@surname,@gender,@birthofdate,@village,@district,@province,@email,@phone,(select schoolID from tbschool where schoolname=@schoolID),(select facID from tbfaculty where facname=@facID),(select deptID from tbdepartment where deptname=@deptID),@session,@emgcname,@emgcsurname,@emgcage,@emgcvillage,@emgcdistrict,@emgcprovince,@emgcjob,@emgctel,@relationship,@picture)";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("studentID",txtstid .Text);
                cmd.Parameters.AddWithValue("name",txtstname .Text );
                cmd.Parameters.AddWithValue("surname",txtstsurname .Text );
                string gd = "";
                if (rbfemale .Checked)
                {
                    gd = rbfemale.Text;
                }else if (rbmale .Checked ){
                    gd = rbmale.Text;
                }else
                {
                    gd = rbmale.Text;
                }
                cmd.Parameters.AddWithValue("@gender",gd);
                cmd.Parameters.AddWithValue("@birthofdate",txtbdatetime.Value );
               
                    cmd.Parameters.AddWithValue("@village",txtvillage .Text );
                cmd.Parameters.AddWithValue("@district",txtdistrict .Text );
                cmd.Parameters.AddWithValue("@province",cbprovince.SelectedItem);
                cmd.Parameters.AddWithValue("@email",txtemail .Text );
                cmd.Parameters.AddWithValue("@phone",txttel.Text ); 
                cmd.Parameters.AddWithValue("@schoolID", cbschool .SelectedItem );
                cmd.Parameters.AddWithValue("@facID",cbfac .SelectedItem);
                cmd.Parameters.AddWithValue("@deptID",cbdep .SelectedItem);
                cmd.Parameters.AddWithValue("@session",txtyearstudy.Text );
                cmd.Parameters.AddWithValue("@emgcname",txtemername .Text);
                cmd.Parameters.AddWithValue("@emgcsurname",txtemersurname .Text );
                cmd.Parameters.AddWithValue("@emgcage",txtemerage .Text );
                cmd.Parameters.AddWithValue("@emgcvillage",txtemervillage .Text );
                cmd.Parameters.AddWithValue("@emgcdistrict",txtemerdistrict .Text );
                cmd.Parameters.AddWithValue("@emgcprovince",cbemerprovince.SelectedItem );
                cmd.Parameters.AddWithValue("emgcjob",txtemerjob .Text );
                cmd.Parameters.AddWithValue("emgctel",txtemertel .Text );
                cmd.Parameters.AddWithValue("@relationship",txtemerrelationship .Text );
                MemoryStream mem = new MemoryStream();
                pictureBox1.Image.Save(mem, System.Drawing.Imaging.ImageFormat.Png);
                byte[] imarr = mem.ToArray();
                cmd.Parameters.AddWithValue("@picture",imarr );



                cmd.ExecuteNonQuery();
                    showstudent();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
           
        }

        private void btsearch_Click(object sender, EventArgs e)
        {
            
             try
             {
                 if (txtsearch.Text == "")
                 {
                     showstudent();
                 }
                 else
                 {
                     sql = "SELECT studentID,name,surname,gender,birthofdate,village,district,province,email,phone,schoolname,facname,deptname,session,emgcname,emgcsurname,emgcage,emgcvillage,emgcdistrict,emgcprovince,emgcjob,emgctel,relationship,picture FROM tbstudent inner join tbschool on tbstudent.schoolID=tbschool.schoolID inner join tbfaculty  on tbfaculty.facID=tbstudent.facID inner join tbdepartment on tbstudent.deptID=tbdepartment.deptID where studentID like '%" + txtsearch.Text + "%' or name like '%" + txtsearch.Text + "%'";
                     cmd = new SqlCommand(sql, con);
                     da = new SqlDataAdapter(cmd);
                     da.Fill(ds, "student");
                     if (ds.Tables["student"] != null)
                     {
                         ds.Tables.Clear();
                         da.Fill(ds, "student");
                         dgvregister.DataSource = ds.Tables["student"];
                     }
                     dr = cmd.ExecuteReader();
                     while (dr.Read())
                     {
                         auto.Add(dr["studentID"].ToString());
                         auto.Add(dr["name"].ToString());

                     }
                     dr.Close();
                     txtsearch.AutoCompleteCustomSource = auto;
                     txtsearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                     txtsearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
                 }

             }
             catch (Exception ex)
             {

                 MessageBox.Show(ex.Message);
             }
        }
        string path = "";
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.ShowDialog();
            if (opf.FileName=="" )
            {
                path = "";
            }else
            {
            path = opf.FileName;
            pictureBox1.Load(path);
            txtfilename.Text = path;
            }
            
        }
        string idex;
        string gdr = "male";
        private void dgvregister_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtstid.Text = dgvregister.CurrentRow.Cells[0].Value.ToString();
            txtstname.Text = dgvregister.CurrentRow.Cells[1].Value.ToString();
            txtstsurname.Text = dgvregister.CurrentRow.Cells[2].Value.ToString();
            if (Convert.ToString(dgvregister.CurrentRow.Cells[3].Value) == "male" || Convert.ToString(dgvregister.CurrentRow.Cells[3].Value) == "ຊາຍ" || Convert.ToString(dgvregister.CurrentRow.Cells[3].Value) == "MALE" || Convert.ToString(dgvregister.CurrentRow.Cells[3].Value) == "Male")
            {
                rbmale.Checked = true;
            }
            else if (Convert.ToString(dgvregister.CurrentRow.Cells[3].Value) == "female" || Convert.ToString(dgvregister.CurrentRow.Cells[3].Value) == "ຍິງ" || Convert.ToString(dgvregister.CurrentRow.Cells[3].Value) == "FEMALE" || Convert.ToString(dgvregister.CurrentRow.Cells[3].Value) == "Female") {
                rbfemale.Checked = true;
            }
            else
            {
                rbmale.Checked = true;
            }
            txtbdatetime.Value =Convert .ToDateTime(dgvregister.CurrentRow.Cells[4].Value);
            txtvillage.Text = dgvregister.CurrentRow.Cells[5].Value.ToString();
            txtdistrict.Text = dgvregister.CurrentRow.Cells[6].Value.ToString();
            cbprovince.SelectedItem = dgvregister.CurrentRow.Cells[7].Value.ToString();
            txtemail.Text = dgvregister.CurrentRow.Cells[8].Value.ToString();
            txttel.Text = dgvregister.CurrentRow.Cells[9].Value.ToString();
            cbschool .SelectedItem =dgvregister.CurrentRow.Cells[10].Value.ToString();
                cbfac .SelectedItem =dgvregister.CurrentRow.Cells[11].Value.ToString();
                cbdep .SelectedItem =dgvregister.CurrentRow.Cells[12].Value.ToString();
            txtyearstudy.Text = dgvregister.CurrentRow.Cells[13].Value.ToString();
            txtemername.Text = dgvregister.CurrentRow.Cells[14].Value.ToString();
            txtemersurname.Text = dgvregister.CurrentRow.Cells[15].Value.ToString();
            txtemerage.Text = dgvregister.CurrentRow.Cells[16].Value.ToString();
            txtemervillage.Text =  dgvregister.CurrentRow.Cells[17].Value.ToString();
            txtemerdistrict.Text = dgvregister.CurrentRow.Cells[18].Value.ToString();
            cbemerprovince .SelectedItem = dgvregister.CurrentRow.Cells[19].Value.ToString();
            txtemerjob .Text = dgvregister.CurrentRow.Cells[20].Value.ToString();
            txtemertel.Text= dgvregister.CurrentRow.Cells[21].Value.ToString();
            txtemerrelationship .Text = dgvregister.CurrentRow.Cells[22].Value.ToString();

            idex = dgvregister.CurrentRow.Cells[23].Value.ToString();
            byte[] pic = (byte[])dgvregister.CurrentRow.Cells[23].Value;
            MemoryStream mem1 = new MemoryStream(pic);
            pictureBox1.Image = new Bitmap(mem1);
            //sql = "select picture from tbstudent where studentID=@stID";         
            //cmd = new SqlCommand(sql, con);
            //cmd.Parameters.AddWithValue("@stID", idex);
            //dr = cmd.ExecuteReader();
            //if (dr.HasRows)
            //{
            //    dr.Read();
            //    byte[] pic = (byte[])dr["image"];
            //    MemoryStream mem = new MemoryStream();
            //    pictureBox1.Image = new Bitmap(mem);
            //}
            //dr.Close();

        }
        string date2;
        private void register_Load(object sender, EventArgs e)
        {
            
            depcombo();
            showconoboxschool();
            showstudent();
            faccombo ();
            
        }

        private void cbschool_SelectedIndexChanged(object sender, EventArgs e)
        {
            faccombo ();
            sql = "select * from tbschool";
            cmd = new SqlCommand(sql, con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            
            while (reader.Read())
            {
                schoID = reader.GetInt32(0);
                
              
            }
            reader.Close();


        }
        private void cbschool_KeyUp(object sender, KeyEventArgs e)
        {        
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "delete from tbstudent where studentID=@stID";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@stID", txtstid.Text);
                cmd.ExecuteNonQuery();
                showstudent();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void cbfac_SelectedIndexChanged(object sender, EventArgs e)
        {
            depcombo();
        }

        private void btedit_Click(object sender, EventArgs e)
        {
            try
            {
                sql = "update tbstudent set name=@name,surname=@surname,gender=@gender,birthofdate=@birthofdate,village=@village,district=@district,province=@province,email=@email,phone=@phone,(select schoolID from tbschool where schoolname=@schoolID),(select facID from tbfaculty where facname=@facID),(select deptID from tbdepartment where deptname=@deptID),session=@session,emgcname=@emgcname,emgcsurname=@emgcsurname,emgcage=@emgcage,emgcvillage=@emgcvillage,emgcdistrict=@emgcdistrict,emgcprovince=@emgcprovince,emgcjob=@emgcjob,emgctel=@emgctel,relationship=@relationship,picture=@picture where studentID=@studentID";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("name", txtstname.Text);
                cmd.Parameters.AddWithValue("surname", txtstsurname.Text);
                string gd = "";
                if (rbfemale.Checked)
                {
                    gd = rbfemale.Text;
                }
                else if (rbmale.Checked)
                {
                    gd = rbmale.Text;
                }
                else
                {
                    gd = rbmale.Text;
                }
                cmd.Parameters.AddWithValue("@gender", gd);
                cmd.Parameters.AddWithValue("@birthofdate", txtbdatetime.Value);
                cmd.Parameters.AddWithValue("@village", txtvillage.Text);
                cmd.Parameters.AddWithValue("@district", txtdistrict.Text);
                cmd.Parameters.AddWithValue("@province", cbprovince.SelectedItem);
                cmd.Parameters.AddWithValue("@email", txtemail.Text);
                cmd.Parameters.AddWithValue("@phone", txttel.Text);
                cmd.Parameters.AddWithValue("@schoolID", cbschool.SelectedItem);
                cmd.Parameters.AddWithValue("@facID", cbfac.SelectedItem);
                cmd.Parameters.AddWithValue("@deptID", cbdep .SelectedItem);
                cmd.Parameters.AddWithValue("@session", txtyearstudy.Text);
                cmd.Parameters.AddWithValue("@emgcname", txtemername.Text);
                cmd.Parameters.AddWithValue("@emgcsurname", txtemersurname.Text);
                cmd.Parameters.AddWithValue("@emgcage", txtemerage.Text);
                cmd.Parameters.AddWithValue("@emgcvillage", txtemervillage.Text);
                cmd.Parameters.AddWithValue("@emgcdistrict", txtemerdistrict.Text);
                cmd.Parameters.AddWithValue("@emgcprovince", cbemerprovince.SelectedItem);
                cmd.Parameters.AddWithValue("emgcjob", txtemerjob.Text);
                cmd.Parameters.AddWithValue("emgctel", txtemertel.Text);
                cmd.Parameters.AddWithValue("@relationship", txtemerrelationship.Text);
                MemoryStream mem = new MemoryStream();
                pictureBox1.Image.Save(mem, System.Drawing.Imaging.ImageFormat.Png);
                byte[] imarr = mem.ToArray();
                cmd.Parameters.AddWithValue("@picture", imarr);
                cmd.Parameters.AddWithValue("studentID", txtstid.Text);

                cmd.ExecuteNonQuery();
                showstudent();
            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            payment pay = new payment();
            pay.Show();
            this.Hide();

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtsearch .Text == "")
                {
                    showstudent();
                }
                else
                {
                sql = "SELECT studentID,name,surname,gender,birthofdate,village,district,province,email,phone,schoolname,facname,deptname,session,emgcname,emgcsurname,emgcage,emgcvillage,emgcdistrict,emgcprovince,emgcjob,emgctel,relationship,picture FROM tbstudent inner join tbschool on tbstudent.schoolID=tbschool.schoolID inner join tbfaculty  on tbfaculty.facID=tbstudent.facID inner join tbdepartment on tbstudent.deptID=tbdepartment.deptID where studentID like '%" + txtsearch .Text + "%' or name like '%" + txtsearch.Text + "%'";
                    cmd = new SqlCommand(sql, con);
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "student");
                    if(ds.Tables ["student"] !=null)
                {
                    ds.Tables.Clear();
                    da.Fill(ds, "student");
                    dgvregister.DataSource = ds.Tables["student"];
                }
                    dr = cmd.ExecuteReader();
                    while ( dr.Read())
                    {
                        auto.Add(dr["studentID"].ToString());
                        auto.Add(dr["name"].ToString());

                    }
                    dr.Close();
                    txtsearch.AutoCompleteCustomSource = auto;
                    txtsearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    txtsearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    for (int i = 0; i < str.Length; i++)
                    {
                        dgvregister.Columns[i].HeaderText = str[i];
                        // dgvroom.Columns[i].Width = siz[i];
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtdateend_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtdatestart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
