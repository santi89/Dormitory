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
            this.dgvpayment = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtstname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtstid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcost = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbbuilding = new System.Windows.Forms.ComboBox();
            this.cbfloor = new System.Windows.Forms.ComboBox();
            this.cbroom = new System.Windows.Forms.ComboBox();
            this.startdate = new System.Windows.Forms.DateTimePicker();
            this.enddate = new System.Windows.Forms.DateTimePicker();
            this.rbnewadd = new System.Windows.Forms.RadioButton();
            this.rbcontinues = new System.Windows.Forms.RadioButton();
            this.cbtroom = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpayment)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvpayment
            // 
            this.dgvpayment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpayment.Location = new System.Drawing.Point(13, 128);
            this.dgvpayment.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.dgvpayment.Name = "dgvpayment";
            this.dgvpayment.RowHeadersWidth = 51;
            this.dgvpayment.RowTemplate.Height = 24;
            this.dgvpayment.Size = new System.Drawing.Size(746, 511);
            this.dgvpayment.TabIndex = 0;
            this.dgvpayment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvpayment_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(503, 63);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "ຄົ້ນຫາ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(110, 67);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txtsearch.Multiline = true;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(366, 46);
            this.txtsearch.TabIndex = 2;
            this.txtsearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "ຄົ້ນຫາ";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(941, 12);
            this.txtid.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txtid.Multiline = true;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(206, 47);
            this.txtid.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(772, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "ລະຫັດການຊຳລະ";
            // 
            // txtstname
            // 
            this.txtstname.Location = new System.Drawing.Point(941, 126);
            this.txtstname.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txtstname.Multiline = true;
            this.txtstname.Name = "txtstname";
            this.txtstname.Size = new System.Drawing.Size(206, 44);
            this.txtstname.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(781, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "ຊື່ນັກສຶກສາ";
            // 
            // txtstid
            // 
            this.txtstid.Location = new System.Drawing.Point(941, 73);
            this.txtstid.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txtstid.Multiline = true;
            this.txtstid.Name = "txtstid";
            this.txtstid.Size = new System.Drawing.Size(206, 39);
            this.txtstid.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(772, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "ລະຫັດນັກສຶກສາ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(792, 620);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 52);
            this.button2.TabIndex = 1;
            this.button2.Text = "ບັນທຶກການຈ່າຍ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(969, 620);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 52);
            this.button3.TabIndex = 1;
            this.button3.Text = "ກັບໜ້າເພີມ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(781, 385);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 36);
            this.label5.TabIndex = 3;
            this.label5.Text = "ເຂົ້າພັກຫ້ອງ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(781, 447);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 36);
            this.label6.TabIndex = 3;
            this.label6.Text = "ວັນທີເລີມເຂົ້າ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(776, 500);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 36);
            this.label7.TabIndex = 3;
            this.label7.Text = "ວັນທີໝົດກຳໜົດ";
            // 
            // txtcost
            // 
            this.txtcost.Enabled = false;
            this.txtcost.Location = new System.Drawing.Point(941, 550);
            this.txtcost.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txtcost.Multiline = true;
            this.txtcost.Name = "txtcost";
            this.txtcost.Size = new System.Drawing.Size(206, 39);
            this.txtcost.TabIndex = 2;
            this.txtcost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtcost.TextChanged += new System.EventHandler(this.txtcost_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(781, 553);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 36);
            this.label8.TabIndex = 3;
            this.label8.Text = "ເປັນເງິນ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(786, 331);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 36);
            this.label9.TabIndex = 3;
            this.label9.Text = "ຊັ້ນ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(781, 269);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 36);
            this.label10.TabIndex = 3;
            this.label10.Text = "ຕຶກ";
            // 
            // cbbuilding
            // 
            this.cbbuilding.FormattingEnabled = true;
            this.cbbuilding.Location = new System.Drawing.Point(941, 269);
            this.cbbuilding.Name = "cbbuilding";
            this.cbbuilding.Size = new System.Drawing.Size(206, 44);
            this.cbbuilding.TabIndex = 4;
            this.cbbuilding.SelectedIndexChanged += new System.EventHandler(this.cbbuilding_SelectedIndexChanged);
            // 
            // cbfloor
            // 
            this.cbfloor.FormattingEnabled = true;
            this.cbfloor.Location = new System.Drawing.Point(941, 323);
            this.cbfloor.Name = "cbfloor";
            this.cbfloor.Size = new System.Drawing.Size(206, 44);
            this.cbfloor.TabIndex = 4;
            this.cbfloor.SelectedIndexChanged += new System.EventHandler(this.cbfloor_SelectedIndexChanged);
            // 
            // cbroom
            // 
            this.cbroom.FormattingEnabled = true;
            this.cbroom.Location = new System.Drawing.Point(941, 381);
            this.cbroom.Name = "cbroom";
            this.cbroom.Size = new System.Drawing.Size(206, 44);
            this.cbroom.TabIndex = 4;
            this.cbroom.SelectedIndexChanged += new System.EventHandler(this.cbroom_SelectedIndexChanged);
            // 
            // startdate
            // 
            this.startdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startdate.Location = new System.Drawing.Point(941, 447);
            this.startdate.Name = "startdate";
            this.startdate.Size = new System.Drawing.Size(206, 42);
            this.startdate.TabIndex = 5;
            this.startdate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // enddate
            // 
            this.enddate.Enabled = false;
            this.enddate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.enddate.Location = new System.Drawing.Point(941, 495);
            this.enddate.Name = "enddate";
            this.enddate.Size = new System.Drawing.Size(206, 42);
            this.enddate.TabIndex = 5;
            // 
            // rbnewadd
            // 
            this.rbnewadd.AutoSize = true;
            this.rbnewadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rbnewadd.FlatAppearance.BorderColor = System.Drawing.Color.HotPink;
            this.rbnewadd.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.rbnewadd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rbnewadd.Location = new System.Drawing.Point(110, 11);
            this.rbnewadd.Name = "rbnewadd";
            this.rbnewadd.Size = new System.Drawing.Size(149, 40);
            this.rbnewadd.TabIndex = 6;
            this.rbnewadd.TabStop = true;
            this.rbnewadd.Text = "ລົງທະບຽນໃໝ່";
            this.rbnewadd.UseVisualStyleBackColor = false;
            this.rbnewadd.CheckedChanged += new System.EventHandler(this.rbnewadd_CheckedChanged);
            // 
            // rbcontinues
            // 
            this.rbcontinues.AutoSize = true;
            this.rbcontinues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rbcontinues.FlatAppearance.BorderColor = System.Drawing.Color.HotPink;
            this.rbcontinues.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.rbcontinues.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.rbcontinues.Location = new System.Drawing.Point(400, 11);
            this.rbcontinues.Name = "rbcontinues";
            this.rbcontinues.Size = new System.Drawing.Size(76, 40);
            this.rbcontinues.TabIndex = 6;
            this.rbcontinues.TabStop = true;
            this.rbcontinues.Text = "ຕໍ່ບັດ";
            this.rbcontinues.UseVisualStyleBackColor = false;
            this.rbcontinues.CheckedChanged += new System.EventHandler(this.rbcontinues_CheckedChanged);
            // 
            // cbtroom
            // 
            this.cbtroom.FormattingEnabled = true;
            this.cbtroom.Location = new System.Drawing.Point(941, 195);
            this.cbtroom.Name = "cbtroom";
            this.cbtroom.Size = new System.Drawing.Size(206, 44);
            this.cbtroom.TabIndex = 7;
            this.cbtroom.SelectedIndexChanged += new System.EventHandler(this.cbtroom_SelectedIndexChanged);
            this.cbtroom.TextUpdate += new System.EventHandler(this.cbtroom_TextUpdate);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(776, 203);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 36);
            this.label11.TabIndex = 3;
            this.label11.Text = "ປະເພດຫ້ອງ";
            // 
            // payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(208)))), ((int)(((byte)(203)))));
            this.ClientSize = new System.Drawing.Size(1202, 681);
            this.Controls.Add(this.cbtroom);
            this.Controls.Add(this.rbcontinues);
            this.Controls.Add(this.rbnewadd);
            this.Controls.Add(this.enddate);
            this.Controls.Add(this.startdate);
            this.Controls.Add(this.cbroom);
            this.Controls.Add(this.cbfloor);
            this.Controls.Add(this.cbbuilding);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcost);
            this.Controls.Add(this.txtstid);
            this.Controls.Add(this.txtstname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvpayment);
            this.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "payment";
            this.Text = "payment";
            this.Load += new System.EventHandler(this.payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvpayment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvpayment;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtstname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtstid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtcost;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbbuilding;
        private System.Windows.Forms.ComboBox cbfloor;
        private System.Windows.Forms.ComboBox cbroom;
        private System.Windows.Forms.DateTimePicker startdate;
        private System.Windows.Forms.DateTimePicker enddate;
        private System.Windows.Forms.RadioButton rbnewadd;
        private System.Windows.Forms.RadioButton rbcontinues;
        private System.Windows.Forms.ComboBox cbtroom;
        private System.Windows.Forms.Label label11;
    }
}