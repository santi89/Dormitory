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
    public partial class ຂໍ້ມູນຕຶກ : Form

    {
        SqlConnection con = Connect.getconnect();
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader reader;
        DataSet ds = new DataSet();
        string sql = "";

        public ຂໍ້ມູນຕຶກ()
        {
            InitializeComponent();
            troomcombo();
            
        }
        
           
        private void troomcombo()
        {
            try
            {
                sql = "select * from tbroomtype";
                cmd = new SqlCommand(sql, con);
                reader = cmd.ExecuteReader();
                cbroomtype .Items.Clear();              
                while (reader.Read())
                {
                    cbroomtype .Items.Add(reader.GetString(1));                  
                }
                reader.Close();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        private void showbuild()
        {
            try
            {
sql = "select buildingID,buildingnumber,typename from tbbuilding inner join tbroomtype on tbroomtype.roomtypeID = tbbuilding.roomtypeID ";
            cmd = new SqlCommand(sql, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "build");
            if (ds.Tables["build"] != null) {
                ds.Tables.Clear();              
            }
            da.Fill(ds, "build");
           dgvbuild.DataSource = ds.Tables["build"];
            dgvbuild.Columns[0].HeaderText  = "ລະຫັດຕຶກ";
            dgvbuild.Columns[1].HeaderText  = "ເບີ້ຕຶກ";
            dgvbuild.Columns[2].HeaderText  = "ປະເພດຫ້ອງ";
                dgvbuild.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
            

        }
        public void clrtext()
        {
            txtbuildingid.Clear();
            txtbuildingnum.Clear();
            cbroomtype.SelectedItem = null;

        }
        private void btbsave_Click(object sender, EventArgs e)
        {
            try
            {
            sql = "insert into tbbuilding values (@build,@num ,(select roomtypeID from tbroomtype where typename=@roomtype))";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@build",txtbuildingid .Text );
            cmd.Parameters.AddWithValue("@num", txtbuildingnum.Text);
            cmd.Parameters.AddWithValue("@roomtype", cbroomtype.SelectedItem );
                cmd.ExecuteNonQuery();
            showbuild();
            clrtext();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
           
        }

        private void dgvbuilding_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void ຂໍ້ມູນຕຶກ_Load(object sender, EventArgs e)
        {
            showbuild();
        }

        private void btedit_Click(object sender, EventArgs e)
        {
            try
            {
               
                sql = "update tbbuilding set buildingnumber=@num,roomtypeID=@roomtype where buildingID=@build";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@num", txtbuildingnum.Text);
                cmd.Parameters.AddWithValue("@roomtype",cbroomtype.SelectedIndex+1 );
                cmd.Parameters.AddWithValue("@build", txtbuildingid.Text);         
                cmd.ExecuteNonQuery();
                showbuild();
                clrtext();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            try
            {
         sql = "delete from tbbuilding where buildingID=@build";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@build", txtbuildingid.Text);
            cmd.ExecuteNonQuery();
            showbuild();
            clrtext();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }          
        }

        private void button1_Click(object sender, EventArgs e)
        {          
             sql = "select * from tbbuilding where buildingnumber='" + txtsearch.Text + "'";
              cmd = new SqlCommand(sql, con);
              da = new SqlDataAdapter(cmd);
              da.Fill(ds, "bs");
              //if (ds.Tables ["bs"] != null)
              //{
              //    ds.Tables.Clear();
              //}
              //da.Fill(ds,"bs");
              dgvbuild.DataSource = ds.Tables["bs"];
        }

        private void dgvbuild_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbuildingid.Text = dgvbuild.CurrentRow.Cells[0].Value.ToString();
            txtbuildingnum.Text = dgvbuild.CurrentRow.Cells[1].Value.ToString();
            cbroomtype.SelectedItem = dgvbuild.CurrentRow.Cells[2].Value.ToString();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)

        {
            if (txtsearch .Text == "")
            {
                showbuild();
            }
            else
            {

            sql="select * from tbbuilding where buildingnumber='"+Convert .ToInt32 (txtsearch.Text) + "'";
                cmd = new SqlCommand(sql, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds,"bs");
            //if (ds.Tables ["bs"] != null)
            //{
            //    ds.Tables.Clear();
            //}
            //da.Fill(ds,"bs");
            dgvbuild.DataSource = ds.Tables["bs"];
                dgvbuild.Columns[0].HeaderText = "ລະຫັດຕຶກ";
                dgvbuild.Columns[1].HeaderText = "ເບີ້ຕຶກ";
                dgvbuild.Columns[2].HeaderText = "ປະເພດຫ້ອງ";
                dgvbuild.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }

        }

        private void cbroomtype_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clrtext();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
