namespace C_Sharp_2_Project
{
    partial class payment
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.datesearch = new System.Windows.Forms.DateTimePicker();
            this.cbtroom = new System.Windows.Forms.ComboBox();
            this.rbcontinues = new System.Windows.Forms.RadioButton();
            this.rbnewadd = new System.Windows.Forms.RadioButton();
            this.enddate = new System.Windows.Forms.DateTimePicker();
            this.startdate = new System.Windows.Forms.DateTimePicker();
            this.cbroom = new System.Windows.Forms.ComboBox();
            this.cbfloor = new System.Windows.Forms.ComboBox();
            this.cbbuilding = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcost = new System.Windows.Forms.TextBox();
            this.txtstid = new System.Windows.Forms.TextBox();
            this.txtstname = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvpayment = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpayment)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.datesearch);
            this.panel1.Controls.Add(this.cbtroom);
            this.panel1.Controls.Add(this.rbcontinues);
            this.panel1.Controls.Add(this.rbnewadd);
            this.panel1.Controls.Add(this.enddate);
            this.panel1.Controls.Add(this.startdate);
            this.panel1.Controls.Add(this.cbroom);
            this.panel1.Controls.Add(this.cbfloor);
            this.panel1.Controls.Add(this.cbbuilding);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtcost);
            this.panel1.Controls.Add(this.txtstid);
            this.panel1.Controls.Add(this.txtstname);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.txtsearch);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dgvpayment);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1425, 797);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // datesearch
            // 
            this.datesearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.datesearch.CustomFormat = "yyyy-MM-dd";
            this.datesearch.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datesearch.Location = new System.Drawing.Point(85, 105);
            this.datesearch.Name = "datesearch";
            this.datesearch.Size = new System.Drawing.Size(218, 42);
            this.datesearch.TabIndex = 37;
            this.datesearch.ValueChanged += new System.EventHandler(this.datesearch_ValueChanged);
            // 
            // cbtroom
            // 
            this.cbtroom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbtroom.FormattingEnabled = true;
            this.cbtroom.Location = new System.Drawing.Point(1207, 288);
            this.cbtroom.Name = "cbtroom";
            this.cbtroom.Size = new System.Drawing.Size(206, 44);
            this.cbtroom.TabIndex = 36;
            this.cbtroom.SelectedIndexChanged += new System.EventHandler(this.cbtroom_SelectedIndexChanged_1);
            // 
            // rbcontinues
            // 
            this.rbcontinues.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbcontinues.AutoSize = true;
            this.rbcontinues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(208)))), ((int)(((byte)(203)))));
            this.rbcontinues.FlatAppearance.BorderColor = System.Drawing.Color.HotPink;
            this.rbcontinues.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.rbcontinues.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rbcontinues.Location = new System.Drawing.Point(574, 31);
            this.rbcontinues.Name = "rbcontinues";
            this.rbcontinues.Size = new System.Drawing.Size(76, 40);
            this.rbcontinues.TabIndex = 35;
            this.rbcontinues.TabStop = true;
            this.rbcontinues.Text = "ຕໍ່ບັດ";
            this.rbcontinues.UseVisualStyleBackColor = false;
            this.rbcontinues.CheckedChanged += new System.EventHandler(this.rbcontinues_CheckedChanged_1);
            // 
            // rbnewadd
            // 
            this.rbnewadd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbnewadd.AutoSize = true;
            this.rbnewadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(208)))), ((int)(((byte)(203)))));
            this.rbnewadd.FlatAppearance.BorderColor = System.Drawing.Color.HotPink;
            this.rbnewadd.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.rbnewadd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rbnewadd.Location = new System.Drawing.Point(56, 31);
            this.rbnewadd.Name = "rbnewadd";
            this.rbnewadd.Size = new System.Drawing.Size(149, 40);
            this.rbnewadd.TabIndex = 34;
            this.rbnewadd.TabStop = true;
            this.rbnewadd.Text = "ລົງທະບຽນໃໝ່";
            this.rbnewadd.UseVisualStyleBackColor = false;
            this.rbnewadd.CheckedChanged += new System.EventHandler(this.rbnewadd_CheckedChanged_1);
            // 
            // enddate
            // 
            this.enddate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.enddate.Enabled = false;
            this.enddate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.enddate.Location = new System.Drawing.Point(1207, 564);
            this.enddate.Name = "enddate";
            this.enddate.Size = new System.Drawing.Size(206, 42);
            this.enddate.TabIndex = 33;
            // 
            // startdate
            // 
            this.startdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startdate.Location = new System.Drawing.Point(1207, 510);
            this.startdate.Name = "startdate";
            this.startdate.Size = new System.Drawing.Size(206, 42);
            this.startdate.TabIndex = 32;
            this.startdate.ValueChanged += new System.EventHandler(this.startdate_ValueChanged);
            // 
            // cbroom
            // 
            this.cbroom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbroom.FormattingEnabled = true;
            this.cbroom.Location = new System.Drawing.Point(1207, 450);
            this.cbroom.Name = "cbroom";
            this.cbroom.Size = new System.Drawing.Size(206, 44);
            this.cbroom.TabIndex = 31;
            this.cbroom.SelectedIndexChanged += new System.EventHandler(this.cbroom_SelectedIndexChanged_1);
            // 
            // cbfloor
            // 
            this.cbfloor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbfloor.FormattingEnabled = true;
            this.cbfloor.Location = new System.Drawing.Point(1207, 392);
            this.cbfloor.Name = "cbfloor";
            this.cbfloor.Size = new System.Drawing.Size(206, 44);
            this.cbfloor.TabIndex = 30;
            this.cbfloor.SelectedIndexChanged += new System.EventHandler(this.cbfloor_SelectedIndexChanged_1);
            // 
            // cbbuilding
            // 
            this.cbbuilding.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbuilding.FormattingEnabled = true;
            this.cbbuilding.Location = new System.Drawing.Point(1207, 338);
            this.cbbuilding.Name = "cbbuilding";
            this.cbbuilding.Size = new System.Drawing.Size(206, 44);
            this.cbbuilding.TabIndex = 29;
            this.cbbuilding.SelectedIndexChanged += new System.EventHandler(this.cbbuilding_SelectedIndexChanged_1);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1098, 622);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 36);
            this.label8.TabIndex = 27;
            this.label8.Text = "ເປັນເງິນ";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1039, 564);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 36);
            this.label7.TabIndex = 26;
            this.label7.Text = "ວັນທີໝົດກຳໜົດ";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1061, 516);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 36);
            this.label6.TabIndex = 25;
            this.label6.Text = "ວັນທີເລີມເຂົ້າ";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1063, 288);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 36);
            this.label11.TabIndex = 24;
            this.label11.Text = "ປະເພດຫ້ອງ";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1137, 338);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 36);
            this.label10.TabIndex = 23;
            this.label10.Text = "ຕຶກ";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1137, 395);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 36);
            this.label9.TabIndex = 28;
            this.label9.Text = "ຊັ້ນ";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1064, 450);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 36);
            this.label5.TabIndex = 22;
            this.label5.Text = "ເຂົ້າພັກຫ້ອງ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1033, 173);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 36);
            this.label4.TabIndex = 21;
            this.label4.Text = "ລະຫັດນັກສຶກສາ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1075, 226);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 36);
            this.label3.TabIndex = 20;
            this.label3.Text = "ຊື່ນັກສຶກສາ";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(1397, 0);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 36);
            this.label12.TabIndex = 19;
            this.label12.Text = "X";
            this.label12.Click += new System.EventHandler(this.label12_Click_1);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1026, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 36);
            this.label2.TabIndex = 18;
            this.label2.Text = "ລະຫັດການຊຳລະ";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 110);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 36);
            this.label13.TabIndex = 17;
            this.label13.Text = "ວັນທີ";
            this.label13.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(487, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 36);
            this.label1.TabIndex = 17;
            this.label1.Text = "ຄົ້ນຫາຊື່";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtcost
            // 
            this.txtcost.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtcost.Enabled = false;
            this.txtcost.Location = new System.Drawing.Point(1207, 619);
            this.txtcost.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txtcost.Multiline = true;
            this.txtcost.Name = "txtcost";
            this.txtcost.Size = new System.Drawing.Size(206, 39);
            this.txtcost.TabIndex = 16;
            this.txtcost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtcost.TextChanged += new System.EventHandler(this.txtcost_TextChanged_1);
            // 
            // txtstid
            // 
            this.txtstid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtstid.Location = new System.Drawing.Point(1207, 173);
            this.txtstid.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txtstid.Multiline = true;
            this.txtstid.Name = "txtstid";
            this.txtstid.Size = new System.Drawing.Size(206, 39);
            this.txtstid.TabIndex = 15;
            // 
            // txtstname
            // 
            this.txtstname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtstname.Location = new System.Drawing.Point(1207, 226);
            this.txtstname.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txtstname.Multiline = true;
            this.txtstname.Name = "txtstname";
            this.txtstname.Size = new System.Drawing.Size(206, 44);
            this.txtstname.TabIndex = 14;
            // 
            // txtid
            // 
            this.txtid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(1207, 107);
            this.txtid.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txtid.Multiline = true;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(206, 47);
            this.txtid.TabIndex = 13;
            // 
            // txtsearch
            // 
            this.txtsearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtsearch.Enabled = false;
            this.txtsearch.Location = new System.Drawing.Point(574, 112);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(169, 42);
            this.txtsearch.TabIndex = 12;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Location = new System.Drawing.Point(1235, 689);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 52);
            this.button3.TabIndex = 10;
            this.button3.Text = "ClearText";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(1058, 689);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 52);
            this.button2.TabIndex = 9;
            this.button2.Text = "ບັນທຶກການຈ່າຍ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(855, 105);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 51);
            this.button1.TabIndex = 11;
            this.button1.Text = "ຄົ້ນຫາ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dgvpayment
            // 
            this.dgvpayment.AllowUserToAddRows = false;
            this.dgvpayment.AllowUserToDeleteRows = false;
            this.dgvpayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvpayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpayment.Location = new System.Drawing.Point(30, 198);
            this.dgvpayment.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.dgvpayment.Name = "dgvpayment";
            this.dgvpayment.ReadOnly = true;
            this.dgvpayment.RowHeadersWidth = 51;
            this.dgvpayment.RowTemplate.Height = 24;
            this.dgvpayment.Size = new System.Drawing.Size(971, 511);
            this.dgvpayment.TabIndex = 8;
            this.dgvpayment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpayment_CellContentClick_1);
            // 
            // payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(208)))), ((int)(((byte)(203)))));
            this.ClientSize = new System.Drawing.Size(1425, 797);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "payment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "payment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.payment_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpayment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbtroom;
        private System.Windows.Forms.RadioButton rbcontinues;
        private System.Windows.Forms.RadioButton rbnewadd;
        private System.Windows.Forms.DateTimePicker enddate;
        private System.Windows.Forms.DateTimePicker startdate;
        private System.Windows.Forms.ComboBox cbroom;
        private System.Windows.Forms.ComboBox cbfloor;
        private System.Windows.Forms.ComboBox cbbuilding;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcost;
        private System.Windows.Forms.TextBox txtstid;
        private System.Windows.Forms.TextBox txtstname;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvpayment;
        private System.Windows.Forms.DateTimePicker datesearch;
        private System.Windows.Forms.Label label13;
    }
}