namespace StudentManagementSystem
{
    partial class frmEntryResults
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
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdClass2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.DatagridEntryResult = new System.Windows.Forms.DataGridView();
            this.txtidentry = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdClass = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DataGridshowresult = new System.Windows.Forms.DataGridView();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CmdSubject = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Txtmarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridEntryResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridshowresult)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Magenta;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(507, 519);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 34);
            this.btnSave.TabIndex = 71;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(-32, 263);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1220, 20);
            this.panel1.TabIndex = 69;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cmdClass2
            // 
            this.cmdClass2.FormattingEnabled = true;
            this.cmdClass2.Location = new System.Drawing.Point(356, 365);
            this.cmdClass2.Margin = new System.Windows.Forms.Padding(4);
            this.cmdClass2.Name = "cmdClass2";
            this.cmdClass2.Size = new System.Drawing.Size(150, 25);
            this.cmdClass2.TabIndex = 68;
            this.cmdClass2.SelectedIndexChanged += new System.EventHandler(this.cmdClass2_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Info;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(527, 369);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 17);
            this.label7.TabIndex = 67;
            this.label7.Text = "ID :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // DatagridEntryResult
            // 
            this.DatagridEntryResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DatagridEntryResult.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DatagridEntryResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatagridEntryResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CmdSubject,
            this.Txtmarks});
            this.DatagridEntryResult.GridColor = System.Drawing.SystemColors.HighlightText;
            this.DatagridEntryResult.Location = new System.Drawing.Point(4, 412);
            this.DatagridEntryResult.Margin = new System.Windows.Forms.Padding(4);
            this.DatagridEntryResult.Name = "DatagridEntryResult";
            this.DatagridEntryResult.Size = new System.Drawing.Size(1164, 100);
            this.DatagridEntryResult.TabIndex = 66;
            this.DatagridEntryResult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatagridEntryResult_CellContentClick);
            // 
            // txtidentry
            // 
            this.txtidentry.Location = new System.Drawing.Point(567, 365);
            this.txtidentry.Margin = new System.Windows.Forms.Padding(4);
            this.txtidentry.Multiline = true;
            this.txtidentry.Name = "txtidentry";
            this.txtidentry.Size = new System.Drawing.Size(177, 25);
            this.txtidentry.TabIndex = 65;
            this.txtidentry.TextChanged += new System.EventHandler(this.txtserch2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Info;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(420, 317);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 33);
            this.label5.TabIndex = 64;
            this.label5.Text = "Entry Result";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cmdClass
            // 
            this.cmdClass.FormattingEnabled = true;
            this.cmdClass.Location = new System.Drawing.Point(356, 90);
            this.cmdClass.Margin = new System.Windows.Forms.Padding(4);
            this.cmdClass.Name = "cmdClass";
            this.cmdClass.Size = new System.Drawing.Size(150, 25);
            this.cmdClass.TabIndex = 63;
            this.cmdClass.SelectedIndexChanged += new System.EventHandler(this.cmdClass_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(527, 94);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 62;
            this.label3.Text = "ID :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // DataGridshowresult
            // 
            this.DataGridshowresult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridshowresult.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.DataGridshowresult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridshowresult.GridColor = System.Drawing.SystemColors.HighlightText;
            this.DataGridshowresult.Location = new System.Drawing.Point(4, 133);
            this.DataGridshowresult.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridshowresult.Name = "DataGridshowresult";
            this.DataGridshowresult.Size = new System.Drawing.Size(1164, 100);
            this.DataGridshowresult.TabIndex = 61;
            this.DataGridshowresult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridshowresult_CellContentClick);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(567, 90);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtsearch.Multiline = true;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(177, 25);
            this.txtsearch.TabIndex = 60;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(427, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 33);
            this.label1.TabIndex = 59;
            this.label1.Text = "Show Result";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(299, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 72;
            this.label4.Text = "Class :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(299, 369);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 72;
            this.label2.Text = "Class :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(767, 92);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 21);
            this.label6.TabIndex = 73;
            this.label6.Text = "Serch";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // CmdSubject
            // 
            this.CmdSubject.HeaderText = "Subjects";
            this.CmdSubject.Name = "CmdSubject";
            // 
            // Txtmarks
            // 
            this.Txtmarks.HeaderText = "Marks";
            this.Txtmarks.Name = "Txtmarks";
            // 
            // frmEntryResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 588);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmdClass2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DatagridEntryResult);
            this.Controls.Add(this.txtidentry);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmdClass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DataGridshowresult);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmEntryResults";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEntryResults";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEntryResults_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatagridEntryResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridshowresult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmdClass2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DatagridEntryResult;
        private System.Windows.Forms.TextBox txtidentry;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmdClass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DataGridshowresult;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewComboBoxColumn CmdSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Txtmarks;
    }
}