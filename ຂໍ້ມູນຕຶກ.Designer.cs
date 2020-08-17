namespace C_Sharp_2_Project
{
    partial class ຂໍ້ມູນຕຶກ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ຂໍ້ມູນຕຶກ));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.cbroomtype = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.dgvbuild = new System.Windows.Forms.DataGridView();
            this.btdelete = new System.Windows.Forms.Button();
            this.txtbuildingid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btedit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbuildingnum = new System.Windows.Forms.TextBox();
            this.btbsave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbuild)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.cbroomtype);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txtsearch);
            this.groupBox2.Controls.Add(this.dgvbuild);
            this.groupBox2.Controls.Add(this.btdelete);
            this.groupBox2.Controls.Add(this.txtbuildingid);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btedit);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtbuildingnum);
            this.groupBox2.Controls.Add(this.btbsave);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(13, 61);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.groupBox2.Size = new System.Drawing.Size(1021, 517);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(93, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 62);
            this.button2.TabIndex = 33;
            this.button2.Text = "ຍົກເລີກ";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbroomtype
            // 
            this.cbroomtype.FormattingEnabled = true;
            this.cbroomtype.Location = new System.Drawing.Point(127, 188);
            this.cbroomtype.Name = "cbroomtype";
            this.cbroomtype.Size = new System.Drawing.Size(229, 44);
            this.cbroomtype.TabIndex = 32;
            this.cbroomtype.SelectedIndexChanged += new System.EventHandler(this.cbroomtype_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(129, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 59);
            this.button1.TabIndex = 31;
            this.button1.Text = "ຄົ້ນຫາ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(129, 391);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(222, 42);
            this.txtsearch.TabIndex = 30;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // dgvbuild
            // 
            this.dgvbuild.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbuild.Location = new System.Drawing.Point(374, 45);
            this.dgvbuild.Name = "dgvbuild";
            this.dgvbuild.RowHeadersWidth = 51;
            this.dgvbuild.RowTemplate.Height = 24;
            this.dgvbuild.Size = new System.Drawing.Size(640, 438);
            this.dgvbuild.TabIndex = 29;
            this.dgvbuild.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbuild_CellContentClick);
            // 
            // btdelete
            // 
            this.btdelete.Image = ((System.Drawing.Image)(resources.GetObject("btdelete.Image")));
            this.btdelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btdelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btdelete.Location = new System.Drawing.Point(227, 312);
            this.btdelete.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btdelete.Name = "btdelete";
            this.btdelete.Size = new System.Drawing.Size(122, 62);
            this.btdelete.TabIndex = 28;
            this.btdelete.Text = "ລຶບ";
            this.btdelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btdelete.UseVisualStyleBackColor = true;
            this.btdelete.Click += new System.EventHandler(this.btdelete_Click);
            // 
            // txtbuildingid
            // 
            this.txtbuildingid.Location = new System.Drawing.Point(127, 65);
            this.txtbuildingid.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txtbuildingid.Name = "txtbuildingid";
            this.txtbuildingid.Size = new System.Drawing.Size(229, 42);
            this.txtbuildingid.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(25, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 36);
            this.label1.TabIndex = 17;
            this.label1.Text = "ລະຫັດຕຶກ";
            // 
            // btedit
            // 
            this.btedit.Image = ((System.Drawing.Image)(resources.GetObject("btedit.Image")));
            this.btedit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btedit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btedit.Location = new System.Drawing.Point(228, 242);
            this.btedit.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btedit.Name = "btedit";
            this.btedit.Size = new System.Drawing.Size(121, 61);
            this.btedit.TabIndex = 28;
            this.btedit.Text = "ແກ້ໄຂ";
            this.btedit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btedit.UseVisualStyleBackColor = true;
            this.btedit.Click += new System.EventHandler(this.btedit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(60, 391);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 36);
            this.label2.TabIndex = 19;
            this.label2.Text = "ຄົ້ນຫາ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(3, 191);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 36);
            this.label4.TabIndex = 19;
            this.label4.Text = "ປະເພດຫ້ອງ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(56, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 36);
            this.label3.TabIndex = 19;
            this.label3.Text = "ເບີຕຶກ";
            // 
            // txtbuildingnum
            // 
            this.txtbuildingnum.Location = new System.Drawing.Point(129, 139);
            this.txtbuildingnum.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txtbuildingnum.Name = "txtbuildingnum";
            this.txtbuildingnum.Size = new System.Drawing.Size(229, 42);
            this.txtbuildingnum.TabIndex = 20;
            // 
            // btbsave
            // 
            this.btbsave.Image = ((System.Drawing.Image)(resources.GetObject("btbsave.Image")));
            this.btbsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btbsave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btbsave.Location = new System.Drawing.Point(93, 242);
            this.btbsave.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btbsave.Name = "btbsave";
            this.btbsave.Size = new System.Drawing.Size(127, 61);
            this.btbsave.TabIndex = 28;
            this.btbsave.Text = "ບັນທຶກ";
            this.btbsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btbsave.UseVisualStyleBackColor = true;
            this.btbsave.Click += new System.EventHandler(this.btbsave_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(1018, -1);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 36);
            this.label5.TabIndex = 37;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
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
            this.label6.Size = new System.Drawing.Size(1047, 57);
            this.label6.TabIndex = 17;
            this.label6.Text = "ຂໍ້ມູນຕຶກ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ຂໍ້ມູນຕຶກ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1047, 575);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "ຂໍ້ມູນຕຶກ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ຂໍ້ມູນຕຶກ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ຂໍ້ມູນຕຶກ_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbuild)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btdelete;
        private System.Windows.Forms.TextBox txtbuildingid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btedit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbuildingnum;
        private System.Windows.Forms.Button btbsave;
        private System.Windows.Forms.DataGridView dgvbuild;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbroomtype;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}