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
    
    public partial class ຂໍ້ມູນຊັ້ນ : Form
    {
        SqlConnection con = Connect.getconnect();
    SqlCommand cmd;
    SqlDataAdapter da;
    SqlDataReader reader;
    DataSet ds = new DataSet();
    string sql = "";

        public ຂໍ້ມູນຊັ້ນ()
        {
            InitializeComponent();
        }

        private void ຂໍ້ມູນຊັ້ນ_Load(object sender, EventArgs e)
        {
            showfloor();
            showcombo();
        }
        private void showfloor()
        {
            try
            {sql = "select floorID,floornumber,buildingnumber from tbfloor left join tbbuilding on tbfloor.buildingID=tbbuilding.buildingID";
            da = new SqlDataAdapter(sql, con);
            da.Fill(ds, "flo");
            if (ds.Tables["flo"] != null)
            {
                ds.Tables.Clear();
            }
            da.Fill(ds, "flo");
            dgvfloor.DataSource = ds.Tables["flo"];
            dgvfloor.Columns[0].HeaderText = "ລະຫັດຊັ້ນ";
            dgvfloor.Columns[1].HeaderText = "ເບີຊັ້ນ";
            dgvfloor.Columns[2].HeaderText = "ເບີຕຶກ";
                //dgvfloor.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //dgvfloor.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvfloor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
            
        }
        public void clrtext()
        {
            txtfloorid.Clear();
            txtfloornum.Clear();
            cbbuilding.SelectedIndex =-1;
            cbbuilding.SelectedItem = null;
        }
        private void showcombo()
        {
            try
            {
         sql = "select * from tbbuilding";
            cmd = new SqlCommand(sql, con);
            
            reader = cmd.ExecuteReader();
            cbbuilding.Items.Clear();
            while (reader.Read())
            {
                string bui = reader.GetString(1);
                int buiid = reader.GetInt32 (0);
                cbbuilding.Items.Add(bui);
            }reader.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
           

        }

        private void dgvfloor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
 txtfloorid.Text = dgvfloor.CurrentRow.Cells[0].Value.ToString();
            txtfloornum.Text = dgvfloor.CurrentRow.Cells[1].Value.ToString();
            cbbuilding.SelectedItem = dgvfloor.CurrentRow.Cells[2].Value;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
           
        }

        private void btfsave_Click(object sender, EventArgs e)
        {
            try
            {
        sql = "insert into tbfloor values(@floornum,@build)";//@floorID,
                cmd = new SqlCommand(sql, con);
            cmd.Parameters.Clear();
          //  cmd.Parameters.AddWithValue("@floorID", txtfloorid.Text);
            cmd.Parameters.AddWithValue("@floornum", txtfloornum.Text);
            cmd.Parameters.AddWithValue("@build", cbbuilding .SelectedIndex+1);
            cmd.ExecuteNonQuery();
                clrtext();
            showfloor();
            showcombo();
             
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
           
        }

        private void btfedit_Click(object sender, EventArgs e)
        {
            try
            {
 sql = "update tbfloor set floornumber=@fnum,buildingID=@build where floorID=@floorid";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@fnum", txtfloornum.Text);
            cmd.Parameters.AddWithValue("@build", cbbuilding.SelectedIndex + 1);
            cmd.Parameters.AddWithValue("@floorid", txtfloorid.Text);
            cmd.ExecuteNonQuery();
                clrtext();
            showfloor();
            showcombo(); 
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString ());
            }
           

        }

        private void btfdelete_Click(object sender, EventArgs e)
        {
            try
            {
        sql = "delete from tbfloor where floorID=@fid";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@fid", txtfloorid.Text);
            cmd.ExecuteNonQuery();
                clrtext();
            showfloor();
            showcombo();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clrtext();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                sql = "select * from tbfloor where floorID like '%" + txtsearch.Text + "' or floornumber LIKE '%"+txtsearch .Text +"'";
                da = new SqlDataAdapter(sql, con);
                da.Fill(ds, "flo");
                if (ds.Tables["flo"] != null) ds.Tables.Clear();                
                 da.Fill(ds, "flo");
                dgvfloor.DataSource = ds.Tables["flo"];
                dgvfloor.Columns[0].HeaderText = "ລະຫັດຊັ້ນ";
                dgvfloor.Columns[1].HeaderText = "ເບີຊັ້ນ";
                dgvfloor.Columns[2].HeaderText = "ເບີຕຶກ";

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cbbuilding_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtfloornum.Text = cbbuilding.Text;
            txtfloornum.Focus();
        }

        private void txtfloornum_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
