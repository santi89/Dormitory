namespace C_Sharp_2_Project
{
    partial class ຂໍ້ມູນຫ້ອງ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ຂໍ້ມູນຫ້ອງ));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbuild = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbroomtype = new System.Windows.Forms.ComboBox();
            this.btrsearch = new System.Windows.Forms.Button();
            this.cbfloor = new System.Windows.Forms.ComboBox();
            this.btrdelete = new System.Windows.Forms.Button();
            this.dgvroom = new System.Windows.Forms.DataGridView();
            this.txtroomid = new System.Windows.Forms.TextBox();
            this.btredit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btrsave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtroomnum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvroom)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cbbuild);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtsearch);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbroomtype);
            this.groupBox1.Controls.Add(this.btrsearch);
            this.groupBox1.Controls.Add(this.cbfloor);
            this.groupBox1.Controls.Add(this.btrdelete);
            this.groupBox1.Controls.Add(this.dgvroom);
            this.groupBox1.Controls.Add(this.txtroomid);
            this.groupBox1.Controls.Add(this.btredit);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btrsave);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtroomnum);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(13, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.groupBox1.Size = new System.Drawing.Size(1291, 626);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cbbuild
            // 
            this.cbbuild.FormattingEnabled = true;
            this.cbbuild.Location = new System.Drawing.Point(1053, 221);
            this.cbbuild.Name = "cbbuild";
            this.cbbuild.Size = new System.Drawing.Size(216, 44);
            this.cbbuild.TabIndex = 39;
            this.cbbuild.SelectedIndexChanged += new System.EventHandler(this.cbbuild_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(990, 484);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 54);
            this.button1.TabIndex = 30;
            this.button1.Text = "ລ້າງບ໊ອກ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(729, 34);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(222, 42);
            this.txtsearch.TabIndex = 22;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(615, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 36);
            this.label4.TabIndex = 25;
            this.label4.Text = "ຄົ້ນຫາ";
            // 
            // cbroomtype
            // 
            this.cbroomtype.FormattingEnabled = true;
            this.cbroomtype.Location = new System.Drawing.Point(1053, 167);
            this.cbroomtype.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.cbroomtype.Name = "cbroomtype";
            this.cbroomtype.Size = new System.Drawing.Size(216, 44);
            this.cbroomtype.TabIndex = 29;
            this.cbroomtype.SelectedIndexChanged += new System.EventHandler(this.cbroomtype_SelectedIndexChanged);
            // 
            // btrsearch
            // 
            this.btrsearch.Image = ((System.Drawing.Image)(resources.GetObject("btrsearch.Image")));
            this.btrsearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btrsearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btrsearch.Location = new System.Drawing.Point(1008, 26);
            this.btrsearch.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btrsearch.Name = "btrsearch";
            this.btrsearch.Size = new System.Drawing.Size(120, 54);
            this.btrsearch.TabIndex = 28;
            this.btrsearch.Text = "ຄົ້ນຫາ";
            this.btrsearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btrsearch.UseVisualStyleBackColor = true;
            this.btrsearch.Click += new System.EventHandler(this.btrsearch_Click);
            // 
            // cbfloor
            // 
            this.cbfloor.FormattingEnabled = true;
            this.cbfloor.Location = new System.Drawing.Point(1051, 286);
            this.cbfloor.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.cbfloor.Name = "cbfloor";
            this.cbfloor.Size = new System.Drawing.Size(216, 44);
            this.cbfloor.TabIndex = 29;
            this.cbfloor.SelectedIndexChanged += new System.EventHandler(this.cbfloor_SelectedIndexChanged);
            // 
            // btrdelete
            // 
            this.btrdelete.Image = ((System.Drawing.Image)(resources.GetObject("btrdelete.Image")));
            this.btrdelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btrdelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btrdelete.Location = new System.Drawing.Point(1130, 481);
            this.btrdelete.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btrdelete.Name = "btrdelete";
            this.btrdelete.Size = new System.Drawing.Size(124, 57);
            this.btrdelete.TabIndex = 28;
            this.btrdelete.Text = "ລືບ";
            this.btrdelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btrdelete.UseVisualStyleBackColor = true;
            this.btrdelete.Click += new System.EventHandler(this.btrdelete_Click);
            // 
            // dgvroom
            // 
            this.dgvroom.AllowUserToAddRows = false;
            this.dgvroom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvroom.Location = new System.Drawing.Point(8, 101);
            this.dgvroom.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.dgvroom.Name = "dgvroom";
            this.dgvroom.RowHeadersWidth = 51;
            this.dgvroom.RowTemplate.Height = 24;
            this.dgvroom.Size = new System.Drawing.Size(904, 495);
            this.dgvroom.TabIndex = 27;
            this.dgvroom.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvroom_CellContentClick);
            // 
            // txtroomid
            // 
            this.txtroomid.Enabled = false;
            this.txtroomid.Location = new System.Drawing.Point(1052, 121);
            this.txtroomid.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txtroomid.Name = "txtroomid";
            this.txtroomid.Size = new System.Drawing.Size(217, 42);
            this.txtroomid.TabIndex = 18;
            // 
            // btredit
            // 
            this.btredit.Image = ((System.Drawing.Image)(resources.GetObject("btredit.Image")));
            this.btredit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btredit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btredit.Location = new System.Drawing.Point(1130, 414);
            this.btredit.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btredit.Name = "btredit";
            this.btredit.Size = new System.Drawing.Size(124, 60);
            this.btredit.TabIndex = 28;
            this.btredit.Text = "ແກ້ໄຂ";
            this.btredit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btredit.UseVisualStyleBackColor = true;
            this.btredit.Click += new System.EventHandler(this.btredit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(967, 121);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 36);
            this.label5.TabIndex = 17;
            this.label5.Text = "ລະຫັດ";
            // 
            // btrsave
            // 
            this.btrsave.Image = ((System.Drawing.Image)(resources.GetObject("btrsave.Image")));
            this.btrsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btrsave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btrsave.Location = new System.Drawing.Point(990, 414);
            this.btrsave.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btrsave.Name = "btrsave";
            this.btrsave.Size = new System.Drawing.Size(129, 60);
            this.btrsave.TabIndex = 28;
            this.btrsave.Text = "ບັນທຶກ";
            this.btrsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btrsave.UseVisualStyleBackColor = true;
            this.btrsave.Click += new System.EventHandler(this.btrsave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(984, 221);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 36);
            this.label2.TabIndex = 25;
            this.label2.Text = " ຕຶກ";
            this.label2.Click += new System.EventHandler(this.label10_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(994, 286);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 36);
            this.label10.TabIndex = 25;
            this.label10.Text = "ຊັ້ນ";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(960, 347);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 36);
            this.label7.TabIndex = 19;
            this.label7.Text = "ເບີຫ້ອງ";
            // 
            // txtroomnum
            // 
            this.txtroomnum.Location = new System.Drawing.Point(1050, 344);
            this.txtroomnum.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txtroomnum.Name = "txtroomnum";
            this.txtroomnum.Size = new System.Drawing.Size(217, 42);
            this.txtroomnum.TabIndex = 20;
            this.txtroomnum.TextChanged += new System.EventHandler(this.txtroomnum_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(920, 170);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 36);
            this.label9.TabIndex = 23;
            this.label9.Text = "ປະເພດຫ້ອງ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(1292, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 36);
            this.label1.TabIndex = 38;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Saysettha OT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1330, 43);
            this.label6.TabIndex = 25;
            this.label6.Text = "ຈັດການຂໍ້ມູນຫ້ອງ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ຂໍ້ມູນຫ້ອງ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1330, 697);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "ຂໍ້ມູນຫ້ອງ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ຂໍ້ມູນຫ້ອງ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ຂໍ້ມູນຫ້ອງ_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvroom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvroom;
        private System.Windows.Forms.Button btrsearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbuild;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbroomtype;
        private System.Windows.Forms.ComboBox cbfloor;
        private System.Windows.Forms.Button btrdelete;
        private System.Windows.Forms.TextBox txtroomid;
        private System.Windows.Forms.Button btredit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btrsave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtroomnum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
    }
}