﻿namespace C_Sharp_2_Project
{
    partial class ຂໍ້ມູນຊັ້ນ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ຂໍ້ມູນຊັ້ນ));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbbuilding = new System.Windows.Forms.ComboBox();
            this.dgvfloor = new System.Windows.Forms.DataGridView();
            this.btfsave = new System.Windows.Forms.Button();
            this.txtfloorid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btfedit = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btfdelete = new System.Windows.Forms.Button();
            this.txtfloornum = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfloor)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.Controls.Add(this.txtsearch);
            this.groupBox4.Controls.Add(this.search);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.cbbuilding);
            this.groupBox4.Controls.Add(this.dgvfloor);
            this.groupBox4.Controls.Add(this.btfsave);
            this.groupBox4.Controls.Add(this.txtfloorid);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.btfedit);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.btfdelete);
            this.groupBox4.Controls.Add(this.txtfloornum);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Location = new System.Drawing.Point(31, 65);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.groupBox4.Size = new System.Drawing.Size(984, 493);
            this.groupBox4.TabIndex = 34;
            this.groupBox4.TabStop = false;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(426, 47);
            this.txtsearch.Multiline = true;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(223, 42);
            this.txtsearch.TabIndex = 33;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // search
            // 
            this.search.Image = ((System.Drawing.Image)(resources.GetObject("search.Image")));
            this.search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.search.Location = new System.Drawing.Point(694, 31);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(115, 58);
            this.search.TabIndex = 32;
            this.search.Text = "ຄົ້ນຫາ";
            this.search.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.search.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(64, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 58);
            this.button1.TabIndex = 31;
            this.button1.Text = "ຍົກເລີກ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbbuilding
            // 
            this.cbbuilding.FormattingEnabled = true;
            this.cbbuilding.Location = new System.Drawing.Point(102, 126);
            this.cbbuilding.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.cbbuilding.Name = "cbbuilding";
            this.cbbuilding.Size = new System.Drawing.Size(217, 44);
            this.cbbuilding.TabIndex = 30;
            this.cbbuilding.SelectedIndexChanged += new System.EventHandler(this.cbbuilding_SelectedIndexChanged);
            // 
            // dgvfloor
            // 
            this.dgvfloor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfloor.Location = new System.Drawing.Point(327, 106);
            this.dgvfloor.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.dgvfloor.Name = "dgvfloor";
            this.dgvfloor.RowHeadersWidth = 51;
            this.dgvfloor.RowTemplate.Height = 24;
            this.dgvfloor.Size = new System.Drawing.Size(635, 369);
            this.dgvfloor.TabIndex = 27;
            this.dgvfloor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvfloor_CellContentClick);
            // 
            // btfsave
            // 
            this.btfsave.Image = ((System.Drawing.Image)(resources.GetObject("btfsave.Image")));
            this.btfsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btfsave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btfsave.Location = new System.Drawing.Point(64, 252);
            this.btfsave.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btfsave.Name = "btfsave";
            this.btfsave.Size = new System.Drawing.Size(128, 62);
            this.btfsave.TabIndex = 28;
            this.btfsave.Text = "ບັນທຶກ";
            this.btfsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btfsave.UseVisualStyleBackColor = true;
            this.btfsave.Click += new System.EventHandler(this.btfsave_Click);
            // 
            // txtfloorid
            // 
            this.txtfloorid.Enabled = false;
            this.txtfloorid.Location = new System.Drawing.Point(102, 70);
            this.txtfloorid.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txtfloorid.Name = "txtfloorid";
            this.txtfloorid.Size = new System.Drawing.Size(217, 42);
            this.txtfloorid.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(353, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 36);
            this.label1.TabIndex = 17;
            this.label1.Text = "ຄົ້ນຫາ";
            // 
            // btfedit
            // 
            this.btfedit.Image = ((System.Drawing.Image)(resources.GetObject("btfedit.Image")));
            this.btfedit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btfedit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btfedit.Location = new System.Drawing.Point(200, 252);
            this.btfedit.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btfedit.Name = "btfedit";
            this.btfedit.Size = new System.Drawing.Size(119, 62);
            this.btfedit.TabIndex = 28;
            this.btfedit.Text = "ແກ້ໄຂ";
            this.btfedit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btfedit.UseVisualStyleBackColor = true;
            this.btfedit.Click += new System.EventHandler(this.btfedit_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label15.Location = new System.Drawing.Point(33, 70);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 36);
            this.label15.TabIndex = 17;
            this.label15.Text = "ລະຫັດ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label17.Location = new System.Drawing.Point(11, 183);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 36);
            this.label17.TabIndex = 19;
            this.label17.Text = "ເລກຊັ້ນ";
            // 
            // btfdelete
            // 
            this.btfdelete.Image = ((System.Drawing.Image)(resources.GetObject("btfdelete.Image")));
            this.btfdelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btfdelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btfdelete.Location = new System.Drawing.Point(199, 324);
            this.btfdelete.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btfdelete.Name = "btfdelete";
            this.btfdelete.Size = new System.Drawing.Size(119, 62);
            this.btfdelete.TabIndex = 28;
            this.btfdelete.Text = "ລຶບ";
            this.btfdelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btfdelete.UseVisualStyleBackColor = true;
            this.btfdelete.Click += new System.EventHandler(this.btfdelete_Click);
            // 
            // txtfloornum
            // 
            this.txtfloornum.Location = new System.Drawing.Point(102, 184);
            this.txtfloornum.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txtfloornum.Name = "txtfloornum";
            this.txtfloornum.Size = new System.Drawing.Size(217, 42);
            this.txtfloornum.TabIndex = 20;
            this.txtfloornum.TextChanged += new System.EventHandler(this.txtfloornum_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label18.Location = new System.Drawing.Point(44, 129);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 36);
            this.label18.TabIndex = 23;
            this.label18.Text = "ຕຶກ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(1018, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 36);
            this.label2.TabIndex = 17;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1044, 58);
            this.label3.TabIndex = 17;
            this.label3.Text = "ຈັດການຂໍ້ມູນຊັ້ນ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ຂໍ້ມູນຊັ້ນ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1044, 574);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "ຂໍ້ມູນຊັ້ນ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ຂໍ້ມູນຊັ້ນ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ຂໍ້ມູນຊັ້ນ_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfloor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbbuilding;
        private System.Windows.Forms.DataGridView dgvfloor;
        private System.Windows.Forms.Button btfsave;
        private System.Windows.Forms.TextBox txtfloorid;
        private System.Windows.Forms.Button btfedit;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btfdelete;
        private System.Windows.Forms.TextBox txtfloornum;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}