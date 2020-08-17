namespace C_Sharp_2_Project
{
    partial class MoveRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoveRoom));
            this.dgvnew = new System.Windows.Forms.DataGridView();
            this.dgvold = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btsearchold = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label28 = new System.Windows.Forms.Label();
            this.lbstartdate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.lbname = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbenddate = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbsurname = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbid = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbroom = new System.Windows.Forms.ComboBox();
            this.cbtyperoom = new System.Windows.Forms.ComboBox();
            this.cbbuild = new System.Windows.Forms.ComboBox();
            this.cbfloor = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.cbroomnew = new System.Windows.Forms.ComboBox();
            this.cbfloornew = new System.Windows.Forms.ComboBox();
            this.cbbuildnew = new System.Windows.Forms.ComboBox();
            this.cbtroomnew = new System.Windows.Forms.ComboBox();
            this.btmove = new System.Windows.Forms.Button();
            this.btsearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvold)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvnew
            // 
            this.dgvnew.AllowUserToAddRows = false;
            this.dgvnew.AllowUserToDeleteRows = false;
            this.dgvnew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvnew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnew.Location = new System.Drawing.Point(761, 465);
            this.dgvnew.Name = "dgvnew";
            this.dgvnew.ReadOnly = true;
            this.dgvnew.RowHeadersWidth = 51;
            this.dgvnew.RowTemplate.Height = 24;
            this.dgvnew.Size = new System.Drawing.Size(697, 317);
            this.dgvnew.TabIndex = 0;
            // 
            // dgvold
            // 
            this.dgvold.AllowUserToAddRows = false;
            this.dgvold.AllowUserToDeleteRows = false;
            this.dgvold.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvold.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvold.Location = new System.Drawing.Point(761, 107);
            this.dgvold.Name = "dgvold";
            this.dgvold.ReadOnly = true;
            this.dgvold.RowHeadersWidth = 51;
            this.dgvold.RowTemplate.Height = 24;
            this.dgvold.Size = new System.Drawing.Size(697, 296);
            this.dgvold.TabIndex = 0;
            this.dgvold.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvold_CellContentClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Turquoise;
            this.label1.Location = new System.Drawing.Point(761, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(697, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "ຂໍ້ມູນຫ້ອງເກົ່າ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Turquoise;
            this.label2.Location = new System.Drawing.Point(761, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(697, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "ຂໍ້ມູນຫ້ອງທີຈະຍ້າຍ";
            // 
            // btsearchold
            // 
            this.btsearchold.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btsearchold.Image = ((System.Drawing.Image)(resources.GetObject("btsearchold.Image")));
            this.btsearchold.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btsearchold.Location = new System.Drawing.Point(573, 20);
            this.btsearchold.Name = "btsearchold";
            this.btsearchold.Size = new System.Drawing.Size(154, 62);
            this.btsearchold.TabIndex = 2;
            this.btsearchold.Text = "ຄົ້ນຫາຫ້ອງ";
            this.btsearchold.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btsearchold.UseVisualStyleBackColor = true;
            this.btsearchold.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.lbstartdate);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.lbname);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.lbenddate);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lbsurname);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lbid);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbroom);
            this.groupBox1.Controls.Add(this.cbtyperoom);
            this.groupBox1.Controls.Add(this.btsearchold);
            this.groupBox1.Controls.Add(this.cbbuild);
            this.groupBox1.Controls.Add(this.cbfloor);
            this.groupBox1.Location = new System.Drawing.Point(18, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(733, 335);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ເລືອກຫ້ອງທີຢູ່ເກົ່າ";
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(435, 55);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(54, 36);
            this.label28.TabIndex = 4;
            this.label28.Text = "ຫ້ອງ";
            // 
            // lbstartdate
            // 
            this.lbstartdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbstartdate.AutoSize = true;
            this.lbstartdate.Location = new System.Drawing.Point(353, 239);
            this.lbstartdate.Name = "lbstartdate";
            this.lbstartdate.Size = new System.Drawing.Size(98, 36);
            this.lbstartdate.TabIndex = 4;
            this.lbstartdate.Text = "ວັນເຂົ້າພັກ";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(229, 239);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 36);
            this.label8.TabIndex = 4;
            this.label8.Text = "ວັນທີເຂົ້າພັກ:";
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(307, 55);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(41, 36);
            this.label27.TabIndex = 4;
            this.label27.Text = "ຊັ້ນ";
            // 
            // lbname
            // 
            this.lbname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbname.AutoSize = true;
            this.lbname.Location = new System.Drawing.Point(88, 239);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(28, 36);
            this.lbname.TabIndex = 4;
            this.lbname.Text = "ຊື່";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 36);
            this.label5.TabIndex = 4;
            this.label5.Text = "ຊື່:";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(181, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 36);
            this.label14.TabIndex = 4;
            this.label14.Text = "ຕຶກ";
            // 
            // lbenddate
            // 
            this.lbenddate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbenddate.AutoSize = true;
            this.lbenddate.Location = new System.Drawing.Point(596, 177);
            this.lbenddate.Name = "lbenddate";
            this.lbenddate.Size = new System.Drawing.Size(120, 36);
            this.lbenddate.TabIndex = 4;
            this.lbenddate.Text = "ວັນໝົດກຳນົດ";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(456, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 36);
            this.label11.TabIndex = 4;
            this.label11.Text = "ວັນທີໝົດກຳນົດ:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 36);
            this.label12.TabIndex = 4;
            this.label12.Text = "ປະເພດຫ້ອງ";
            // 
            // lbsurname
            // 
            this.lbsurname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbsurname.AutoSize = true;
            this.lbsurname.Location = new System.Drawing.Point(353, 177);
            this.lbsurname.Name = "lbsurname";
            this.lbsurname.Size = new System.Drawing.Size(102, 36);
            this.lbsurname.TabIndex = 4;
            this.lbsurname.Text = "ນາມສະກຸນ";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(239, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 36);
            this.label7.TabIndex = 4;
            this.label7.Text = "ນາມສະກຸນ:";
            // 
            // lbid
            // 
            this.lbid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbid.AutoSize = true;
            this.lbid.Location = new System.Drawing.Point(88, 177);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(68, 36);
            this.lbid.TabIndex = 4;
            this.lbid.Text = "ລະຫັດ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "ລະຫັດ:";
            // 
            // cbroom
            // 
            this.cbroom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbroom.FormattingEnabled = true;
            this.cbroom.Location = new System.Drawing.Point(431, 94);
            this.cbroom.Name = "cbroom";
            this.cbroom.Size = new System.Drawing.Size(143, 44);
            this.cbroom.TabIndex = 3;
            this.cbroom.SelectedIndexChanged += new System.EventHandler(this.cbroom_SelectedIndexChanged);
            // 
            // cbtyperoom
            // 
            this.cbtyperoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbtyperoom.FormattingEnabled = true;
            this.cbtyperoom.Location = new System.Drawing.Point(10, 94);
            this.cbtyperoom.Name = "cbtyperoom";
            this.cbtyperoom.Size = new System.Drawing.Size(162, 44);
            this.cbtyperoom.TabIndex = 3;
            this.cbtyperoom.SelectedIndexChanged += new System.EventHandler(this.cbtroom_SelectedIndexChanged);
            // 
            // cbbuild
            // 
            this.cbbuild.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbuild.FormattingEnabled = true;
            this.cbbuild.Location = new System.Drawing.Point(177, 94);
            this.cbbuild.Name = "cbbuild";
            this.cbbuild.Size = new System.Drawing.Size(121, 44);
            this.cbbuild.TabIndex = 3;
            this.cbbuild.SelectedIndexChanged += new System.EventHandler(this.cbbuild_SelectedIndexChanged);
            // 
            // cbfloor
            // 
            this.cbfloor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbfloor.FormattingEnabled = true;
            this.cbfloor.Location = new System.Drawing.Point(304, 94);
            this.cbfloor.Name = "cbfloor";
            this.cbfloor.Size = new System.Drawing.Size(121, 44);
            this.cbfloor.TabIndex = 3;
            this.cbfloor.SelectedIndexChanged += new System.EventHandler(this.cbfloor_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.label36);
            this.groupBox2.Controls.Add(this.label35);
            this.groupBox2.Controls.Add(this.label34);
            this.groupBox2.Controls.Add(this.label33);
            this.groupBox2.Controls.Add(this.cbroomnew);
            this.groupBox2.Controls.Add(this.cbfloornew);
            this.groupBox2.Controls.Add(this.cbbuildnew);
            this.groupBox2.Controls.Add(this.cbtroomnew);
            this.groupBox2.Controls.Add(this.btmove);
            this.groupBox2.Controls.Add(this.btsearch);
            this.groupBox2.Location = new System.Drawing.Point(12, 424);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(733, 335);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ເລືອກຫ້ອງທີຈະເຂົ້າໃໝ່";
            // 
            // label36
            // 
            this.label36.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(441, 129);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(54, 36);
            this.label36.TabIndex = 4;
            this.label36.Text = "ຫ້ອງ";
            // 
            // label35
            // 
            this.label35.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(313, 129);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(41, 36);
            this.label35.TabIndex = 4;
            this.label35.Text = "ຊັ້ນ";
            // 
            // label34
            // 
            this.label34.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(187, 129);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(41, 36);
            this.label34.TabIndex = 4;
            this.label34.Text = "ຕຶກ";
            // 
            // label33
            // 
            this.label33.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(7, 129);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(115, 36);
            this.label33.TabIndex = 4;
            this.label33.Text = "ປະເພດຫ້ອງ";
            // 
            // cbroomnew
            // 
            this.cbroomnew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbroomnew.FormattingEnabled = true;
            this.cbroomnew.Location = new System.Drawing.Point(437, 168);
            this.cbroomnew.Name = "cbroomnew";
            this.cbroomnew.Size = new System.Drawing.Size(141, 44);
            this.cbroomnew.TabIndex = 3;
            this.cbroomnew.SelectedIndexChanged += new System.EventHandler(this.cbroomnew_SelectedIndexChanged);
            // 
            // cbfloornew
            // 
            this.cbfloornew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbfloornew.FormattingEnabled = true;
            this.cbfloornew.Location = new System.Drawing.Point(310, 168);
            this.cbfloornew.Name = "cbfloornew";
            this.cbfloornew.Size = new System.Drawing.Size(121, 44);
            this.cbfloornew.TabIndex = 3;
            this.cbfloornew.SelectedIndexChanged += new System.EventHandler(this.cbfloornew_SelectedIndexChanged);
            // 
            // cbbuildnew
            // 
            this.cbbuildnew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbuildnew.FormattingEnabled = true;
            this.cbbuildnew.Location = new System.Drawing.Point(183, 168);
            this.cbbuildnew.Name = "cbbuildnew";
            this.cbbuildnew.Size = new System.Drawing.Size(121, 44);
            this.cbbuildnew.TabIndex = 3;
            this.cbbuildnew.SelectedIndexChanged += new System.EventHandler(this.cbbuildnew_SelectedIndexChanged);
            // 
            // cbtroomnew
            // 
            this.cbtroomnew.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbtroomnew.FormattingEnabled = true;
            this.cbtroomnew.Location = new System.Drawing.Point(4, 168);
            this.cbtroomnew.Name = "cbtroomnew";
            this.cbtroomnew.Size = new System.Drawing.Size(172, 44);
            this.cbtroomnew.TabIndex = 3;
            this.cbtroomnew.SelectedIndexChanged += new System.EventHandler(this.cbtroomnew_SelectedIndexChanged);
            // 
            // btmove
            // 
            this.btmove.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btmove.Image = ((System.Drawing.Image)(resources.GetObject("btmove.Image")));
            this.btmove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btmove.Location = new System.Drawing.Point(581, 266);
            this.btmove.Name = "btmove";
            this.btmove.Size = new System.Drawing.Size(146, 63);
            this.btmove.TabIndex = 2;
            this.btmove.Text = "ຍ້າຍ";
            this.btmove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btmove.UseVisualStyleBackColor = true;
            this.btmove.Click += new System.EventHandler(this.btmove_Click);
            // 
            // btsearch
            // 
            this.btsearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btsearch.Image = ((System.Drawing.Image)(resources.GetObject("btsearch.Image")));
            this.btsearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btsearch.Location = new System.Drawing.Point(547, 41);
            this.btsearch.Name = "btsearch";
            this.btsearch.Size = new System.Drawing.Size(178, 63);
            this.btsearch.TabIndex = 2;
            this.btsearch.Text = "ຄົ້ນຫາຫ້ອງໃໝ່";
            this.btsearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btsearch.UseVisualStyleBackColor = true;
            this.btsearch.Click += new System.EventHandler(this.btsearch_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(1438, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 36);
            this.label4.TabIndex = 4;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Saysettha OT", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1470, 48);
            this.label6.TabIndex = 4;
            this.label6.Text = "ຍ້າຍຫ້ອງ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MoveRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1470, 810);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvold);
            this.Controls.Add(this.dgvnew);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "MoveRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoveRoom";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MoveRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvnew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvold)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvnew;
        private System.Windows.Forms.DataGridView dgvold;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btsearchold;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbstartdate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbenddate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbsurname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbroom;
        private System.Windows.Forms.ComboBox cbfloor;
        private System.Windows.Forms.ComboBox cbbuild;
        private System.Windows.Forms.ComboBox cbtyperoom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbroomnew;
        private System.Windows.Forms.ComboBox cbfloornew;
        private System.Windows.Forms.ComboBox cbbuildnew;
        private System.Windows.Forms.ComboBox cbtroomnew;
        private System.Windows.Forms.Button btsearch;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Button btmove;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}