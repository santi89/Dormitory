﻿using System;
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
    public partial class ຂໍ້ມູນປະເພດຫ້ອງ : Form
    {
        SqlConnection con = Connect.getconnect();
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader reader;
        DataSet ds = new DataSet();
        string sql = "";
        public ຂໍ້ມູນປະເພດຫ້ອງ()
        {
            InitializeComponent();
        }
        private void showdata()
        {
            try
            {
            sql = "select * from tbroomtype";
            da = new SqlDataAdapter(sql, con);
            da.Fill(ds, "rt");
            if (ds.Tables ["rt"]!=null)
            {
                ds.Tables.Clear();
            }
            da.Fill(ds, "rt");
            dgvroomtype.DataSource = ds.Tables["rt"];
            dgvroomtype.Columns[0].HeaderText = "ລະຫັດປະເພດ";
            dgvroomtype.Columns[1].HeaderText = "ຊື່ປະເພດ";
            dgvroomtype.Columns[2].HeaderText = "ລາຄາ";
            dgvroomtype.Columns[2].DefaultCellStyle .Format ="0,000 Kip";

                dgvroomtype.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());

            }
          
        }
        public void clrtext()
        {
            txttypeprice.Clear();
            txtroomtypeID.Clear();
            txtnametype.Clear();
        }
        private void btrtsave_Click(object sender, EventArgs e)
        {
           
        }
        private void ຂໍ້ມູນປະເພດຫ້ອງ_Load(object sender, EventArgs e)
        {
            showdata();

        }
        private void btrtedit_Click(object sender, EventArgs e)
        {
           
        }
        private void btrtdelete_Click(object sender, EventArgs e)
        {
           
        }

        private void dgvroomtype_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtroomtypeID.Text = dgvroomtype.CurrentRow.Cells[0].Value.ToString();
            txtnametype.Text = dgvroomtype.CurrentRow.Cells[1].Value.ToString();
            txttypeprice.Text = dgvroomtype.CurrentRow.Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtnametype.Clear();
            txtroomtypeID.Clear();
            txttypeprice.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btrtsave_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtnametype.Text ==null || txtroomtypeID.Text == null || txttypeprice .Text ==null) {
                    MessageBox.Show("ຂໍ້ມູນບໍ່ມີ.");
                    return;
                }
                
                string s = "select typename from tbroomtype where typename =N'" + txtnametype.Text + "'";
                cmd = new SqlCommand(s, con);
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                int i = dt.Rows.Count;
                if (i >= 1)
                {
                    MessageBox.Show("ຂໍ້ມູນນີ້ມີແລ້ວ.", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                sql = "insert into tbroomtype values(@rtID,@rtname,@price)";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@rtID", txtroomtypeID.Text);
                cmd.Parameters.AddWithValue("@rtname", txtnametype.Text);
                cmd.Parameters.AddWithValue("@price", txttypeprice.Text);
                cmd.ExecuteNonQuery();
                clrtext();
                showdata();
                }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btrtedit_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtnametype.Text == null || txtroomtypeID.Text == null || txttypeprice.Text == null)
                {
                    MessageBox.Show("ຂໍ້ມູນບໍ່ມີ.");
                    return;
                }
                sql = "update tbroomtype set typename=@rtname,roomprice=@price where roomtypeID=@rtID";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@rtname", txtnametype.Text);
                cmd.Parameters.AddWithValue("@price", txttypeprice.Text);
                cmd.Parameters.AddWithValue("@rtID", txtroomtypeID.Text);
                cmd.ExecuteNonQuery();
                clrtext();
                showdata();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btrtdelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtroomtypeID.Text == null)
                {
                    MessageBox.Show("ຂໍ້ມູນບໍ່ມີ.");
                    return;
                }
                sql = "delete from tbroomtype where roomtypeID=@rtID";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@rtID", txtroomtypeID.Text);
                cmd.ExecuteNonQuery();
                clrtext();
                showdata();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtnametype.Clear();
            txtroomtypeID.Clear();
            txttypeprice.Clear();
        }

        private void dgvroomtype_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtroomtypeID.Text = dgvroomtype.CurrentRow.Cells[0].Value.ToString();
            txtnametype.Text = dgvroomtype.CurrentRow.Cells[1].Value.ToString();
            txttypeprice.Text = dgvroomtype.CurrentRow.Cells[2].Value.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
