namespace StudentManagementSystem
{
    partial class sms
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
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teachartsEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertNewTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entryNewStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDeleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stuffEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertNewStuffInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iDWiseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cashReciveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teachersReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllTeachersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllStuffsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entryResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip3
            // 
            this.menuStrip3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.menuStrip3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuStrip3.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip3.GripMargin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.teachartsEntryToolStripMenuItem,
            this.studentEntryToolStripMenuItem,
            this.stuffEntryToolStripMenuItem,
            this.paymentHistoryToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.detailsToolStripMenuItem,
            this.sToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(152, 588);
            this.menuStrip3.TabIndex = 3;
            this.menuStrip3.Text = "menuStrip3";
            this.menuStrip3.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip3_ItemClicked);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(139, 25);
            this.homeToolStripMenuItem.Text = " Home";
            // 
            // teachartsEntryToolStripMenuItem
            // 
            this.teachartsEntryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertNewTeacherToolStripMenuItem,
            this.updateDeleteToolStripMenuItem});
            this.teachartsEntryToolStripMenuItem.Name = "teachartsEntryToolStripMenuItem";
            this.teachartsEntryToolStripMenuItem.Size = new System.Drawing.Size(139, 25);
            this.teachartsEntryToolStripMenuItem.Text = "Teacharts Entry";
            this.teachartsEntryToolStripMenuItem.Click += new System.EventHandler(this.teachartsEntryToolStripMenuItem_Click);
            // 
            // insertNewTeacherToolStripMenuItem
            // 
            this.insertNewTeacherToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.insertNewTeacherToolStripMenuItem.Name = "insertNewTeacherToolStripMenuItem";
            this.insertNewTeacherToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.insertNewTeacherToolStripMenuItem.Text = "Insert New Teacher";
            this.insertNewTeacherToolStripMenuItem.Click += new System.EventHandler(this.insertNewTeacherToolStripMenuItem_Click);
            // 
            // updateDeleteToolStripMenuItem
            // 
            this.updateDeleteToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.updateDeleteToolStripMenuItem.Name = "updateDeleteToolStripMenuItem";
            this.updateDeleteToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.updateDeleteToolStripMenuItem.Text = "Update /Delete ";
            this.updateDeleteToolStripMenuItem.Click += new System.EventHandler(this.updateDeleteToolStripMenuItem_Click);
            // 
            // studentEntryToolStripMenuItem
            // 
            this.studentEntryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entryNewStudentToolStripMenuItem,
            this.updateDeleteToolStripMenuItem1});
            this.studentEntryToolStripMenuItem.Name = "studentEntryToolStripMenuItem";
            this.studentEntryToolStripMenuItem.Size = new System.Drawing.Size(139, 25);
            this.studentEntryToolStripMenuItem.Text = "Students Entry";
            // 
            // entryNewStudentToolStripMenuItem
            // 
            this.entryNewStudentToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.entryNewStudentToolStripMenuItem.Name = "entryNewStudentToolStripMenuItem";
            this.entryNewStudentToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.entryNewStudentToolStripMenuItem.Text = "Entry New Student";
            this.entryNewStudentToolStripMenuItem.Click += new System.EventHandler(this.entryNewStudentToolStripMenuItem_Click);
            // 
            // updateDeleteToolStripMenuItem1
            // 
            this.updateDeleteToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.updateDeleteToolStripMenuItem1.Name = "updateDeleteToolStripMenuItem1";
            this.updateDeleteToolStripMenuItem1.Size = new System.Drawing.Size(226, 26);
            this.updateDeleteToolStripMenuItem1.Text = "Update/Delete";
            this.updateDeleteToolStripMenuItem1.Click += new System.EventHandler(this.updateDeleteToolStripMenuItem1_Click);
            // 
            // stuffEntryToolStripMenuItem
            // 
            this.stuffEntryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertNewStuffInfoToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.stuffEntryToolStripMenuItem.Name = "stuffEntryToolStripMenuItem";
            this.stuffEntryToolStripMenuItem.Size = new System.Drawing.Size(139, 25);
            this.stuffEntryToolStripMenuItem.Text = "Stuff Entry";
            // 
            // insertNewStuffInfoToolStripMenuItem
            // 
            this.insertNewStuffInfoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.insertNewStuffInfoToolStripMenuItem.Name = "insertNewStuffInfoToolStripMenuItem";
            this.insertNewStuffInfoToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.insertNewStuffInfoToolStripMenuItem.Text = "Insert New Stuff Info";
            this.insertNewStuffInfoToolStripMenuItem.Click += new System.EventHandler(this.insertNewStuffInfoToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.updateToolStripMenuItem.Text = "Update /Delete";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // paymentHistoryToolStripMenuItem
            // 
            this.paymentHistoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iDWiseHistoryToolStripMenuItem,
            this.cashReciveToolStripMenuItem});
            this.paymentHistoryToolStripMenuItem.Name = "paymentHistoryToolStripMenuItem";
            this.paymentHistoryToolStripMenuItem.Size = new System.Drawing.Size(139, 25);
            this.paymentHistoryToolStripMenuItem.Text = "Payment History";
            this.paymentHistoryToolStripMenuItem.Click += new System.EventHandler(this.paymentHistoryToolStripMenuItem_Click);
            // 
            // iDWiseHistoryToolStripMenuItem
            // 
            this.iDWiseHistoryToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.iDWiseHistoryToolStripMenuItem.Name = "iDWiseHistoryToolStripMenuItem";
            this.iDWiseHistoryToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.iDWiseHistoryToolStripMenuItem.Text = "ID wise History";
            this.iDWiseHistoryToolStripMenuItem.Click += new System.EventHandler(this.iDWiseHistoryToolStripMenuItem_Click);
            // 
            // cashReciveToolStripMenuItem
            // 
            this.cashReciveToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cashReciveToolStripMenuItem.Name = "cashReciveToolStripMenuItem";
            this.cashReciveToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.cashReciveToolStripMenuItem.Text = "Payment Recive";
            this.cashReciveToolStripMenuItem.Click += new System.EventHandler(this.cashReciveToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentReportToolStripMenuItem,
            this.teachersReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(139, 25);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // studentReportToolStripMenuItem
            // 
            this.studentReportToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.studentReportToolStripMenuItem.Name = "studentReportToolStripMenuItem";
            this.studentReportToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.studentReportToolStripMenuItem.Text = "Student Report";
            // 
            // teachersReportToolStripMenuItem
            // 
            this.teachersReportToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.teachersReportToolStripMenuItem.Name = "teachersReportToolStripMenuItem";
            this.teachersReportToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.teachersReportToolStripMenuItem.Text = "Teachers Report";
            // 
            // detailsToolStripMenuItem
            // 
            this.detailsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAllStudentsToolStripMenuItem,
            this.showAllTeachersToolStripMenuItem,
            this.showAllStuffsToolStripMenuItem});
            this.detailsToolStripMenuItem.Name = "detailsToolStripMenuItem";
            this.detailsToolStripMenuItem.Size = new System.Drawing.Size(139, 25);
            this.detailsToolStripMenuItem.Text = "Details";
            // 
            // showAllStudentsToolStripMenuItem
            // 
            this.showAllStudentsToolStripMenuItem.BackColor = System.Drawing.Color.Indigo;
            this.showAllStudentsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.showAllStudentsToolStripMenuItem.Name = "showAllStudentsToolStripMenuItem";
            this.showAllStudentsToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.showAllStudentsToolStripMenuItem.Text = "Show All Students";
            this.showAllStudentsToolStripMenuItem.Click += new System.EventHandler(this.showAllStudentsToolStripMenuItem_Click);
            // 
            // showAllTeachersToolStripMenuItem
            // 
            this.showAllTeachersToolStripMenuItem.BackColor = System.Drawing.Color.Plum;
            this.showAllTeachersToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.showAllTeachersToolStripMenuItem.Name = "showAllTeachersToolStripMenuItem";
            this.showAllTeachersToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.showAllTeachersToolStripMenuItem.Text = "Show All Teachers";
            this.showAllTeachersToolStripMenuItem.Click += new System.EventHandler(this.showAllTeachersToolStripMenuItem_Click);
            // 
            // showAllStuffsToolStripMenuItem
            // 
            this.showAllStuffsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.showAllStuffsToolStripMenuItem.Name = "showAllStuffsToolStripMenuItem";
            this.showAllStuffsToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.showAllStuffsToolStripMenuItem.Text = "Show All Stuffs";
            this.showAllStuffsToolStripMenuItem.Click += new System.EventHandler(this.showAllStuffsToolStripMenuItem_Click);
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entryResultToolStripMenuItem,
            this.showResultsToolStripMenuItem});
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.Size = new System.Drawing.Size(139, 25);
            this.sToolStripMenuItem.Text = "Results";
            // 
            // entryResultToolStripMenuItem
            // 
            this.entryResultToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.entryResultToolStripMenuItem.Name = "entryResultToolStripMenuItem";
            this.entryResultToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.entryResultToolStripMenuItem.Text = "Entry Results";
            this.entryResultToolStripMenuItem.Click += new System.EventHandler(this.entryResultToolStripMenuItem_Click);
            // 
            // showResultsToolStripMenuItem
            // 
            this.showResultsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.showResultsToolStripMenuItem.Name = "showResultsToolStripMenuItem";
            this.showResultsToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.showResultsToolStripMenuItem.Text = "Show Results";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox1.Location = new System.Drawing.Point(152, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1089, 41);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "           School Managent System";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // sms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 588);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip3);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "sms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teachartsEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teachersReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllStudentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllTeachersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertNewTeacherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entryNewStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDeleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem stuffEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertNewStuffInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iDWiseHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cashReciveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllStuffsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entryResultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showResultsToolStripMenuItem;
    }
}

