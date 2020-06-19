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
using System.Linq.Expressions;

namespace C_Sharp_2_Project
{
    public partial class study : Form
    {
        SqlConnection con = Connect.getconnect();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        string sql = "";

        public void showschool()
        {  
           
dgvschool.Refresh();
            dgvschool.Parent.Refresh();
            sql = "select * from tbschool";
            cmd = new SqlCommand(sql, con);
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "sh");
            if (ds.Tables["sh"] != null)
            {
                ds.Tables.Clear();
                da.Fill(ds, "sh");
dgvschool.DataSource = ds.Tables["sh"];
            }
            dgvschool.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvschool.Columns[0].HeaderText = "ລະຫັດໂຮງຮຽນ";
            dgvschool.Columns[1].HeaderText = "ຊື່ໂຮງຮຽນ";
            

        }
        public void showconoboxschool()
        {
            sql = "select *from tbschool";
         
            cmd = new SqlCommand(sql, con);
            SqlDataReader reader ;
            reader = cmd.ExecuteReader();
            cbschool.Items.Clear() ;
                while (reader .Read())
            {  string scho = reader.GetString(1);
                int schoID = reader.GetInt32(0);                
                    cbschool.Items.Add(scho);                  
            }reader.Close();           
        }
        public void facshow()
        {
            ds.Tables.Clear();
            sql = "select facID,facname,schoolname from tbfaculty inner join tbschool on tbschool.schoolID=tbfaculty.schoolID";
            da = new SqlDataAdapter(sql, con);
            da.Fill(ds, "fac");
            dgvfaculty.DataSource = ds.Tables["fac"];
            dgvfaculty.Update();
            dgvfaculty.Refresh();
            dgvfaculty.Parent.Refresh();
            dgvfaculty.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            dgvfaculty.Columns[0].HeaderText = "ລະຫັດຄະນະ";
            dgvfaculty.Columns[1].HeaderText = "ຊື່ຄະນະ";
            dgvfaculty.Columns[2].HeaderText = "ຊື່ໂຮງຮຽນ";
            
        }
        public void deptcombo()
        {
         
            sql = "select * from tbfaculty";
            cmd = new SqlCommand(sql, con);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            cbdepart.Items.Clear();
            while (reader.Read())
            {
                string facn = reader.GetString(1);
                int facID = reader.GetInt32(0);
                cbdepart .Items.Add(facn);
            }
            reader.Close();
           
            
        }
        public void showdept()         
        {
            ds.Tables.Clear();
            sql = "select deptID,deptname,facname from tbdepartment inner join tbfaculty on tbfaculty.facID=tbdepartment.facID";
            da = new SqlDataAdapter(sql, con);
            da.Fill(ds, "dept");
            dgvdepartment.DataSource = ds.Tables["dept"];
            
            dgvdepartment.Refresh();dgvdepartment.Update();
            dgvdepartment.Parent.Refresh();
            dgvdepartment.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;           
            dgvdepartment.Columns[0].HeaderText = "ລະຫັດພາກ";
            dgvdepartment.Columns[1].HeaderText = "ຊື່";
            dgvdepartment.Columns[2].HeaderText = "ຊື່ຄະນະ";

        }
        public void cleartext()
        {
            txtdepID.Clear();
            txtdepname.Clear();
            txtfacID.Clear();
            txtfacname.Clear();
            txtnameschool.Clear();
            txtschoolID.Clear();
            cbdepart.SelectedIndex =- 1;
            cbschool.SelectedIndex =- 1;
        }
        public study()
        {
            InitializeComponent();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void btssave_Click(object sender, EventArgs e)
        {
            sql = "insert into tbschool values (@schoolID,@schoolname)";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@schoolID", txtschoolID.Text);
            cmd.Parameters.AddWithValue("@schoolname", txtnameschool.Text);
            cmd.ExecuteNonQuery();
            showschool();
            showconoboxschool();
            cleartext();
        }

        private void btsedit_Click(object sender, EventArgs e)
        {
            sql = "update tbschool set schoolname=@schoolname where schoolID=@schoolID";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@schoolname", txtnameschool.Text);
            cmd.Parameters.AddWithValue("@schoolID", txtschoolID.Text);
            cmd.ExecuteNonQuery();
            cleartext();
            showschool();
            showconoboxschool();
        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            sql = "delete from tbschool where schoolID=@schoolID";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@schoolID", txtschoolID.Text);
            cmd.ExecuteNonQuery();
            cleartext();
            showschool();
            showconoboxschool();

        }

        private void dgvschool_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow roww = dgvschool.CurrentRow;
            txtschoolID.Text = roww.Cells[0].Value.ToString();
            txtnameschool.Text = roww.Cells[1].Value.ToString();

        }

