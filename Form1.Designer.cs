namespace C_Sharp_2_Project
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel_show = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.register = new System.Windows.Forms.ToolStripMenuItem();
            this.ຊຳລະຄາຫToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ຈດການຂມນToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ຈດການຂມນຕກToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ຈດການຂມນຊນToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ຈດການຂມນປະເພດຫອງToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ຈດການຂມນສະຖາບນToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ລາຍງານToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crToolStripTextBox1 = new CrystalDecisions.Windows.Forms.CRToolStripTextBox();
            this.ລາຍງານນກສກສາເຂາພກToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ລາຍງານນກສກສາໝດກຳນດພກເຊາToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ອອກຈາລະບບToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_show.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_show
            // 
            this.panel_show.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_show.Controls.Add(this.toolStrip1);
            this.panel_show.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_show.Location = new System.Drawing.Point(0, 37);
            this.panel_show.Margin = new System.Windows.Forms.Padding(2);
            this.panel_show.Name = "panel_show";
            this.panel_show.Size = new System.Drawing.Size(841, 584);
            this.panel_show.TabIndex = 0;
            this.panel_show.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 559);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(841, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabel1.Text = "toolStripLabel1";
            this.toolStripLabel1.Click += new System.EventHandler(this.toolStripLabel1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(841, 37);
            this.panel2.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Font = new System.Drawing.Font("Saysettha OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.register,
            this.ຊຳລະຄາຫToolStripMenuItem,
            this.ຈດການຂມນToolStripMenuItem,
            this.ລາຍງານToolStripMenuItem,
            this.crToolStripTextBox1,
            this.ອອກຈາລະບບToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(841, 37);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // register
            // 
            this.register.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.register.Checked = true;
            this.register.CheckState = System.Windows.Forms.CheckState.Checked;
            this.register.Image = ((System.Drawing.Image)(resources.GetObject("register.Image")));
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(103, 33);
            this.register.Text = "ລົງທະບຽນ";
            this.register.Click += new System.EventHandler(this.ລງທະບຽນແລະຊຳລະຄາຫToolStripMenuItem_Click);
            // 
            // ຊຳລະຄາຫToolStripMenuItem
            // 
            this.ຊຳລະຄາຫToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ຊຳລະຄາຫToolStripMenuItem.Image")));
            this.ຊຳລະຄາຫToolStripMenuItem.Name = "ຊຳລະຄາຫToolStripMenuItem";
            this.ຊຳລະຄາຫToolStripMenuItem.Size = new System.Drawing.Size(105, 33);
            this.ຊຳລະຄາຫToolStripMenuItem.Text = "ຊຳລະຄ່າຫໍ";
            this.ຊຳລະຄາຫToolStripMenuItem.Click += new System.EventHandler(this.ຊຳລະຄາຫToolStripMenuItem_Click);
            // 
            // ຈດການຂມນToolStripMenuItem
            // 
            this.ຈດການຂມນToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.ຈດການຂມນຕກToolStripMenuItem,
            this.ຈດການຂມນຊນToolStripMenuItem,
            this.ຈດການຂມນປະເພດຫອງToolStripMenuItem,
            this.ຈດການຂມນສະຖາບນToolStripMenuItem});
            this.ຈດການຂມນToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ຈດການຂມນToolStripMenuItem.Image")));
            this.ຈດການຂມນToolStripMenuItem.Name = "ຈດການຂມນToolStripMenuItem";
            this.ຈດການຂມນToolStripMenuItem.Size = new System.Drawing.Size(115, 33);
            this.ຈດການຂມນToolStripMenuItem.Text = "ຈັດການຂໍ້ມູນ";
            this.ຈດການຂມນToolStripMenuItem.Click += new System.EventHandler(this.ຈດການຂມນToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(232, 32);
            this.toolStripMenuItem1.Text = "ຈັດການຂໍ້ມູນຫ້ອງ";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // ຈດການຂມນຕກToolStripMenuItem
            // 
            this.ຈດການຂມນຕກToolStripMenuItem.Name = "ຈດການຂມນຕກToolStripMenuItem";
            this.ຈດການຂມນຕກToolStripMenuItem.Size = new System.Drawing.Size(232, 32);
            this.ຈດການຂມນຕກToolStripMenuItem.Text = "ຈັດການຂໍ້ມູນຕຶກ";
            this.ຈດການຂມນຕກToolStripMenuItem.Click += new System.EventHandler(this.ຈດການຂມນຕກToolStripMenuItem_Click);
            // 
            // ຈດການຂມນຊນToolStripMenuItem
            // 
            this.ຈດການຂມນຊນToolStripMenuItem.Name = "ຈດການຂມນຊນToolStripMenuItem";
            this.ຈດການຂມນຊນToolStripMenuItem.Size = new System.Drawing.Size(232, 32);
            this.ຈດການຂມນຊນToolStripMenuItem.Text = "ຈັດການຂໍ້ມູນຊັ້ນ";
            this.ຈດການຂມນຊນToolStripMenuItem.Click += new System.EventHandler(this.ຈດການຂມນຊນToolStripMenuItem_Click);
            // 
            // ຈດການຂມນປະເພດຫອງToolStripMenuItem
            // 
            this.ຈດການຂມນປະເພດຫອງToolStripMenuItem.Name = "ຈດການຂມນປະເພດຫອງToolStripMenuItem";
            this.ຈດການຂມນປະເພດຫອງToolStripMenuItem.Size = new System.Drawing.Size(232, 32);
            this.ຈດການຂມນປະເພດຫອງToolStripMenuItem.Text = "ຈັດການຂໍ້ມູນປະເພດຫ້ອງ";
            this.ຈດການຂມນປະເພດຫອງToolStripMenuItem.Click += new System.EventHandler(this.ຈດການຂມນປະເພດຫອງToolStripMenuItem_Click);
            // 
            // ຈດການຂມນສະຖາບນToolStripMenuItem
            // 
            this.ຈດການຂມນສະຖາບນToolStripMenuItem.Name = "ຈດການຂມນສະຖາບນToolStripMenuItem";
            this.ຈດການຂມນສະຖາບນToolStripMenuItem.Size = new System.Drawing.Size(232, 32);
            this.ຈດການຂມນສະຖາບນToolStripMenuItem.Text = "ຈັດການຂໍ້ມູນການສຶກສາ";
            this.ຈດການຂມນສະຖາບນToolStripMenuItem.Click += new System.EventHandler(this.ຈດການຂມນສະຖາບນToolStripMenuItem_Click);
            // 
            // ລາຍງານToolStripMenuItem
            // 
            this.ລາຍງານToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ລາຍງານນກສກສາເຂາພກToolStripMenuItem,
            this.ລາຍງານນກສກສາໝດກຳນດພກເຊາToolStripMenuItem});
            this.ລາຍງານToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ລາຍງານToolStripMenuItem.Image")));
            this.ລາຍງານToolStripMenuItem.Name = "ລາຍງານToolStripMenuItem";
            this.ລາຍງານToolStripMenuItem.Size = new System.Drawing.Size(93, 33);
            this.ລາຍງານToolStripMenuItem.Text = "ລາຍງານ";
            // 
            // crToolStripTextBox1
            // 
            this.crToolStripTextBox1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.crToolStripTextBox1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.crToolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.crToolStripTextBox1.Font = new System.Drawing.Font("Saysettha OT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crToolStripTextBox1.Name = "crToolStripTextBox1";
            this.crToolStripTextBox1.Size = new System.Drawing.Size(20, 33);
            this.crToolStripTextBox1.Text = "x";
            this.crToolStripTextBox1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.crToolStripTextBox1.Click += new System.EventHandler(this.crToolStripTextBox1_Click_1);
            // 
            // ລາຍງານນກສກສາເຂາພກToolStripMenuItem
            // 
            this.ລາຍງານນກສກສາເຂາພກToolStripMenuItem.Name = "ລາຍງານນກສກສາເຂາພກToolStripMenuItem";
            this.ລາຍງານນກສກສາເຂາພກToolStripMenuItem.Size = new System.Drawing.Size(301, 32);
            this.ລາຍງານນກສກສາເຂາພກToolStripMenuItem.Text = "ລາຍງານນັກສຶກສາເຂົ້າພັັກ";
            // 
            // ລາຍງານນກສກສາໝດກຳນດພກເຊາToolStripMenuItem
            // 
            this.ລາຍງານນກສກສາໝດກຳນດພກເຊາToolStripMenuItem.Name = "ລາຍງານນກສກສາໝດກຳນດພກເຊາToolStripMenuItem";
            this.ລາຍງານນກສກສາໝດກຳນດພກເຊາToolStripMenuItem.Size = new System.Drawing.Size(301, 32);
            this.ລາຍງານນກສກສາໝດກຳນດພກເຊາToolStripMenuItem.Text = "ລາຍງານນັກສຶກສາໝົດກຳນົດພັກເຊົາ";
            // 
            // ອອກຈາລະບບToolStripMenuItem
            // 
            this.ອອກຈາລະບບToolStripMenuItem.Name = "ອອກຈາລະບບToolStripMenuItem";
            this.ອອກຈາລະບບToolStripMenuItem.Size = new System.Drawing.Size(110, 33);
            this.ອອກຈາລະບບToolStripMenuItem.Text = "ອອກຈາລະບົບ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 621);
            this.ControlBox = false;
            this.Controls.Add(this.panel_show);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dormitory";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_show.ResumeLayout(false);
            this.panel_show.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_show;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem register;
        private System.Windows.Forms.ToolStripMenuItem ຊຳລະຄາຫToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ຈດການຂມນToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ຈດການຂມນຕກToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ຈດການຂມນຊນToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ຈດການຂມນປະເພດຫອງToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ຈດການຂມນສະຖາບນToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ລາຍງານToolStripMenuItem;
        private CrystalDecisions.Windows.Forms.CRToolStripTextBox crToolStripTextBox1;
        private System.Windows.Forms.ToolStripMenuItem ລາຍງານນກສກສາເຂາພກToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ລາຍງານນກສກສາໝດກຳນດພກເຊາToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ອອກຈາລະບບToolStripMenuItem;
    }
}

