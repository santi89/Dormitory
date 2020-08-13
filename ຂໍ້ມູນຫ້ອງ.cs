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
    public partial class ຂໍ້ມູນຫ້ອງ : Form
    {
        SqlConnection con = Connect.getconnect();
        SqlCommand cmd;
        SqlDataAdapter da;
        
        SqlDataReader reader;
        DataSet ds = new DataSet();
        DataSet ds1 = new DataSet();
       
        string sql = "";

        public ຂໍ້ມູນຫ້ອງ()
        {
            InitializeComponent();
        }

        private void ຂໍ້ມູນຫ້ອງ_Load(object sender, EventArgs e)
        {
            showdata();
            comtype();
        }


        private void showdata()
        {
            try
            {
                sql = "select roomID,room_number,typename,floornumber,buildingnumber from tbroom left join tbroomtype on tbroomtype.roomtypeID=tbroom.roomtypeID left join tbfloor on tbfloor.floorID=tbroom.floorID inner join tbbuilding on tbfloor.buildingID= tbbuilding.buildingID";
                da = new SqlDataAdapter(sql, con);
                da.Fill(ds, "room");
                if (ds.Tables["room"] != null)
                {
                    ds.Tables.Clear();
                }
                da.Fill(ds, "room");
                dgvroom.DataSource = ds.Tables["room"];
                dgvroom.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvroom.Columns[0].HeaderText = "ລະຫັດ";
                dgvroom.Columns[1].HeaderText = "ເບີຫ້ອງ";
                dgvroom.Columns[2].HeaderText = "ປະເພດ";
                dgvroom.Columns[3].HeaderText = "ຊັ້ນ";
                dgvroom.Columns[4].HeaderText = "ຕຶກ";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void builcombo()
        {
            sql = "select buildingnumber from tbbuilding inner join tbroomtype on tbroomtype.roomtypeID=tbbuilding.roomtypeID where typename= N'" + cbroomtype.SelectedItem + "'";
            cmd = new SqlCommand(sql, con);
            reader = cmd.ExecuteReader();
            cbbuild.Items.Clear();
            while (reader.Read())
            {
                cbbuild.Items.Add(reader.GetString(0));
            }
            reader.Close();

        }
        public void comtype()
        {
            try
            {
                sql = "select * from tbroomtype";
                cmd = new SqlCommand(sql, con);
                reader = cmd.ExecuteReader();
                cbroomtype.Items.Clear();
                while (reader.Read())
                {

                    string typename = reader.GetString(1);
                    cbroomtype.Items.Add(typename);
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        void clrtext()
        {   
          cbroomtype.SelectedIndex=-1;
            txtroomid.Clear();
            txtroomnum.Clear();
            cbfloor.SelectedIndex = -1;          
            cbbuild.SelectedIndex=-1;
            
            
        }


        public void comfloor()
        {
            sql = "select distinct floornumber from tbfloor ";
            cmd = new SqlCommand(sql, con);
            reader = cmd.ExecuteReader();
            cbfloor.Items.Clear();
            while (reader.Read())
            {
                string strflo = reader.GetString(0);
                cbfloor.Items.Add(strflo);
            }
            reader.Close();
        }


        private void btrsave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtroomid .Text ==null || txtroomnum.Text ==null || cbbuild.Text ==null || cbfloor .Text ==null || cbroomtype .Text ==null)
                {
                    MessageBox.Show("ຂໍ້ມູນບໍ່ຄົບ.");
                    return;
                }
                string s = "select room_number from tbroom where room_number ='" + txtroomnum.Text +"'";
                cmd = new SqlCommand(s, con);
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                int i = dt.Rows.Count;
                if (i >=1)
                {
                    MessageBox.Show("ເບີຫ້ອງນີ້ມີແລ້ວ.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                  
                }

                /* string s = "select room_number from tbroom";
                  SqlCommand cmd1 = new SqlCommand(s, con);
                //cmd.Parameters.AddWithValue("@nn", txtroomnum.Text);
                  SqlDataReader rer = cmd.ExecuteReader();
                     while (rer.Read())
                  {
                      if (rer[0].ToString()==txtroomnum .Text )
                     {
                        MessageBox.Show("ເບີຫ້ອງນີ້ມີແລ້ວ.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                     }
                  }
                  rer.Close();*/

                //#pragma warning disable CS0162 // Unreachable code detected
                /* int o = dgvroom.Rows.Count;
 #pragma warning disable CS0162 // Unreachable code detected
                 for (int i = 0; i < o; i++)
                 {

                     string dd = dgvroom.Rows[i].Cells[1].Value.ToString();
                     if (txtroomnum.Text == dd)
                     {
                         MessageBox.Show("ເບີຫ້ອງນີ້ມີແລ້ວ.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                         return;
                     }*/
                else
                {
                    sql = @"insert into tbroom values(@roomnum,@rtype,(select floorID from tbfloor where floornumber=@flo),@stm)";
                    cmd = new SqlCommand(sql, con);
                    cmd.Parameters.Clear();
                    // cmd.Parameters.AddWithValue("@roomID",txtroomid .Text );
                    cmd.Parameters.AddWithValue("@roomnum", txtroomnum.Text);
                    cmd.Parameters.AddWithValue("@rtype", cbroomtype.SelectedIndex + 1);
                    cmd.Parameters.AddWithValue("@flo", cbfloor.SelectedItem);
                    cmd.Parameters.AddWithValue("@stm", 0);
                    cmd.ExecuteNonQuery();
                    showdata();                   
                    clrtext();

                }
#pragma warning restore CS0162 // Unreachable code detected
                //}
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void btredit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtroomid.Text == null || txtroomnum.Text == null || cbbuild.Text == null || cbfloor.Text == null || cbroomtype.Text == null)
                {
                    MessageBox.Show("ຂໍ້ມູນບໍ່ຄົບ.");
                    return;
                }
                sql = "update tbroom set room_number=@rnum,roomtypeID=@type,floorID=(select floorID from tbfloor where floornumber=@floid) where roomID=@rID";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@rnum", txtroomnum.Text);
                cmd.Parameters.AddWithValue("@type", cbroomtype.SelectedIndex + 1);
                cmd.Parameters.AddWithValue("@floid", cbfloor.SelectedItem);
                //  cmd.Parameters.AddWithValue("@buid",cbbuildID .SelectedIndex+1);               
                // cmd.Parameters.AddWithValue("@stamount",txtstamount .Text );
                cmd.Parameters.AddWithValue("@rID", txtroomid.Text);
                cmd.ExecuteNonQuery();
                showdata();
                comtype();
                builcombo();
                comfloor();
                clrtext();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btrdelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtroomid.Text == null)
                {
                    MessageBox.Show("ຂໍ້ມູນບໍ່ຄົບ.");
                    return;
                }
                sql = "delete from tbroom where roomID=@roomID";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@roomID", txtroomid.Text);
                cmd.ExecuteNonQuery();
                showdata();
                comtype();
                comfloor();
                clrtext();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());

            }
        }

        private void dgvroom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtroomid.Text = dgvroom.CurrentRow.Cells[0].Value.ToString(); 
            cbroomtype.SelectedItem = dgvroom.CurrentRow.Cells[2].Value.ToString();
            cbbuild.SelectedItem = dgvroom.CurrentRow.Cells[4].Value.ToString();
            cbfloor.SelectedItem = dgvroom.CurrentRow.Cells[3].Value.ToString();
            txtroomnum.Text = dgvroom.CurrentRow.Cells[1].Value.ToString();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                sql = "select roomID,room_number,typename,floornumber from tbroom left join tbroomtype on tbroomtype.roomtypeID=tbroom.roomtypeID left join tbfloor on tbfloor.floorID=tbroom.floorID where roomID='" + txtsearch.Text + "' or room_number='" + txtsearch.Text + "'";
                da = new SqlDataAdapter(sql, con);
                da.Fill(ds, "room");
                if (ds.Tables["room"] != null)
                {
                    ds.Tables.Clear();
                }
                da.Fill(ds, "room");
                dgvroom.DataSource = ds.Tables["room"];
                dgvroom.Columns[0].HeaderText = "ລະຫັດ";
                dgvroom.Columns[1].HeaderText = "ເບີຫ້ອງ";
                dgvroom.Columns[2].HeaderText = "ປະເພດ";
                dgvroom.Columns[3].HeaderText = "ຊັ້ນ";
                dgvroom.Columns[4].HeaderText = "ຕຶກ";

                dgvroom.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }


        }

        private void btrsearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtsearch.Text == "")
                {
                    showdata();
                }
                else
                {
                    sql = "select roomID,room_number,typename,floornumber from tbroom left join tbroomtype on tbroomtype.roomtypeID=tbroom.roomtypeID left join tbfloor on tbfloor.floorID=tbroom.floorID where roomID='" + txtsearch.Text + "'";
                    da = new SqlDataAdapter(sql, con);
                    da.Fill(ds, "room");
                    if (ds.Tables["room"] != null)
                    {
                        ds.Tables.Clear();
                    }
                    da.Fill(ds, "room");
                    dgvroom.DataSource = ds.Tables["room"];

                }
                dgvroom.DataSource = ds.Tables["room"];
                dgvroom.Columns[0].HeaderText = "ລະຫັດ";
                dgvroom.Columns[1].HeaderText = "ເບີຫ້ອງ";
                dgvroom.Columns[2].HeaderText = "ປະເພດ";
                dgvroom.Columns[3].HeaderText = "ຊັ້ນ";
                dgvroom.Columns[4].HeaderText = "ຕຶກ";

                dgvroom.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void cbroomtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbuild.ResetText();
            cbfloor.ResetText();
            builcombo();

        }

        private void cbfloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtroomnum.Text = cbfloor.Text;
            txtroomnum.Focus();
            txtroomnum.Select(txtroomnum.Text.Length, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clrtext();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void cbbuild_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbfloor.Items.Clear();
            sql = "select floornumber from tbfloor where buildingID in (select buildingID from tbbuilding  where buildingnumber=N'" + cbbuild.SelectedItem + "')";
            cmd = new SqlCommand(sql, con);
            cbfloor.Items.Clear();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                cbfloor.Items.Add(reader.GetString(0));
            }
            reader.Close();
        }

        private void txtroomnum_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
