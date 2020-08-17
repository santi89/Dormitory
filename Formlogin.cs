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
    public partial class Formlogin : Form
    {
        SqlConnection con = Connect.getconnect();
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader reader;
        DataSet ds =new DataSet();
        string sql;
        public static string user="", pass="";

        
        public Formlogin()
        {
            InitializeComponent();                       
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        
        {    try 
	{	        
                if (txtname .Text == "" || txtpassword .Text  =="")
                {
                    MessageBox.Show("ກະລຸນາປ້ອນຂໍ້ມູນໃຫ້ຄົບ");
                    return;
                }

		 sql = "select *from tbemployee where empname=@empname and userpassword=@pass ";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@empname", txtname.Text);
            cmd.Parameters.AddWithValue("@pass", txtpassword.Text);

            da = new SqlDataAdapter(cmd);
            //cmd.ExecuteNonQuery();
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                user = reader.GetString(1).ToString();
                pass = reader.GetString(2).ToString();
            }
            reader.Close();
                if (da.Fill(ds, "emp") > 0)
                {
                    Form1 f1 = new Form1(txtname.Text,txtpassword.Text);
                    txtname.Clear();
                    txtpassword.Clear();
                    this.Hide();
                    f1.Show();
                   
                   
                }
            else
                {
                    MessageBox.Show("ກະລຸນາກວດເບິ່ງລະຫັດແລະຊື່ຜູ້ໃຊ້ໃໝ່","ແຈ້ງເຕືອນ", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    txtname.Clear();
                    txtpassword.Clear();
                }
	}
	catch (Exception ex)
	{
                MessageBox.Show(ex.Message.ToString ());
		
	}
                 
        }

        private void Formlogin_Load(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) txtpassword.PasswordChar = '\0';
            else txtpassword.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtname_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtpassword.Focus();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
