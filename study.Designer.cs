namespace C_Sharp_2_Project
{
    partial class study
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(study));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.dgvschool = new System.Windows.Forms.DataGridView();
            this.btssave = new System.Windows.Forms.Button();
            this.txtschoolID = new System.Windows.Forms.TextBox();
            this.txtnameschool = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btsedit = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.cbschool = new System.Windows.Forms.ComboBox();
            this.btfdelete = new System.Windows.Forms.Button();
            this.dgvfaculty = new System.Windows.Forms.DataGridView();
            this.txtfacID = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btfedit = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btfsave = new System.Windows.Forms.Button();
            this.txtfacname = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.cbdepart = new System.Windows.Forms.ComboBox();
            this.btddelete = new System.Windows.Forms.Button();
            this.dgvdepartment = new System.Windows.Forms.DataGridView();
            this.txtdepID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btdedit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtdepname = new System.Windows.Forms.TextBox();
            this.btdsave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvschool)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfaculty)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdepartment)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 726);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1262, 685);
            this.tabControl1.TabIndex = 33;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.btdelete);
            this.tabPage1.Controls.Add(this.dgvschool);
            this.tabPage1.Controls.Add(this.btssave);
            this.tabPage1.Controls.Add(this.txtschoolID);
            this.tabPage1.Controls.Add(this.txtnameschool);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btsedit);
            this.tabPage1.Location = new System.Drawing.Point(4, 45);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1254, 636);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ຈັດການຂໍ້ມູນສະຖາບັນ";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(743, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 64);
            this.button1.TabIndex = 29;
            this.button1.Text = "ຍົກເລີກ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btdelete
            // 
            this.btdelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btdelete.Image = ((System.Drawing.Image)(resources.GetObject("btdelete.Image")));
            this.btdelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btdelete.Location = new System.Drawing.Point(614, 265);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(103, 64);
            this.btdelete.TabIndex = 28;
            this.btdelete.Text = "ລຶບ";
            this.btdelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click_1);
            // 
            // dgvschool
            // 
            this.dgvschool.AllowUserToAddRows = false;
            this.dgvschool.AllowUserToDeleteRows = false;
            this.dgvschool.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvschool.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvschool.Location = new System.Drawing.Point(324, 335);
            this.dgvschool.Name = "dgvschool";
            this.dgvschool.ReadOnly = true;
            this.dgvschool.RowHeadersWidth = 51;
            this.dgvschool.RowTemplate.Height = 24;
            this.dgvschool.Size = new System.Drawing.Size(549, 253);
            this.dgvschool.TabIndex = 27;
            this.dgvschool.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvschool_CellContentClick_1);
            // 
            // btssave
            // 
            this.btssave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btssave.Image = ((System.Drawing.Image)(resources.GetObject("btssave.Image")));
            this.btssave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btssave.Location = new System.Drawing.Point(324, 265);
            this.btssave.Name = "btssave";
            this.btssave.Size = new System.Drawing.Size(120, 64);
            this.btssave.TabIndex = 28;
            this.btssave.Text = "ບັນທຶກ";
            this.btssave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btssave.UseVisualStyleBackColor = true;
            this.btssave.Click += new System.EventHandler(this.btssave_Click_1);
            // 
            // txtschoolID
            // 
            this.txtschoolID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtschoolID.Enabled = false;
            this.txtschoolID.Location = new System.Drawing.Point(541, 92);
            this.txtschoolID.Name = "txtschoolID";
            this.txtschoolID.Size = new System.Drawing.Size(257, 42);
            this.txtschoolID.TabIndex = 18;
            this.txtschoolID.TextChanged += new System.EventHandler(this.txtschoolID_TextChanged);
            // 
            // txtnameschool
            // 
            this.txtnameschool.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtnameschool.Location = new System.Drawing.Point(541, 149);
            this.txtnameschool.Name = "txtnameschool";
            this.txtnameschool.Size = new System.Drawing.Size(257, 42);
            this.txtnameschool.TabIndex = 20;
            this.txtnameschool.TextChanged += new System.EventHandler(this.txtnameschool_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(371, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 36);
            this.label1.TabIndex = 17;
            this.label1.Text = "ລະຫັດໂຮງຮຽນ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 36);
            this.label2.TabIndex = 19;
            this.label2.Text = "ຊື່ໂຮງຮຽນ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btsedit
            // 
            this.btsedit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btsedit.Image = ((System.Drawing.Image)(resources.GetObject("btsedit.Image")));
            this.btsedit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btsedit.Location = new System.Drawing.Point(470, 265);
            this.btsedit.Name = "btsedit";
            this.btsedit.Size = new System.Drawing.Size(120, 64);
            this.btsedit.TabIndex = 28;
            this.btsedit.Text = "ແກ້ໄຂ";
            this.btsedit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btsedit.UseVisualStyleBackColor = true;
            this.btsedit.Click += new System.EventHandler(this.btsedit_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.cbschool);
            this.tabPage2.Controls.Add(this.btfdelete);
            this.tabPage2.Controls.Add(this.dgvfaculty);
            this.tabPage2.Controls.Add(this.txtfacID);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.btfedit);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.btfsave);
            this.tabPage2.Controls.Add(this.txtfacname);
            this.tabPage2.Location = new System.Drawing.Point(4, 45);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1254, 636);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ຈັດການຂໍ້ມູນຄະນະ";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(739, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 66);
            this.button2.TabIndex = 39;
            this.button2.Text = "ຍົກເລີກ";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_3);
            // 
            // cbschool
            // 
            this.cbschool.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbschool.FormattingEnabled = true;
            this.cbschool.Location = new System.Drawing.Point(519, 143);
            this.cbschool.Name = "cbschool";
            this.cbschool.Size = new System.Drawing.Size(273, 44);
            this.cbschool.TabIndex = 40;
            // 
            // btfdelete
            // 
            this.btfdelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btfdelete.Image = ((System.Drawing.Image)(resources.GetObject("btfdelete.Image")));
            this.btfdelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btfdelete.Location = new System.Drawing.Point(619, 211);
            this.btfdelete.Name = "btfdelete";
            this.btfdelete.Size = new System.Drawing.Size(99, 66);
            this.btfdelete.TabIndex = 36;
            this.btfdelete.Text = "ລຶບ";
            this.btfdelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btfdelete.UseVisualStyleBackColor = true;
            this.btfdelete.Click += new System.EventHandler(this.btfdelete_Click_3);
            // 
            // dgvfaculty
            // 
            this.dgvfaculty.AllowUserToAddRows = false;
            this.dgvfaculty.AllowUserToDeleteRows = false;
            this.dgvfaculty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvfaculty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfaculty.Location = new System.Drawing.Point(351, 283);
            this.dgvfaculty.Name = "dgvfaculty";
            this.dgvfaculty.ReadOnly = true;
            this.dgvfaculty.RowHeadersWidth = 51;
            this.dgvfaculty.RowTemplate.Height = 24;
            this.dgvfaculty.Size = new System.Drawing.Size(542, 303);
            this.dgvfaculty.TabIndex = 35;
            this.dgvfaculty.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvfaculty_CellContentClick_3);
            // 
            // txtfacID
            // 
            this.txtfacID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtfacID.Enabled = false;
            this.txtfacID.Location = new System.Drawing.Point(520, 29);
            this.txtfacID.Name = "txtfacID";
            this.txtfacID.Size = new System.Drawing.Size(272, 42);
            this.txtfacID.TabIndex = 31;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(381, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 36);
            this.label14.TabIndex = 30;
            this.label14.Text = "ລະຫັດຄະນະ";
            // 
            // btfedit
            // 
            this.btfedit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btfedit.Image = ((System.Drawing.Image)(resources.GetObject("btfedit.Image")));
            this.btfedit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btfedit.Location = new System.Drawing.Point(486, 211);
            this.btfedit.Name = "btfedit";
            this.btfedit.Size = new System.Drawing.Size(127, 66);
            this.btfedit.TabIndex = 37;
            this.btfedit.Text = "ແກ້ໄຂ";
            this.btfedit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btfedit.UseVisualStyleBackColor = true;
            this.btfedit.Click += new System.EventHandler(this.btfedit_Click_3);
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(381, 146);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(82, 36);
            this.label19.TabIndex = 32;
            this.label19.Text = "ໂຮງຮຽນ";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(381, 89);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 36);
            this.label16.TabIndex = 33;
            this.label16.Text = "ຊື່ຄະນະ";
            // 
            // btfsave
            // 
            this.btfsave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btfsave.Image = ((System.Drawing.Image)(resources.GetObject("btfsave.Image")));
            this.btfsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btfsave.Location = new System.Drawing.Point(362, 211);
            this.btfsave.Name = "btfsave";
            this.btfsave.Size = new System.Drawing.Size(118, 66);
            this.btfsave.TabIndex = 38;
            this.btfsave.Text = "ບັນທຶກ";
            this.btfsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btfsave.UseVisualStyleBackColor = true;
            this.btfsave.Click += new System.EventHandler(this.btfsave_Click_2);
            // 
            // txtfacname
            // 
            this.txtfacname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtfacname.Location = new System.Drawing.Point(520, 83);
            this.txtfacname.Name = "txtfacname";
            this.txtfacname.Size = new System.Drawing.Size(272, 42);
            this.txtfacname.TabIndex = 34;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.cbdepart);
            this.tabPage3.Controls.Add(this.btddelete);
            this.tabPage3.Controls.Add(this.dgvdepartment);
            this.tabPage3.Controls.Add(this.txtdepID);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.btdedit);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.txtdepname);
            this.tabPage3.Controls.Add(this.btdsave);
            this.tabPage3.Location = new System.Drawing.Point(4, 45);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1254, 636);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ຈັດການຂໍ້ມູນພາກ";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(769, 248);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 68);
            this.button3.TabIndex = 39;
            this.button3.Text = "ຍົກເລີກ";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // cbdepart
            // 
            this.cbdepart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbdepart.FormattingEnabled = true;
            this.cbdepart.Location = new System.Drawing.Point(531, 177);
            this.cbdepart.Name = "cbdepart";
            this.cbdepart.Size = new System.Drawing.Size(244, 44);
            this.cbdepart.TabIndex = 40;
            // 
            // btddelete
            // 
            this.btddelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btddelete.Image = ((System.Drawing.Image)(resources.GetObject("btddelete.Image")));
            this.btddelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btddelete.Location = new System.Drawing.Point(651, 248);
            this.btddelete.Name = "btddelete";
            this.btddelete.Size = new System.Drawing.Size(95, 68);
            this.btddelete.TabIndex = 36;
            this.btddelete.Text = "ລຶບ";
            this.btddelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btddelete.UseVisualStyleBackColor = true;
            this.btddelete.Click += new System.EventHandler(this.btddelete_Click_3);
            // 
            // dgvdepartment
            // 
            this.dgvdepartment.AllowUserToAddRows = false;
            this.dgvdepartment.AllowUserToDeleteRows = false;
            this.dgvdepartment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvdepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdepartment.Location = new System.Drawing.Point(368, 321);
            this.dgvdepartment.Name = "dgvdepartment";
            this.dgvdepartment.ReadOnly = true;
            this.dgvdepartment.RowHeadersWidth = 51;
            this.dgvdepartment.RowTemplate.Height = 24;
            this.dgvdepartment.Size = new System.Drawing.Size(530, 265);
            this.dgvdepartment.TabIndex = 35;
            this.dgvdepartment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdepartment_CellContentClick_3);
            // 
            // txtdepID
            // 
            this.txtdepID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtdepID.Enabled = false;
            this.txtdepID.Location = new System.Drawing.Point(531, 69);
            this.txtdepID.Name = "txtdepID";
            this.txtdepID.Size = new System.Drawing.Size(244, 42);
            this.txtdepID.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 36);
            this.label4.TabIndex = 30;
            this.label4.Text = "ລະຫັດພາກ";
            // 
            // btdedit
            // 
            this.btdedit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btdedit.Image = ((System.Drawing.Image)(resources.GetObject("btdedit.Image")));
            this.btdedit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btdedit.Location = new System.Drawing.Point(512, 248);
            this.btdedit.Name = "btdedit";
            this.btdedit.Size = new System.Drawing.Size(119, 67);
            this.btdedit.TabIndex = 37;
            this.btdedit.Text = "ແກ້ໄຂ";
            this.btdedit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btdedit.UseVisualStyleBackColor = true;
            this.btdedit.Click += new System.EventHandler(this.btdedit_Click_3);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 36);
            this.label3.TabIndex = 32;
            this.label3.Text = "ຄະນະ";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(403, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 36);
            this.label11.TabIndex = 33;
            this.label11.Text = "ຊື່ພາກ";
            // 
            // txtdepname
            // 
            this.txtdepname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtdepname.Location = new System.Drawing.Point(531, 119);
            this.txtdepname.Name = "txtdepname";
            this.txtdepname.Size = new System.Drawing.Size(244, 42);
            this.txtdepname.TabIndex = 34;
            // 
            // btdsave
            // 
            this.btdsave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btdsave.Image = ((System.Drawing.Image)(resources.GetObject("btdsave.Image")));
            this.btdsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btdsave.Location = new System.Drawing.Point(368, 248);
            this.btdsave.Name = "btdsave";
            this.btdsave.Size = new System.Drawing.Size(121, 68);
            this.btdsave.TabIndex = 38;
            this.btdsave.Text = "ບັນທຶກ";
            this.btdsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btdsave.UseVisualStyleBackColor = true;
            this.btdsave.Click += new System.EventHandler(this.btdsave_Click_2);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1262, 41);
            this.panel2.TabIndex = 34;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(1234, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 36);
            this.label5.TabIndex = 32;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Saysettha OT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1262, 41);
            this.label6.TabIndex = 17;
            this.label6.Text = "ຂໍ້ມູນການສຶກສາ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // study
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(208)))), ((int)(((byte)(203)))));
            this.ClientSize = new System.Drawing.Size(1262, 726);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "study";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "study";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.study_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvschool)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfaculty)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdepartment)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.DataGridView dgvschool;
        private System.Windows.Forms.TextBox txtschoolID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btsedit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnameschool;
        private System.Windows.Forms.Button btssave;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbschool;
        private System.Windows.Forms.Button btfdelete;
        private System.Windows.Forms.DataGridView dgvfaculty;
        private System.Windows.Forms.TextBox txtfacID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btfedit;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btfsave;
        private System.Windows.Forms.TextBox txtfacname;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cbdepart;
        private System.Windows.Forms.Button btddelete;
        private System.Windows.Forms.DataGridView dgvdepartment;
        private System.Windows.Forms.TextBox txtdepID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btdedit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtdepname;
        private System.Windows.Forms.Button btdsave;
        private System.Windows.Forms.Label label6;
    }
}