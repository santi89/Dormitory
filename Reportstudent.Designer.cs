namespace C_Sharp_2_Project
{
    partial class Reportstudent
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
            this.datetimepick = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePickerend = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.crystalReportV = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.studentreport1 = new C_Sharp_2_Project.studentreport();
            this.SuspendLayout();
            // 
            // datetimepick
            // 
            this.datetimepick.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.datetimepick.CustomFormat = "yyyy-MM-dd";
            this.datetimepick.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetimepick.Location = new System.Drawing.Point(289, 82);
            this.datetimepick.Name = "datetimepick";
            this.datetimepick.Size = new System.Drawing.Size(193, 42);
            this.datetimepick.TabIndex = 2;
            this.datetimepick.ValueChanged += new System.EventHandler(this.datetimepick_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "ເລືອກວັນທີເລີ່ມເອີ້ນເບິ່ງ";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Location = new System.Drawing.Point(981, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "ເບິ່ງ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePickerend
            // 
            this.dateTimePickerend.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePickerend.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerend.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerend.Location = new System.Drawing.Point(702, 81);
            this.dateTimePickerend.Name = "dateTimePickerend";
            this.dateTimePickerend.Size = new System.Drawing.Size(193, 42);
            this.dateTimePickerend.TabIndex = 2;
            this.dateTimePickerend.ValueChanged += new System.EventHandler(this.dateTimePickerend_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(595, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "ຮອດວັນທີ";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(665, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "ເບິ່ງລາຍງານການເຂົ້າພັກ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(1363, -3);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(28, 36);
            this.label11.TabIndex = 22;
            this.label11.Text = "X";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // crystalReportV
            // 
            this.crystalReportV.ActiveViewIndex = 0;
            this.crystalReportV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crystalReportV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportV.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportV.Location = new System.Drawing.Point(0, 131);
            this.crystalReportV.Name = "crystalReportV";
            this.crystalReportV.ReportSource = this.studentreport1;
            this.crystalReportV.Size = new System.Drawing.Size(1391, 578);
            this.crystalReportV.TabIndex = 23;
            // 
            // Reportstudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(1391, 703);
            this.Controls.Add(this.crystalReportV);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerend);
            this.Controls.Add(this.datetimepick);
            this.Font = new System.Drawing.Font("Saysettha OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.Name = "Reportstudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportstudent";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Reportstudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker datetimepick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePickerend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportV;
        private studentreport studentreport1;
    }
}