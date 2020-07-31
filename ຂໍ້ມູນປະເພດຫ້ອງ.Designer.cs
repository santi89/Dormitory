namespace C_Sharp_2_Project
{
    partial class ຂໍ້ມູນປະເພດຫ້ອງ
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btrtdelete = new System.Windows.Forms.Button();
            this.btrtedit = new System.Windows.Forms.Button();
            this.btrtsave = new System.Windows.Forms.Button();
            this.dgvroomtype = new System.Windows.Forms.DataGridView();
            this.txtroomtypeID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txttypeprice = new System.Windows.Forms.TextBox();
            this.txtnametype = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvroomtype)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1165, 508);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.btrtdelete);
            this.groupBox3.Controls.Add(this.btrtedit);
            this.groupBox3.Controls.Add(this.btrtsave);
            this.groupBox3.Controls.Add(this.dgvroomtype);
            this.groupBox3.Controls.Add(this.txtroomtypeID);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txttypeprice);
            this.groupBox3.Controls.Add(this.txtnametype);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(8, 46);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.groupBox3.Size = new System.Drawing.Size(1153, 459);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 52);
            this.button1.TabIndex = 29;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btrtdelete
            // 
            this.btrtdelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btrtdelete.Location = new System.Drawing.Point(269, 274);
            this.btrtdelete.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btrtdelete.Name = "btrtdelete";
            this.btrtdelete.Size = new System.Drawing.Size(98, 51);
            this.btrtdelete.TabIndex = 28;
            this.btrtdelete.Text = "ລຶບ";
            this.btrtdelete.UseVisualStyleBackColor = true;
            this.btrtdelete.Click += new System.EventHandler(this.btrtdelete_Click_1);
            // 
            // btrtedit
            // 
            this.btrtedit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btrtedit.Location = new System.Drawing.Point(163, 274);
            this.btrtedit.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btrtedit.Name = "btrtedit";
            this.btrtedit.Size = new System.Drawing.Size(98, 51);
            this.btrtedit.TabIndex = 28;
            this.btrtedit.Text = "ແກ້ໄຂ";
            this.btrtedit.UseVisualStyleBackColor = true;
            this.btrtedit.Click += new System.EventHandler(this.btrtedit_Click_1);
            // 
            // btrtsave
            // 
            this.btrtsave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btrtsave.Location = new System.Drawing.Point(59, 274);
            this.btrtsave.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btrtsave.Name = "btrtsave";
            this.btrtsave.Size = new System.Drawing.Size(98, 51);
            this.btrtsave.TabIndex = 28;
            this.btrtsave.Text = "ບັນທຶກ";
            this.btrtsave.UseVisualStyleBackColor = true;
            this.btrtsave.Click += new System.EventHandler(this.btrtsave_Click_1);
            // 
            // dgvroomtype
            // 
            this.dgvroomtype.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvroomtype.Location = new System.Drawing.Point(411, 31);
            this.dgvroomtype.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.dgvroomtype.Name = "dgvroomtype";
            this.dgvroomtype.RowHeadersWidth = 51;
            this.dgvroomtype.RowTemplate.Height = 24;
            this.dgvroomtype.Size = new System.Drawing.Size(722, 403);
            this.dgvroomtype.TabIndex = 27;
            this.dgvroomtype.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvroomtype_CellContentClick_1);
            // 
            // txtroomtypeID
            // 
            this.txtroomtypeID.Location = new System.Drawing.Point(144, 49);
            this.txtroomtypeID.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txtroomtypeID.Name = "txtroomtypeID";
            this.txtroomtypeID.Size = new System.Drawing.Size(222, 42);
            this.txtroomtypeID.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(49, 44);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 36);
            this.label6.TabIndex = 17;
            this.label6.Text = "ລະຫັດ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(49, 104);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 36);
            this.label12.TabIndex = 19;
            this.label12.Text = "ຊື່ປະເພດ";
            // 
            // txttypeprice
            // 
            this.txttypeprice.Location = new System.Drawing.Point(144, 159);
            this.txttypeprice.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txttypeprice.Name = "txttypeprice";
            this.txttypeprice.Size = new System.Drawing.Size(222, 42);
            this.txttypeprice.TabIndex = 24;
            // 
            // txtnametype
            // 
            this.txtnametype.Location = new System.Drawing.Point(144, 104);
            this.txtnametype.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txtnametype.Name = "txtnametype";
            this.txtnametype.Size = new System.Drawing.Size(222, 42);
            this.txtnametype.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(49, 159);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 36);
            this.label13.TabIndex = 23;
            this.label13.Text = "ລາຄາ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(1128, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 36);
            this.label2.TabIndex = 37;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(443, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 36);
            this.label1.TabIndex = 35;
            this.label1.Text = "ຈັດການຂໍ້ມູນປະເພດຫ້ອງ";
            // 
            // ຂໍ້ມູນປະເພດຫ້ອງ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(208)))), ((int)(((byte)(203)))));
            this.ClientSize = new System.Drawing.Size(1165, 508);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.MinimumSize = new System.Drawing.Size(1165, 496);
            this.Name = "ຂໍ້ມູນປະເພດຫ້ອງ";
            this.Text = "ຂໍ້ມູນປະເພດຫ້ອງ";
            this.Load += new System.EventHandler(this.ຂໍ້ມູນປະເພດຫ້ອງ_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvroomtype)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btrtdelete;
        private System.Windows.Forms.Button btrtedit;
        private System.Windows.Forms.Button btrtsave;
        private System.Windows.Forms.DataGridView dgvroomtype;
        private System.Windows.Forms.TextBox txtroomtypeID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txttypeprice;
        private System.Windows.Forms.TextBox txtnametype;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}