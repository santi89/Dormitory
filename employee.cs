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
    public partial class employee : Form
    {
        string sql = "";
        SqlConnection con = Connect.getconnect();
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataSet ds=new DataSet();

        public void showdata()
        {
            sql = "select * from tbemployee";
            cmd = new SqlCommand(sql, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "emp");
            if (ds.Tables["emp"] != null)
            {
                ds.Tables["emp"].Clear();
            }
            da.Fill(ds, "emp");
            dgvemp.DataSource = ds.Tables["emp"];
            dgvemp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvemp.Columns[0].HeaderText = "ລະຫັດພະນັກງານ";
            dgvemp.Columns[1].HeaderText = "ລະຫັດເຂົ້າລະບົບ";
            dgvemp.Columns[2].HeaderText = "ຊື່";
            dgvemp.Columns[3].HeaderText = "ນາມສະກຸນ";
            dgvemp.Columns[4].HeaderText = "ເພດ";
            dgvemp.Columns[5].HeaderText = "ວັນເດືອນປີເກີດ";
            dgvemp.Columns[6].HeaderText = "ທີຢູ່";
            dgvemp.Columns[7].HeaderText = "ເບີໂທ";
            dgvemp.Columns[8].HeaderText = "ອີເມວ";
            dgvemp.Columns[0].Width =120;
            dgvemp.Columns[1].Width  = 120;
            dgvemp.Columns[4].Width  = 80;
            dgvemp.Columns[5].Width   =120;


        }
        public void cleardata()
        {
            txtemail.Clear();
            txtempID.Clear();
            txtaddress.Clear();
            txtname.Clear();
            txtsurname.Clear();
            txttel.Clear();
            txtpassword.Clear();
            rbfemale.Checked = false;
            rbmale.Checked = false;

        }
        public employee()
        {
            InitializeComponent();
        }

        private void employee_Load(object sender, EventArgs e)
        {
            showdata();
        }
        string gen = "";
        private void button1_Click(object sender, EventArgs e)
        {
            sql = "INSERT INTO [tbemployee](empID,empname,userpassword ,empsurname,gender,dateofbirth,address,phone,email) VALUES (@empID,@empname,@userpassword,@empsurname,@gender,@dateofbirth,@address,@phone,@email) ";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@empID", txtempID.Text);
            cmd.Parameters.AddWithValue("@empname", txtname.Text);
            cmd.Parameters.AddWithValue("@userpassword", txtpassword.Text);
            cmd.Parameters.AddWithValue("@empsurname", txtsurname.Text);
            if (rbmale.Checked)
            {    gen = rbmale.Text;
            } else if (rbfemale.Checked)
            {     gen = rbfemale.Text;
            }   else {    gen = rbmale.Text;
            }
            cmd.Parameters.AddWithValue("@gender",gen);
            cmd.Parameters.AddWithValue("@dateofbirth", txtdateTime .Value );
            cmd.Parameters.AddWithValue("@address",txtaddress .Text );
            cmd.Parameters.AddWithValue("@phone",txttel.Text );
            cmd.Parameters.AddWithValue("@email", txtemail.Text);

            cmd.ExecuteNonQuery();
            showdata();

        }

        private void btedit_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {

                
            }
            sql = "update tbemployee set empname=@empname,userpassword=@userpassword ,empsurname=@empsurname,gender=@gender,dateofbirth=@dateofbirth,address=@addrss,phone=@phone ,email=@email where empID=@empID ";
                 cmd = new SqlCommand(sql, con);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@empname", txtname.Text);
            cmd.Parameters.AddWithValue("@userpassword", txtpassword.Text);
            cmd.Parameters.AddWithValue("@empsurname", txtsurname.Text);
            if (rbmale.Checked)
            {
                gen = rbmale.Text;
            }
            else if (rbfemale.Checked)
            {
                gen = rbfemale.Text;
            }
            else
            {
                gen = rbmale.Text;
            }
            cmd.Parameters.AddWithValue("@gender", gen);
            cmd.Parameters.AddWithValue("@dateofbirth", txtdateTime.Value);
            cmd.Parameters.AddWithValue("@address", txtaddress.Text);
            cmd.Parameters.AddWithValue("@phone", txttel.Text);
            cmd.Parameters.AddWithValue("@email", txtemail.Text);
            cmd.Parameters.AddWithValue("@empID", txtempID.Text);
            cmd.ExecuteNonQuery();
            showdata();
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            sql = "delete * from employee where empID=@empID";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@empID", txtempID.Text);
            cmd.ExecuteNonQuery();
            showdata();
        }

        private void dgvemp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow indexrow = dgvemp.CurrentRow;
            txtempID.Text = indexrow.Cells[0].Value.ToString();
            txtname.Text =indexrow.Cells[1].Value.ToString();
            txtpassword.Text = indexrow.Cells[2].Value.ToString();
            txtsurname.Text = indexrow.Cells[3].Value .ToString ();
            if (rbfemale.Text == indexrow .Cells [4].Value.ToString()){
                rbfemale.Checked=true;
            } else
            {
                rbmale.Checked = true;
            }
             
            txtaddress.Text =indexrow .Cells [6].Value .ToString ();
            txtdateTime.Text =indexrow .Cells [5].Value.ToString() ;
            txtemail.Text =indexrow.Cells [8].Value .ToString ();
            txttel.Text = indexrow.Cells[7].Value.ToString() ;
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btsearch_Click(object sender, EventArgs e)
        {
            if (txtsearch .Text == "")
            {
                showdata();
            }else
            {
      sql="select *from tbemployee where empID='"+txtsearch .Text+ "' or empname='" + txtsearch.Text + "'";
            cmd = new SqlCommand(sql, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds,"emp");
                if (ds.Tables["emp"] != null)
                {
                    ds.Tables["emp"].Clear ();
                }
                da.Fill (ds, "emp");
                dgvemp.DataSource = ds.Tables["emp"];
                dgvemp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvemp.Columns[0].HeaderText = "ລະຫັດພະນັກງານ";
                dgvemp.Columns[1].HeaderText = "ລະຫັດເຂົ້າລະບົບ";
                dgvemp.Columns[2].HeaderText = "ຊື່";
                dgvemp.Columns[3].HeaderText = "ນາມສະກຸນ";
                dgvemp.Columns[4].HeaderText = "ເພດ";
                dgvemp.Columns[5].HeaderText = "ວັນເດືອນປີເກີດ";
                dgvemp.Columns[6].HeaderText = "ທີຢູ່";
                dgvemp.Columns[7].HeaderText = "ເບີໂທ";
                dgvemp.Columns[8].HeaderText = "ອີເມວ";
                dgvemp.Columns[0].Width = 120;
                dgvemp.Columns[1].Width = 120;
                dgvemp.Columns[4].Width = 80;
                dgvemp.Columns[5].Width = 120;
            }
           
           

        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
