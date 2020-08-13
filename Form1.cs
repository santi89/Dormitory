using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Sharp_2_Project
{
    public partial class Form1 : Form
    {
        public static string date1;
        public string pa,us1;
     
        public Form1( string u,string p )
        {
            InitializeComponent();
            pa = p;
            us1 = u;
            if (us1 == "admin" && pa == "admin")
            {
                empmanage.Enabled = true;
            }else
            {
                empmanage.Enabled = false;
            }
        }

        private void ການຊຳລະຕາຫToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ລງທະບຽນToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ລາຍງານວນໝດອາຍພກToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (us1 == "admin" && pa == "admin")
            {
                empmanage.Enabled = true;
            }



            toolStripLabel1.Text = System.DateTime.Now.ToString();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void crToolStripTextBox1_Click(object sender, EventArgs e)
        {
            Formlogin fl = new Formlogin();
            fl.Show();
            this.Hide();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void crToolStripTextBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ລງທະບຽນແລະຊຳລະຄາຫToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showform_in_panel(new Addstudent());
            date1 = toolStripLabel1.Text;
        }

        private void crToolStripTextBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Formlogin fo = new Formlogin();
            fo.Show();
        }
        public  void showform_in_panel(object formget)
        {
            if (this.panel_show.Controls.Count > 0) this.panel_show.Controls.RemoveAt(0);
            Form f = formget as Form;
            f.TopLevel = false;
          //  f.Dock = DockStyle.Fill;
            this.panel_show.Controls.Add(f);
            this.panel_show.Tag = f;
            f.Show();
        }
        
        private void ຊຳລະຄາຫToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
           
            
        }

        private void ຈດການຂມນToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showform_in_panel(new ຂໍ້ມູນຫ້ອງ());
        }

        private void ຈດການຂມນຕກToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showform_in_panel(new ຂໍ້ມູນຕຶກ());

        }

        private void ຈດການຂມນຊນToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showform_in_panel(new ຂໍ້ມູນຊັ້ນ());

        }

        private void ຈດການຂມນປະເພດຫອງToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showform_in_panel(new ຂໍ້ມູນປະເພດຫ້ອງ());

        }

        private void ຈດການຂມນສະຖາບນToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showform_in_panel(new study());

        }

        private void ລາຍງານນກສກສາເຂາພກToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showform_in_panel(new Reportstudent());
        }

        private void ອອກຈາລະບບToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formlogin lo = new Formlogin();
            this.Hide ();
            lo.ShowDialog();
            
            
            
        }

        private void ຈດການຂມນພະນກງານToolStripMenuItem_Click(object sender, EventArgs e)
            
        {
           
            showform_in_panel(new employee());
        }

        private void ຊຳລະຄາຫToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            showform_in_panel(new payment());
        }

        private void ຍາຍຫອງToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showform_in_panel(new MoveRoom());
        }

        private void ລາຍງານນກສກສາໝດກຳນດພກເຊາToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showform_in_panel(new exprirestudent ());
        }
    }
}
