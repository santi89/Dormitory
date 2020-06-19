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
        string sql = "";
        public ຂໍ້ມູນຫ້ອງ()
        {
            InitializeComponent();
        }

        private void ຂໍ້ມູນຫ້ອງ_Load(object sender, EventArgs e)
        {
            showdata();
            comtype();
           
            comfloor();
        }
        string[] strtitle = { "ລະຫັດ", "ເບີຫ້ອງ", "ຊື່ປະເພດ", "ເບີຊັ້ນ", "ເບີຕຶກ", "ຈຳນວນນັກຮຽນ" };
        // int[] siz = { 50, 50, 80, 50, 50, 100, 130 };
       // AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
        private void showdata()
        {
            try
            {
                sql = "select roomID,room_number,typename,floornumber,buildingnumber,Student_amount from tbroom left join tbroomtype on tbroomtype.roomtypeID=tbroom.roomtypeID left join tbfloor on tbfloor.floorID=tbroom.floorID left join tbbuilding on tbbuilding.buildingID = tbroom.buildingID";
            da = new SqlDataAdapter(sql, con);
            da.Fill(ds, "room");
            if (ds.Tables["room"] !=null)
            {
                ds.Tables.Clear();
            }da.Fill(ds, "room");
            dgvroom.DataSource = ds.Tables["room"];
            for (int i=0;i<strtitle.Length; i++)
            {
                dgvroom.Columns[i].HeaderText = strtitle[i];
               // dgvroom.Columns[i].Width = siz[i];
            }
            dgvroom.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex )
            {

                MessageBox.Show(ex.Message.ToString());
            }        }

        public void comtype()
        {
            try
            {
                sql = "select * from tbroomtype";
             cmd=new SqlCommand (sql, con);
                reader = cmd.ExecuteReader();
                cbroomtype.Items.Clear();
                while (reader .Read())
                {
                    string typename = reader.GetString(1);
                    cbroomtype.Items.Add(typename);
                }reader.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
        }
        }

       /* public void combuild()
        {
            try
            {
                sql = "select * from tbbuilding";
                cmd = new SqlCommand(sql, con);
                reader = cmd.ExecuteReader();
                cbbuildID.Items.Clear();
                while (reader.Read()) {
                    string strbui = reader.GetString(1);
                    cbbuildID.Items.Add(strbui);
}reader.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }*/
        public void comfloor()
        {
            sql = "select distinct floornumber from tbfloor ";
            cmd = new SqlCommand(sql, con);
            reader = cmd.ExecuteReader();
            cbfloor.Items.Clear();
            while (reader .Read())
            {
                string strflo = reader.GetString(0);
                cbfloor.Items.Add(strflo);
            }reader.Close();
        }


        private void btrsave_Click(object sender, EventArgs e)
        {
            try
            { 
                sql = "insert into tbroom values(@roomID,@roomnum,@rtype,@flo,@stamount)";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@roomID",txtroomid .Text );
            cmd.Parameters.AddWithValue("@roomnum",txtroomnum.Text);
            cmd.Parameters.AddWithValue("@rtype",cbroomtype .SelectedIndex+1);
            cmd.Parameters.AddWithValue("@flo",cbfloor.SelectedIndex+1);
            //cmd.Parameters.AddWithValue("@bui",cbbuildID .SelectedIndex +1);         
            cmd.Parameters.AddWithValue("@stamount",txtstamount .Text );
            cmd.ExecuteNonQuery();
            showdata();
                comtype();
               
                comfloor();


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
                sql = "update tbroom set room_number=@rnum,roomtypeID=@type,floorID=@floid,Student_amount=@stamount where roomID=@rID";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@rnum",txtroomnum .Text);
                cmd.Parameters.AddWithValue("@type",cbroomtype .SelectedIndex+1);
                cmd.Parameters.AddWithValue("@floid",cbfloor .SelectedIndex+1);
              //  cmd.Parameters.AddWithValue("@buid",cbbuildID .SelectedIndex+1);
               
                cmd.Parameters.AddWithValue("@stamount",txtstamount .Text );
                cmd.Parameters.AddWithValue("@rID",txtroomid .Text );
                cmd.ExecuteNonQuery();
                showdata();             
                comtype();
                comfloor();


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
                sql = "delete from tbroom where roomID=@roomID";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@roomID", txtroomid.Text);
                cmd.ExecuteNonQuery();
                showdata();
                comtype();
               
                comfloor();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());

            }
        }

        private void dgvroom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtroomid.Text = dgvroom.CurrentRow.Cells[0].Value.ToString();
             txtroomnum.Text = dgvroom.CurrentRow.Cells[1].Value.ToString();
            cbroomtype.SelectedItem  = dgvroom.CurrentRow.Cells[2].Value.ToString ();
            cbfloor.SelectedItem = dgvroom.CurrentRow.Cells[3].Value.ToString ();
           
          
            txtstamount.Text = dgvroom.CurrentRow.Cells[4].Value.ToString();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                sql = "select roomID,room_number,typename,floornumber,Student_amount from tbroom left join tbroomtype on tbroomtype.roomtypeID=tbroom.roomtypeID left join tbfloor on tbfloor.floorID=tbroom.floorID where roomID='"+ txtsearch.Text +"'";
                da = new SqlDataAdapter(sql, con);
                da.Fill(ds, "room");
                if (ds.Tables["room"] != null)
                {
                    ds.Tables.Clear();
                }
                da.Fill(ds, "room");
                dgvroom.DataSource = ds.Tables["room"];

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
                sql = "select roomID,room_number,typename,floornumber,room_status from tbroom left join tbroomtype on tbroomtype.roomtypeID=tbroom.roomtypeID left join tbfloor on tbfloor.floorID=tbroom.floorID where roomID='" + txtsearch.Text + "'";
                da = new SqlDataAdapter(sql, con);
                da.Fill(ds, "room");
                if (ds.Tables["room"] != null)
                {
                    ds.Tables.Clear();
                }
                da.Fill(ds, "room");
                dgvroom.DataSource = ds.Tables["room"];

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
