namespace C_Sharp_2_Project
{
    partial class employee
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtdateTime = new System.Windows.Forms.DateTimePicker();
            this.btsearch = new System.Windows.Forms.Button();
            this.btdelete = new System.Windows.Forms.Button();
            this.btedit = new System.Windows.Forms.Button();
            this.btsave = new System.Windows.Forms.Button();
            this.rbfemale = new System.Windows.Forms.RadioButton();
            this.rbmale = new System.Windows.Forms.RadioButton();
            this.dgvemp = new System.Windows.Forms.DataGridView();
            this.txtsurname = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.txtempID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvemp)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(208)))), ((int)(((byte)(203)))));
            this.groupBox1.Controls.Add(this.txtdateTime);
            this.groupBox1.Controls.Add(this.btsearch);
            this.groupBox1.Controls.Add(this.btdelete);
            this.groupBox1.Controls.Add(this.btedit);
            this.groupBox1.Controls.Add(this.btsave);
            this.groupBox1.Controls.Add(this.rbfemale);
            this.groupBox1.Controls.Add(this.rbmale);
            this.groupBox1.Controls.Add(this.dgvemp);
            this.groupBox1.Controls.Add(this.txtsurname);
            this.groupBox1.Controls.Add(this.txtemail);
            this.groupBox1.Controls.Add(this.txtaddress);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtpassword);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txttel);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtsearch);
            this.groupBox1.Controls.Add(this.txtempID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.groupBox1.Size = new System.Drawing.Size(1406, 623);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // txtdateTime
            // 
            this.txtdateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtdateTime.Location = new System.Drawing.Point(158, 345);
            this.txtdateTime.Name = "txtdateTime";
            this.txtdateTime.Size = new System.Drawing.Size(213, 35);
            this.txtdateTime.TabIndex = 41;
            // 
            // btsearch
            // 
            this.btsearch.Location = new System.Drawing.Point(905, 95);
            this.btsearch.Name = "btsearch";
            this.btsearch.Size = new System.Drawing.Size(181, 47);
            this.btsearch.TabIndex = 40;
            this.btsearch.Text = "ຄົ້ນຫາ";
            this.btsearch.UseVisualStyleBackColor = true;
            this.btsearch.Click += new System.EventHandler(this.btsearch_Click);
            // 
            // btdelete
            // 
            this.btdelete.Location = new System.Drawing.Point(905, 29);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(181, 47);
            this.btdelete.TabIndex = 40;
            this.btdelete.Text = "ລືບ";
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // btedit
            // 
            this.btedit.Location = new System.Drawing.Point(696, 30);
            this.btedit.Name = "btedit";
            this.btedit.Size = new System.Drawing.Size(181, 47);
            this.btedit.TabIndex = 40;
            this.btedit.Text = "ແກ້ໄຂ";
            this.btedit.UseVisualStyleBackColor = true;
            this.btedit.Click += new System.EventHandler(this.btedit_Click);
            // 
            // btsave
            // 
            this.btsave.Location = new System.Drawing.Point(487, 30);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(181, 47);
            this.btsave.TabIndex = 40;
            this.btsave.Text = "ບັນທຶກ";
            this.btsave.UseVisualStyleBackColor = true;
            this.btsave.Click += new System.EventHandler(this.button1_Click);
            // 
            // rbfemale
            // 
            this.rbfemale.AutoSize = true;
            this.rbfemale.Location = new System.Drawing.Point(309, 281);
            this.rbfemale.Name = "rbfemale";
            this.rbfemale.Size = new System.Drawing.Size(49, 33);
            this.rbfemale.TabIndex = 38;
            this.rbfemale.TabStop = true;
            this.rbfemale.Text = "ຍິງ";
            this.rbfemale.UseVisualStyleBackColor = true;
            // 
            // rbmale
            // 
            this.rbmale.AutoSize = true;
            this.rbmale.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rbmale.Location = new System.Drawing.Point(165, 283);
            this.rbmale.Name = "rbmale";
            this.rbmale.Size = new System.Drawing.Size(59, 33);
            this.rbmale.TabIndex = 39;
            this.rbmale.TabStop = true;
            this.rbmale.Text = "ຊາຍ";
            this.rbmale.UseVisualStyleBackColor = true;
            // 
            // dgvemp
            // 
            this.dgvemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvemp.Location = new System.Drawing.Point(381, 154);
            this.dgvemp.Name = "dgvemp";
            this.dgvemp.RowHeadersWidth = 51;
            this.dgvemp.Size = new System.Drawing.Size(1018, 454);
            this.dgvemp.TabIndex = 8;
            this.dgvemp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvemp_CellContentClick);
            // 
            // txtsurname
            // 
            this.txtsurname.Location = new System.Drawing.Point(163, 221);
            this.txtsurname.Multiline = true;
            this.txtsurname.Name = "txtsurname";
            this.txtsurname.Size = new System.Drawing.Size(212, 42);
            this.txtsurname.TabIndex = 5;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(158, 522);
            this.txtemail.Multiline = true;
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(212, 42);
            this.txtemail.TabIndex = 5;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(158, 412);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(212, 42);
            this.txtaddress.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(98, 469);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 29);
            this.label9.TabIndex = 2;
            this.label9.Text = "ເບີໂທ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(99, 528);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = "ອີເມວ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "ທີຢູ່";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(163, 109);
            this.txtpassword.Multiline = true;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(212, 42);
            this.txtpassword.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 29);
            this.label8.TabIndex = 3;
            this.label8.Text = "ວັນເດືອນປີເກີດ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "ເພດ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "ລະຫັດເຂົ້າລະບົບ";
            // 
            // txttel
            // 
            this.txttel.Location = new System.Drawing.Point(158, 466);
            this.txttel.Multiline = true;
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(212, 42);
            this.txttel.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 29);
            this.label7.TabIndex = 4;
            this.label7.Text = "ນາມສະກຸນ";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(163, 166);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(212, 42);
            this.txtname.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(443, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 29);
            this.label10.TabIndex = 4;
            this.label10.Text = "ຄົ້ນຫາ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(131, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "ຊື່";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(546, 97);
            this.txtsearch.Multiline = true;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(259, 42);
            this.txtsearch.TabIndex = 7;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // txtempID
            // 
            this.txtempID.Location = new System.Drawing.Point(163, 51);
            this.txtempID.Multiline = true;
            this.txtempID.Name = "txtempID";
            this.txtempID.Size = new System.Drawing.Size(212, 42);
            this.txtempID.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "ລະຫັດພະນັກງານ";
            // 
            // employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 623);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.MaximumSize = new System.Drawing.Size(1422, 662);
            this.MinimumSize = new System.Drawing.Size(1422, 662);
            this.Name = "employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "employee";
            this.Load += new System.EventHandler(this.employee_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvemp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtempID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvemp;
        private System.Windows.Forms.TextBox txtsurname;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbfemale;
        private System.Windows.Forms.RadioButton rbmale;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Button btedit;
        private System.Windows.Forms.Button btsave;
        private System.Windows.Forms.Button btsearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.DateTimePicker txtdateTime;
    }
}