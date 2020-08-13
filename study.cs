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
            try
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
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }




        }
        public void showconoboxschool()
        {
            try
            {
                sql = "select *from tbschool";

                cmd = new SqlCommand(sql, con);
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                cbschool.Items.Clear();
                while (reader.Read())
                {
                    string scho = reader.GetString(1);
                    int schoID = reader.GetInt32(0);
                    cbschool.Items.Add(scho);
                }
                reader.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }
        public void facshow()
        {
            try
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
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }


        }
        public void faccombo()
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
                cbdepart.Items.Add(facn);
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

            dgvdepartment.Refresh(); dgvdepartment.Update();
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
            cbdepart.SelectedIndex = -1;
            cbschool.SelectedIndex = -1;
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


        }

        private void btsedit_Click(object sender, EventArgs e)
        {


        }

        private void btdelete_Click(object sender, EventArgs e)
        {


        }

        private void dgvschool_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void study_Load(object sender, EventArgs e)
        {
            showschool();
            facshow();
            showdept();
            showconoboxschool();
            faccombo();

        }

        private void btfsave_Click(object sender, EventArgs e)
        {



        }

        private void btfedit_Click(object sender, EventArgs e)
        {



        }

        private void btfdelete_Click(object sender, EventArgs e)
        {



        }

        private void btdsave_Click(object sender, EventArgs e)
        {


        }

        private void btdedit_Click(object sender, EventArgs e)
        {




        }

        private void btddelete_Click(object sender, EventArgs e)
        {




        }

        private void dgvdepartment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvfaculty_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cleartext();
        }

        private void btdelete_Click_1(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }

        private void dgvschool_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow roww = dgvschool.CurrentRow;
            txtschoolID.Text = roww.Cells[0].Value.ToString();
            txtnameschool.Text = roww.Cells[1].Value.ToString();
        }

        private void txtschoolID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btsedit_Click_1(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtnameschool_TextChanged(object sender, EventArgs e)
        {

        }

        private void btssave_Click_1(object sender, EventArgs e)
        {
            try
            {
                string s = "select schoolname from tbschool where schoolname ='" + txtnameschool.Text + "'";
                cmd = new SqlCommand(s, con);
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                int i = dt.Rows.Count;
                if (i >= 1)
                {
                    MessageBox.Show("ຂໍ້ມູນຊ້ຳ.", "ແຈ້ງເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {

                    sql = "insert into tbschool values (@schoolname)";
                    cmd = new SqlCommand(sql, con);
                    cmd.Parameters.Clear();
                    // cmd.Parameters.AddWithValue("@schoolID", txtschoolID.Text);
                    cmd.Parameters.AddWithValue("@schoolname", txtnameschool.Text);
                    cmd.ExecuteNonQuery();
                    showschool();
                    showconoboxschool();
                    cleartext();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void g1_Enter(object sender, EventArgs e)
        {

        }

        private void g2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void cbschool_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btfdelete_Click_1(object sender, EventArgs e)
        {

        }

        private void dgvfaculty_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtfacID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void btfedit_Click_1(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void btfsave_Click_1(object sender, EventArgs e)
        {

        }

        private void txtfacname_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void g3_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void cbdepart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btddelete_Click_1(object sender, EventArgs e)
        {

        }

        private void dgvdepartment_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtdepID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btdedit_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtdepname_TextChanged(object sender, EventArgs e)
        {

        }

        private void btdsave_Click_1(object sender, EventArgs e)
        {

        }

        private void btdsave_Click_2(object sender, EventArgs e)
        {
            try
            {
                string s = "select * from tbdepartment where deptname ='" + txtdepname.Text + "' and facID = (select facID from tbfaculty where facname='" + cbdepart.SelectedItem + "')";
                cmd = new SqlCommand(s, con);
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                int i = dt.Rows.Count;
                if (i >= 1)
                {
                    MessageBox.Show("ຂໍ້ມູນຊ້ຳ.", "ແຈ້ງເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    sql = "insert into tbdepartment values (@deptname,(select facID from tbfaculty where facname=@facID))";
                    cmd = new SqlCommand(sql, con);
                    //cmd.Parameters.AddWithValue("@deptID", txtdepID .Text);
                    cmd.Parameters.AddWithValue("@deptname", txtdepname.Text);
                    cmd.Parameters.AddWithValue("@facID", cbdepart.SelectedItem);
                    cmd.ExecuteNonQuery();

                    cleartext();
                    showdept();
                    dgvdepartment.Refresh();
                    dgvdepartment.Update();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void btfsave_Click_2(object sender, EventArgs e)
        {
            try
            {
                string s = "select facname from tbfaculty where facname ='" + txtfacname.Text + "' and schoolID = (select schoolID from tbschool where schoolname ='"+ cbschool.SelectedItem +"')";
                cmd = new SqlCommand(s, con);
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                int i = dt.Rows.Count;
                if (i >= 1)
                {
                    MessageBox.Show("ຂໍ້ມູນຊ້ຳ.", "ແຈ້ງເຕືອນ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    sql = "insert into tbfaculty values (@facname,(select schoolID from tbschool where schoolname=@shoolID))";
                    cmd = new SqlCommand(sql, con);
                    cmd.Parameters.Clear();
                    // cmd.Parameters.AddWithValue("@facID", txtfacID .Text);
                    cmd.Parameters.AddWithValue("@facname", txtfacname.Text);
                    cmd.Parameters.AddWithValue("@shoolID", cbschool.SelectedItem);
                    cmd.ExecuteNonQuery();
                    cleartext();
                    facshow();
                    faccombo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btfedit_Click_2(object sender, EventArgs e)
        {

        }

        private void btfdelete_Click_2(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            cleartext();
        }

        private void dgvfaculty_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btdedit_Click_2(object sender, EventArgs e)
        {

        }

        private void dgvdepartment_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btddelete_Click_2(object sender, EventArgs e)
        {

        }

        private void btfedit_Click_3(object sender, EventArgs e)
        {
            try
            {
                sql = "update tbfaculty set facname=@name,schoolID=(select schoolID from tbschool where schoolname=@schoolID) where facID=@fid";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@name", txtfacname.Text);
                cmd.Parameters.AddWithValue("@schoolID", cbschool.SelectedItem);
                cmd.Parameters.AddWithValue("@fid", txtfacID.Text);
                cmd.ExecuteNonQuery();
                cleartext();
                facshow();
                faccombo();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void dgvfaculty_CellContentClick_3(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow roww = dgvfaculty.CurrentRow;
            txtfacID.Text = roww.Cells[0].Value.ToString();
            txtfacname.Text = roww.Cells[1].Value.ToString();
            cbschool.SelectedItem = roww.Cells[2].Value;
        }

        private void dgvdepartment_CellContentClick_3(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow roww = dgvdepartment.CurrentRow;
            txtdepID.Text = roww.Cells[0].Value.ToString();
            txtdepname.Text = roww.Cells[1].Value.ToString();
            cbdepart.SelectedItem = roww.Cells[2].Value;

        }

        private void btdedit_Click_3(object sender, EventArgs e)
        {
            try
            {
                sql = "update tbdepartment set deptname=@name,facID=(select facID from tbfaculty where facname=@facID) where deptID=@dep";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@name", txtdepname.Text);
                cmd.Parameters.AddWithValue("@facID", cbdepart.SelectedItem);
                cmd.Parameters.AddWithValue("@dep", txtdepID.Text);
                cmd.ExecuteNonQuery();
                cleartext();
                showdept();
                faccombo();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void btddelete_Click_3(object sender, EventArgs e)
        {
            try
            {
                sql = "delete from tbdepartment where deptID=@deptID";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@deptID", txtdepID.Text);
                cmd.ExecuteNonQuery();
                cleartext();
                showdept();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            cleartext();
        }

        private void btfdelete_Click_3(object sender, EventArgs e)
        {
            try
            {
                sql = "delete from tbfaculty where facID=@facID";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@facID", txtfacID.Text);
                cmd.ExecuteNonQuery();
                cleartext();
                facshow();
                faccombo();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void button2_Click_3(object sender, EventArgs e)
        {
            cleartext();
        }
    }
}
