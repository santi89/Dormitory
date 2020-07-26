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
            this.g2 = new System.Windows.Forms.GroupBox();
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
            this.txtdepname = new System.Windows.Forms.TextBox();
            this.g3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.cbdepart = new System.Windows.Forms.ComboBox();
            this.btddelete = new System.Windows.Forms.Button();
            this.dgvdepartment = new System.Windows.Forms.DataGridView();
            this.txtdepID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btdedit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btdsave = new System.Windows.Forms.Button();
            this.g1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.dgvschool = new System.Windows.Forms.DataGridView();
            this.txtschoolID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btsedit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnameschool = new System.Windows.Forms.TextBox();
            this.btssave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.g2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfaculty)).BeginInit();
            this.g3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdepartment)).BeginInit();
            this.g1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvschool)).BeginInit();
            this.SuspendLayout();
            // 
            // g2
            // 
            this.g2.Controls.Add(this.button2);
            this.g2.Controls.Add(this.cbschool);
            this.g2.Controls.Add(this.btfdelete);
            this.g2.Controls.Add(this.dgvfaculty);
            this.g2.Controls.Add(this.txtfacID);
            this.g2.Controls.Add(this.label14);
            this.g2.Controls.Add(this.btfedit);
            this.g2.Controls.Add(this.label19);
            this.g2.Controls.Add(this.label16);
            this.g2.Controls.Add(this.btfsave);
            this.g2.Controls.Add(this.txtfacname);
            this.g2.Location = new System.Drawing.Point(792, 89);
            this.g2.Name = "g2";
            this.g2.Size = new System.Drawing.Size(408, 618);
            this.g2.TabIndex = 28;
            this.g2.TabStop = false;
            this.g2.Text = "ຈັດການຂໍ້ມູນຄະນະ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(292, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 43);
            this.button2.TabIndex = 29;
            this.button2.Text = "ຍົກເລີກ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbschool
            // 
            this.cbschool.FormattingEnabled = true;
            this.cbschool.Location = new System.Drawing.Point(154, 170);
            this.cbschool.Name = "cbschool";
            this.cbschool.Size = new System.Drawing.Size(205, 44);
            this.cbschool.TabIndex = 29;
            this.cbschool.SelectedIndexChanged += new System.EventHandler(this.cbschool_SelectedIndexChanged);
            // 
            // btfdelete
            // 
            this.btfdelete.Location = new System.Drawing.Point(205, 233);
            this.btfdelete.Name = "btfdelete";
            this.btfdelete.Size = new System.Drawing.Size(81, 42);
            this.btfdelete.TabIndex = 28;
            this.btfdelete.Text = "ລຶບ";
            this.btfdelete.UseVisualStyleBackColor = true;
            this.btfdelete.Click += new System.EventHandler(this.btfdelete_Click);
            // 
            // dgvfaculty
            // 
            this.dgvfaculty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfaculty.Location = new System.Drawing.Point(6, 309);
            this.dgvfaculty.Name = "dgvfaculty";
            this.dgvfaculty.RowHeadersWidth = 51;
            this.dgvfaculty.RowTemplate.Height = 24;
            this.dgvfaculty.Size = new System.Drawing.Size(393, 303);
            this.dgvfaculty.TabIndex = 27;
            this.dgvfaculty.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvfaculty_CellContentClick);
            // 
            // txtfacID
            // 
            this.txtfacID.Enabled = false;
            this.txtfacID.Location = new System.Drawing.Point(155, 56);
            this.txtfacID.Name = "txtfacID";
            this.txtfacID.Size = new System.Drawing.Size(204, 42);
            this.txtfacID.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 59);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 36);
            this.label14.TabIndex = 17;
            this.label14.Text = "ລະຫັດຄະນະ";
            // 
            // btfedit
            // 
            this.btfedit.Location = new System.Drawing.Point(118, 233);
            this.btfedit.Name = "btfedit";
            this.btfedit.Size = new System.Drawing.Size(81, 42);
            this.btfedit.TabIndex = 28;
            this.btfedit.Text = "ແກ້ໄຂ";
            this.btfedit.UseVisualStyleBackColor = true;
            this.btfedit.Click += new System.EventHandler(this.btfedit_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(52, 173);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(82, 36);
            this.label19.TabIndex = 19;
            this.label19.Text = "ໂຮງຮຽນ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(56, 116);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 36);
            this.label16.TabIndex = 19;
            this.label16.Text = "ຊື່ຄະນະ";
            // 
            // btfsave
            // 
            this.btfsave.Location = new System.Drawing.Point(31, 233);
            this.btfsave.Name = "btfsave";
            this.btfsave.Size = new System.Drawing.Size(81, 42);
            this.btfsave.TabIndex = 28;
            this.btfsave.Text = "ບັນທຶກ";
            this.btfsave.UseVisualStyleBackColor = true;
            this.btfsave.Click += new System.EventHandler(this.btfsave_Click);
            // 
            // txtfacname
            // 
            this.txtfacname.Location = new System.Drawing.Point(155, 110);
            this.txtfacname.Name = "txtfacname";
            this.txtfacname.Size = new System.Drawing.Size(204, 42);
            this.txtfacname.TabIndex = 20;
            // 
            // txtdepname
            // 
            this.txtdepname.Location = new System.Drawing.Point(141, 94);
            this.txtdepname.Name = "txtdepname";
            this.txtdepname.Size = new System.Drawing.Size(204, 42);
            this.txtdepname.TabIndex = 20;
            // 
            // g3
            // 
            this.g3.Controls.Add(this.button3);
            this.g3.Controls.Add(this.cbdepart);
            this.g3.Controls.Add(this.btddelete);
            this.g3.Controls.Add(this.dgvdepartment);
            this.g3.Controls.Add(this.txtdepID);
            this.g3.Controls.Add(this.label4);
            this.g3.Controls.Add(this.btdedit);
            this.g3.Controls.Add(this.label3);
            this.g3.Controls.Add(this.label11);
            this.g3.Controls.Add(this.txtdepname);
            this.g3.Controls.Add(this.btdsave);
            this.g3.Location = new System.Drawing.Point(12, 402);
            this.g3.Name = "g3";
            this.g3.Size = new System.Drawing.Size(763, 315);
            this.g3.TabIndex = 29;
            this.g3.TabStop = false;
            this.g3.Text = "ຈັດການຂໍ້ມູນພາກ";
            this.g3.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(263, 219);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 43);
            this.button3.TabIndex = 29;
            this.button3.Text = "ຍົກເລີກ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cbdepart
            // 
            this.cbdepart.FormattingEnabled = true;
            this.cbdepart.Location = new System.Drawing.Point(141, 152);
            this.cbdepart.Name = "cbdepart";
            this.cbdepart.Size = new System.Drawing.Size(204, 44);
            this.cbdepart.TabIndex = 29;
            // 
            // btddelete
            // 
            this.btddelete.Location = new System.Drawing.Point(176, 219);
            this.btddelete.Name = "btddelete";
            this.btddelete.Size = new System.Drawing.Size(81, 42);
            this.btddelete.TabIndex = 28;
            this.btddelete.Text = "ລຶບ";
            this.btddelete.UseVisualStyleBackColor = true;
            this.btddelete.Click += new System.EventHandler(this.btddelete_Click);
            // 
            // dgvdepartment
            // 
            this.dgvdepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdepartment.Location = new System.Drawing.Point(368, 44);
            this.dgvdepartment.Name = "dgvdepartment";
            this.dgvdepartment.RowHeadersWidth = 51;
            this.dgvdepartment.RowTemplate.Height = 24;
            this.dgvdepartment.Size = new System.Drawing.Size(378, 265);
            this.dgvdepartment.TabIndex = 27;
            this.dgvdepartment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdepartment_CellContentClick);
            // 
            // txtdepID
            // 
            this.txtdepID.Enabled = false;
            this.txtdepID.Location = new System.Drawing.Point(141, 44);
            this.txtdepID.Name = "txtdepID";
            this.txtdepID.Size = new System.Drawing.Size(204, 42);
            this.txtdepID.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 36);
            this.label4.TabIndex = 17;
            this.label4.Text = "ລະຫັດພາກ";
            // 
            // btdedit
            // 
            this.btdedit.Location = new System.Drawing.Point(92, 219);
            this.btdedit.Name = "btdedit";
            this.btdedit.Size = new System.Drawing.Size(81, 42);
            this.btdedit.TabIndex = 28;
            this.btdedit.Text = "ແກ້ໄຂ";
            this.btdedit.UseVisualStyleBackColor = true;
            this.btdedit.Click += new System.EventHandler(this.btdedit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 36);
            this.label3.TabIndex = 19;
            this.label3.Text = "ຄະນະ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(53, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 36);
            this.label11.TabIndex = 19;
            this.label11.Text = "ຊື່ພາກ";
            // 
            // btdsave
            // 
            this.btdsave.Location = new System.Drawing.Point(5, 219);
            this.btdsave.Name = "btdsave";
            this.btdsave.Size = new System.Drawing.Size(81, 42);
            this.btdsave.TabIndex = 28;
            this.btdsave.Text = "ບັນທຶກ";
            this.btdsave.UseVisualStyleBackColor = true;
            this.btdsave.Click += new System.EventHandler(this.btdsave_Click);
            // 
            // g1
            // 
            this.g1.Controls.Add(this.button1);
            this.g1.Controls.Add(this.btdelete);
            this.g1.Controls.Add(this.dgvschool);
            this.g1.Controls.Add(this.txtschoolID);
            this.g1.Controls.Add(this.label1);
            this.g1.Controls.Add(this.btsedit);
            this.g1.Controls.Add(this.label2);
            this.g1.Controls.Add(this.txtnameschool);
            this.g1.Controls.Add(this.btssave);
            this.g1.Location = new System.Drawing.Point(12, 89);
            this.g1.Name = "g1";
            this.g1.Size = new System.Drawing.Size(763, 300);
            this.g1.TabIndex = 29;
            this.g1.TabStop = false;
            this.g1.Text = "ຈັດການຂໍ້ມູນສະຖາບັນ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(225, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 43);
            this.button1.TabIndex = 29;
            this.button1.Text = "ຍົກເລີກ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btdelete
            // 
            this.btdelete.Location = new System.Drawing.Point(225, 159);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(99, 42);
            this.btdelete.TabIndex = 28;
            this.btdelete.Text = "ລຶບ";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // dgvschool
            // 
            this.dgvschool.AllowUserToAddRows = false;
            this.dgvschool.AllowUserToDeleteRows = false;
            this.dgvschool.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvschool.Location = new System.Drawing.Point(351, 27);
            this.dgvschool.Name = "dgvschool";
            this.dgvschool.ReadOnly = true;
            this.dgvschool.RowHeadersWidth = 51;
            this.dgvschool.RowTemplate.Height = 24;
            this.dgvschool.Size = new System.Drawing.Size(406, 233);
            this.dgvschool.TabIndex = 27;
            this.dgvschool.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvschool_CellContentClick);
            // 
            // txtschoolID
            // 
            this.txtschoolID.Enabled = false;
            this.txtschoolID.Location = new System.Drawing.Point(176, 44);
            this.txtschoolID.Name = "txtschoolID";
            this.txtschoolID.Size = new System.Drawing.Size(169, 42);
            this.txtschoolID.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 36);
            this.label1.TabIndex = 17;
            this.label1.Text = "ລະຫັດໂຮງຮຽນ";
            // 
            // btsedit
            // 
            this.btsedit.Location = new System.Drawing.Point(72, 219);
            this.btsedit.Name = "btsedit";
            this.btsedit.Size = new System.Drawing.Size(114, 42);
            this.btsedit.TabIndex = 28;
            this.btsedit.Text = "ແກ້ໄຂ";
            this.btsedit.UseVisualStyleBackColor = true;
            this.btsedit.Click += new System.EventHandler(this.btsedit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 36);
            this.label2.TabIndex = 19;
            this.label2.Text = "ຊື່ໂຮງຮຽນ";
            // 
            // txtnameschool
            // 
            this.txtnameschool.Location = new System.Drawing.Point(176, 101);
            this.txtnameschool.Name = "txtnameschool";
            this.txtnameschool.Size = new System.Drawing.Size(169, 42);
            this.txtnameschool.TabIndex = 20;
            // 
            // btssave
            // 
            this.btssave.Location = new System.Drawing.Point(72, 159);
            this.btssave.Name = "btssave";
            this.btssave.Size = new System.Drawing.Size(114, 42);
            this.btssave.TabIndex = 28;
            this.btssave.Text = "ບັນທຶກ";
            this.btssave.UseVisualStyleBackColor = true;
            this.btssave.Click += new System.EventHandler(this.btssave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(1236, -3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 36);
            this.label5.TabIndex = 19;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 36);
            this.label6.TabIndex = 17;
            this.label6.Text = "ກະລຸນາເລືອກລາຍການ=>";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(286, 25);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(211, 40);
            this.radioButton1.TabIndex = 30;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "ຈັດການຂໍ້ມູນສະຖາບັນ";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(515, 25);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(186, 40);
            this.radioButton2.TabIndex = 30;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "ຈັດການຂໍ້ມູນຄະນະ";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.Color.White;
            this.radioButton3.Location = new System.Drawing.Point(717, 25);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(174, 40);
            this.radioButton3.TabIndex = 30;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "ຈັດການຂໍ້ມູນພາກ";
            this.radioButton3.UseVisualStyleBackColor = false;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.BackColor = System.Drawing.Color.White;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(910, 25);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(205, 40);
            this.radioButton4.TabIndex = 30;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "ບໍ່ເລືອກລາຍການໃດໆ";
            this.radioButton4.UseVisualStyleBackColor = false;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // study
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(208)))), ((int)(((byte)(203)))));
            this.ClientSize = new System.Drawing.Size(1262, 726);
            this.ControlBox = false;
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.g2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.g1);
            this.Controls.Add(this.g3);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "study";
            this.Text = "study";
            this.Load += new System.EventHandler(this.study_Load);
            this.g2.ResumeLayout(false);
            this.g2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfaculty)).EndInit();
            this.g3.ResumeLayout(false);
            this.g3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdepartment)).EndInit();
            this.g1.ResumeLayout(false);
            this.g1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvschool)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox g2;
        private System.Windows.Forms.Button btfdelete;
        private System.Windows.Forms.DataGridView dgvfaculty;
        private System.Windows.Forms.TextBox txtfacID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btfedit;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtdepname;
        private System.Windows.Forms.Button btfsave;
        private System.Windows.Forms.GroupBox g3;
        private System.Windows.Forms.Button btddelete;
        private System.Windows.Forms.DataGridView dgvdepartment;
        private System.Windows.Forms.TextBox txtdepID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btdedit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtfacname;
        private System.Windows.Forms.Button btdsave;
        private System.Windows.Forms.GroupBox g1;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.DataGridView dgvschool;
        private System.Windows.Forms.TextBox txtschoolID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btsedit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnameschool;
        private System.Windows.Forms.Button btssave;
        private System.Windows.Forms.ComboBox cbschool;
        private System.Windows.Forms.ComboBox cbdepart;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
    }
}