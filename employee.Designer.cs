﻿namespace C_Sharp_2_Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employee));
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvemp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.txtdateTime);
            this.panel1.Controls.Add(this.btsearch);
            this.panel1.Controls.Add(this.btdelete);
            this.panel1.Controls.Add(this.btedit);
            this.panel1.Controls.Add(this.btsave);
            this.panel1.Controls.Add(this.rbfemale);
            this.panel1.Controls.Add(this.rbmale);
            this.panel1.Controls.Add(this.dgvemp);
            this.panel1.Controls.Add(this.txtsurname);
            this.panel1.Controls.Add(this.txtemail);
            this.panel1.Controls.Add(this.txtaddress);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtpassword);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txttel);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtsearch);
            this.panel1.Controls.Add(this.txtempID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1544, 666);
            this.panel1.TabIndex = 0;
            // 
            // txtdateTime
            // 
            this.txtdateTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtdateTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtdateTime.Location = new System.Drawing.Point(171, 382);
            this.txtdateTime.Name = "txtdateTime";
            this.txtdateTime.Size = new System.Drawing.Size(213, 42);
            this.txtdateTime.TabIndex = 67;
            // 
            // btsearch
            // 
            this.btsearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btsearch.BackColor = System.Drawing.Color.Silver;
            this.btsearch.Image = ((System.Drawing.Image)(resources.GetObject("btsearch.Image")));
            this.btsearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btsearch.Location = new System.Drawing.Point(1307, 575);
            this.btsearch.Name = "btsearch";
            this.btsearch.Size = new System.Drawing.Size(127, 59);
            this.btsearch.TabIndex = 66;
            this.btsearch.Text = "ຄົ້ນຫາ";
            this.btsearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btsearch.UseVisualStyleBackColor = false;
            this.btsearch.Click += new System.EventHandler(this.btsearch_Click_1);
            // 
            // btdelete
            // 
            this.btdelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btdelete.BackColor = System.Drawing.Color.Silver;
            this.btdelete.Image = ((System.Drawing.Image)(resources.GetObject("btdelete.Image")));
            this.btdelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btdelete.Location = new System.Drawing.Point(719, 575);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(109, 59);
            this.btdelete.TabIndex = 65;
            this.btdelete.Text = "ລືບ";
            this.btdelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btdelete.UseVisualStyleBackColor = false;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click_1);
            // 
            // btedit
            // 
            this.btedit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btedit.BackColor = System.Drawing.Color.Silver;
            this.btedit.Image = ((System.Drawing.Image)(resources.GetObject("btedit.Image")));
            this.btedit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btedit.Location = new System.Drawing.Point(570, 575);
            this.btedit.Name = "btedit";
            this.btedit.Size = new System.Drawing.Size(117, 59);
            this.btedit.TabIndex = 64;
            this.btedit.Text = "ແກ້ໄຂ";
            this.btedit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btedit.UseVisualStyleBackColor = false;
            this.btedit.Click += new System.EventHandler(this.btedit_Click_1);
            // 
            // btsave
            // 
            this.btsave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btsave.BackColor = System.Drawing.Color.Silver;
            this.btsave.Image = ((System.Drawing.Image)(resources.GetObject("btsave.Image")));
            this.btsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btsave.Location = new System.Drawing.Point(403, 575);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(125, 59);
            this.btsave.TabIndex = 63;
            this.btsave.Text = "ບັນທຶກ";
            this.btsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btsave.UseVisualStyleBackColor = false;
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // rbfemale
            // 
            this.rbfemale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbfemale.AutoSize = true;
            this.rbfemale.Location = new System.Drawing.Point(322, 318);
            this.rbfemale.Name = "rbfemale";
            this.rbfemale.Size = new System.Drawing.Size(61, 40);
            this.rbfemale.TabIndex = 61;
            this.rbfemale.TabStop = true;
            this.rbfemale.Text = "ຍິງ";
            this.rbfemale.UseVisualStyleBackColor = true;
            // 
            // rbmale
            // 
            this.rbmale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbmale.AutoSize = true;
            this.rbmale.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rbmale.Location = new System.Drawing.Point(178, 320);
            this.rbmale.Name = "rbmale";
            this.rbmale.Size = new System.Drawing.Size(73, 40);
            this.rbmale.TabIndex = 62;
            this.rbmale.TabStop = true;
            this.rbmale.Text = "ຊາຍ";
            this.rbmale.UseVisualStyleBackColor = true;
            // 
            // dgvemp
            // 
            this.dgvemp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvemp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvemp.Location = new System.Drawing.Point(394, 85);
            this.dgvemp.Name = "dgvemp";
            this.dgvemp.RowHeadersWidth = 51;
            this.dgvemp.Size = new System.Drawing.Size(1134, 454);
            this.dgvemp.TabIndex = 60;
            this.dgvemp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvemp_CellContentClick_1);
            // 
            // txtsurname
            // 
            this.txtsurname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtsurname.Location = new System.Drawing.Point(176, 258);
            this.txtsurname.Name = "txtsurname";
            this.txtsurname.Size = new System.Drawing.Size(212, 42);
            this.txtsurname.TabIndex = 53;
            // 
            // txtemail
            // 
            this.txtemail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtemail.Location = new System.Drawing.Point(171, 559);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(212, 42);
            this.txtemail.TabIndex = 54;
            // 
            // txtaddress
            // 
            this.txtaddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtaddress.Location = new System.Drawing.Point(171, 449);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(212, 42);
            this.txtaddress.TabIndex = 52;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(111, 506);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 36);
            this.label9.TabIndex = 44;
            this.label9.Text = "ເບີໂທ";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 565);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 36);
            this.label6.TabIndex = 42;
            this.label6.Text = "ອີເມວ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 446);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 36);
            this.label3.TabIndex = 43;
            this.label3.Text = "ທີຢູ່";
            // 
            // txtpassword
            // 
            this.txtpassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtpassword.Location = new System.Drawing.Point(176, 146);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(212, 42);
            this.txtpassword.TabIndex = 55;
            this.txtpassword.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 387);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 36);
            this.label8.TabIndex = 47;
            this.label8.Text = "ວັນເດືອນປີເກີດ";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 36);
            this.label5.TabIndex = 46;
            this.label5.Text = "ເພດ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 36);
            this.label2.TabIndex = 45;
            this.label2.Text = "ລະຫັດເຂົ້າລະບົບ";
            // 
            // txttel
            // 
            this.txttel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txttel.Location = new System.Drawing.Point(171, 503);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(212, 42);
            this.txttel.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 36);
            this.label7.TabIndex = 50;
            this.label7.Text = "ນາມສະກຸນ";
            // 
            // txtname
            // 
            this.txtname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtname.Location = new System.Drawing.Point(176, 203);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(212, 42);
            this.txtname.TabIndex = 58;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(896, 595);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 36);
            this.label10.TabIndex = 49;
            this.label10.Text = "ຄົ້ນຫາ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 36);
            this.label4.TabIndex = 48;
            this.label4.Text = "ຊື່";
            // 
            // txtsearch
            // 
            this.txtsearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtsearch.Location = new System.Drawing.Point(999, 592);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(259, 42);
            this.txtsearch.TabIndex = 59;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged_1);
            // 
            // txtempID
            // 
            this.txtempID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtempID.Location = new System.Drawing.Point(176, 88);
            this.txtempID.Name = "txtempID";
            this.txtempID.Size = new System.Drawing.Size(212, 42);
            this.txtempID.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 36);
            this.label1.TabIndex = 51;
            this.label1.Text = "ລະຫັດພະນັກງານ";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(1510, 2);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 36);
            this.label11.TabIndex = 21;
            this.label11.Text = "X";
            this.label11.Click += new System.EventHandler(this.label11_Click_1);
            // 
            // label12
            // 
            this.label12.AutoEllipsis = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.Font = new System.Drawing.Font("Saysettha OT", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(1544, 61);
            this.label12.TabIndex = 22;
            this.label12.Text = "ຈັດການຂໍ້ມູນພະນັກງານ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1544, 666);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.MinimumSize = new System.Drawing.Size(1422, 662);
            this.Name = "employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "employee";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.employee_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvemp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker txtdateTime;
        private System.Windows.Forms.Button btsearch;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.Button btedit;
        private System.Windows.Forms.Button btsave;
        private System.Windows.Forms.RadioButton rbfemale;
        private System.Windows.Forms.RadioButton rbmale;
        private System.Windows.Forms.DataGridView dgvemp;
        private System.Windows.Forms.TextBox txtsurname;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.TextBox txtempID;
        private System.Windows.Forms.Label label1;
    }
}