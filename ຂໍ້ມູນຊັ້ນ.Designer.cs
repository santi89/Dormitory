namespace C_Sharp_2_Project
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbbuilding = new System.Windows.Forms.ComboBox();
            this.dgvfloor = new System.Windows.Forms.DataGridView();
            this.btfsave = new System.Windows.Forms.Button();
            this.txtfloorid = new System.Windows.Forms.TextBox();
            this.btfedit = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btfdelete = new System.Windows.Forms.Button();
            this.txtfloornum = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfloor)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.cbbuilding);
            this.groupBox4.Controls.Add(this.dgvfloor);
            this.groupBox4.Controls.Add(this.btfsave);
            this.groupBox4.Controls.Add(this.txtfloorid);
            this.groupBox4.Controls.Add(this.btfedit);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.btfdelete);
            this.groupBox4.Controls.Add(this.txtfloornum);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Location = new System.Drawing.Point(13, 6);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.groupBox4.Size = new System.Drawing.Size(1054, 453);
            this.groupBox4.TabIndex = 34;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ຈັດການຂໍ້ມູນຊັ້ນ";
            // 
            // cbbuilding
            // 
            this.cbbuilding.FormattingEnabled = true;
            this.cbbuilding.Location = new System.Drawing.Point(137, 157);
            this.cbbuilding.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.cbbuilding.Name = "cbbuilding";
            this.cbbuilding.Size = new System.Drawing.Size(217, 44);
            this.cbbuilding.TabIndex = 30;
            // 
            // dgvfloor
            // 
            this.dgvfloor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfloor.Location = new System.Drawing.Point(408, 27);
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
            this.btfsave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btfsave.Location = new System.Drawing.Point(57, 238);
            this.btfsave.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btfsave.Name = "btfsave";
            this.btfsave.Size = new System.Drawing.Size(105, 65);
            this.btfsave.TabIndex = 28;
            this.btfsave.Text = "ບັນທຶກ";
            this.btfsave.UseVisualStyleBackColor = true;
            this.btfsave.Click += new System.EventHandler(this.btfsave_Click);
            // 
            // txtfloorid
            // 
            this.txtfloorid.Location = new System.Drawing.Point(137, 48);
            this.txtfloorid.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txtfloorid.Multiline = true;
            this.txtfloorid.Name = "txtfloorid";
            this.txtfloorid.Size = new System.Drawing.Size(217, 39);
            this.txtfloorid.TabIndex = 18;
            // 
            // btfedit
            // 
            this.btfedit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btfedit.Location = new System.Drawing.Point(226, 238);
            this.btfedit.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btfedit.Name = "btfedit";
            this.btfedit.Size = new System.Drawing.Size(105, 65);
            this.btfedit.TabIndex = 28;
            this.btfedit.Text = "ແກ້ໄຂ";
            this.btfedit.UseVisualStyleBackColor = true;
            this.btfedit.Click += new System.EventHandler(this.btfedit_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label15.Location = new System.Drawing.Point(33, 53);
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
            this.label17.Location = new System.Drawing.Point(27, 104);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(74, 36);
            this.label17.TabIndex = 19;
            this.label17.Text = "ເລກຊັ້ນ";
            // 
            // btfdelete
            // 
            this.btfdelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btfdelete.Location = new System.Drawing.Point(226, 317);
            this.btfdelete.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btfdelete.Name = "btfdelete";
            this.btfdelete.Size = new System.Drawing.Size(105, 65);
            this.btfdelete.TabIndex = 28;
            this.btfdelete.Text = "ລຶບ";
            this.btfdelete.UseVisualStyleBackColor = true;
            this.btfdelete.Click += new System.EventHandler(this.btfdelete_Click);
            // 
            // txtfloornum
            // 
            this.txtfloornum.Location = new System.Drawing.Point(137, 104);
            this.txtfloornum.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.txtfloornum.Multiline = true;
            this.txtfloornum.Name = "txtfloornum";
            this.txtfloornum.Size = new System.Drawing.Size(217, 39);
            this.txtfloornum.TabIndex = 20;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label18.Location = new System.Drawing.Point(60, 160);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 36);
            this.label18.TabIndex = 23;
            this.label18.Text = "ຕຶກ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(58, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 57);
            this.button1.TabIndex = 31;
            this.button1.Text = "ຍົກເລີກ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ຂໍ້ມູນຊັ້ນ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(208)))), ((int)(((byte)(203)))));
            this.ClientSize = new System.Drawing.Size(1077, 462);
            this.Controls.Add(this.groupBox4);
            this.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "ຂໍ້ມູນຊັ້ນ";
            this.Text = "ຂໍ້ມູນຊັ້ນ";
            this.Load += new System.EventHandler(this.ຂໍ້ມູນຊັ້ນ_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfloor)).EndInit();
            this.ResumeLayout(false);

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
    }
}