        private void study_Load(object sender, EventArgs e)
        {
            showschool();            
            facshow();
            showdept();
            showconoboxschool();
            deptcombo();
        }

        private void btfsave_Click(object sender, EventArgs e)
        {
            sql = "insert into tbfaculty values (@facID,@facname,@shoolID)";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@facID", txtfacID .Text);
            cmd.Parameters.AddWithValue("@facname", txtfacname .Text);
            cmd.Parameters.AddWithValue("@shoolID", cbschool.SelectedIndex +1);
            cmd.ExecuteNonQuery();
            cleartext();
            facshow();
            deptcombo();

        }

        private void btfedit_Click(object sender, EventArgs e)
        {
            sql = "update tbfaculty set facname=@facname ,schoolID=@schoolID where facID=@facID";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@facname", txtfacname .Text);
            cmd.Parameters.AddWithValue("@schoolID", cbschool.SelectedIndex+1);
            cmd.Parameters.AddWithValue("@facID", txtfacID.Text);
            cmd.ExecuteNonQuery();
            cleartext();
            facshow();
            deptcombo();

        }

        private void btfdelete_Click(object sender, EventArgs e)
        {
            sql = "delete from tbfaculty where facID=@facID";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@facID", txtfacID.Text);
            cmd.ExecuteNonQuery();
            cleartext();
            facshow();
            deptcombo();

        }

        private void btdsave_Click(object sender, EventArgs e)
        {
            sql = "insert into tbdepartment values (@deptID,@deptname,@facID)";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@deptID", txtdepID .Text);
            cmd.Parameters.AddWithValue("@deptname", txtdepname.Text);
            cmd.Parameters.AddWithValue("@facID", cbdepart.SelectedIndex +1);
            cmd.ExecuteNonQuery();
           
            cleartext();
            showdept(); 
            dgvdepartment.Refresh();dgvdepartment.Update();
        }

        private void btdedit_Click(object sender, EventArgs e)
        {
            sql = "update tbdepartment set deptname=@deptname,facID=@facID where deptID=@deptID";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@deptname", txtdepname.Text);
            //cmd.Parameters.AddWithValue("@facID", cbdepart.SelectedIndex +1);
            cmd.Parameters.AddWithValue("@facID", cbdepart.SelectedIndex +1);           
            cmd.Parameters.AddWithValue("@deptID", txtdepID.Text);
            cmd.ExecuteNonQuery();
            cleartext();
            showdept();
           

        }

        private void btddelete_Click(object sender, EventArgs e)
        {
            sql = "delete from tbdepartment where deptID=@deptID";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@deptID", txtdepID.Text);
            cmd.ExecuteNonQuery();
            cleartext();
            showdept();
           

        }

        private void dgvdepartment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow roww = dgvdepartment .CurrentRow;
            txtdepID.Text = roww.Cells[0].Value.ToString();
            txtdepname.Text = roww.Cells[1].Value.ToString();
           cbdepart.SelectedItem =roww.Cells[2].Value;
        }

        private void dgvfaculty_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow roww = dgvfaculty .CurrentRow;
            txtfacID.Text = roww.Cells[0].Value.ToString();
            txtfacname.Text = roww.Cells[1].Value.ToString();
            cbschool.SelectedItem = roww.Cells[2].Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cleartext();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cleartext();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            cleartext();

        }

        private void cbschool_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
