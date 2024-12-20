namespace StudentManagementSystem
{
    partial class frmRecivePayment
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
            this.cmdClass = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.datagridupdate = new System.Windows.Forms.DataGridView();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmdClass2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Datagridupdate2 = new System.Windows.Forms.DataGridView();
            this.txtserch2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtcomment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtOther = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MonthlyFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Txtmustfee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtexamfee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridupdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Datagridupdate2)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdClass
            // 
            this.cmdClass.FormattingEnabled = true;
            this.cmdClass.Location = new System.Drawing.Point(390, 130);
            this.cmdClass.Margin = new System.Windows.Forms.Padding(4);
            this.cmdClass.Name = "cmdClass";
            this.cmdClass.Size = new System.Drawing.Size(150, 25);
            this.cmdClass.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(333, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 47;
            this.label4.Text = "Class :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(561, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 48;
            this.label3.Text = "ID :";
            // 
            // datagridupdate
            // 
            this.datagridupdate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridupdate.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.datagridupdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridupdate.GridColor = System.Drawing.SystemColors.HighlightText;
            this.datagridupdate.Location = new System.Drawing.Point(38, 176);
            this.datagridupdate.Margin = new System.Windows.Forms.Padding(4);
            this.datagridupdate.Name = "datagridupdate";
            this.datagridupdate.Size = new System.Drawing.Size(1164, 100);
            this.datagridupdate.TabIndex = 46;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(601, 130);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtsearch.Multiline = true;
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(177, 25);
            this.txtsearch.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(800, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 44;
            this.label2.Text = "Serch";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(461, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 33);
            this.label1.TabIndex = 43;
            this.label1.Text = "Payment History";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Info;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(454, 360);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(233, 33);
            this.label5.TabIndex = 50;
            this.label5.Text = "Recive Payment";
            // 
            // cmdClass2
            // 
            this.cmdClass2.FormattingEnabled = true;
            this.cmdClass2.Location = new System.Drawing.Point(390, 410);
            this.cmdClass2.Margin = new System.Windows.Forms.Padding(4);
            this.cmdClass2.Name = "cmdClass2";
            this.cmdClass2.Size = new System.Drawing.Size(150, 25);
            this.cmdClass2.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Info;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(333, 414);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 54;
            this.label6.Text = "Class :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Info;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(561, 414);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 17);
            this.label7.TabIndex = 55;
            this.label7.Text = "ID :";
            // 
            // Datagridupdate2
            // 
            this.Datagridupdate2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Datagridupdate2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Datagridupdate2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datagridupdate2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Txtmustfee,
            this.MonthlyFee,
            this.txtOther,
            this.txtcomment,
            this.txtexamfee});
            this.Datagridupdate2.GridColor = System.Drawing.SystemColors.HighlightText;
            this.Datagridupdate2.Location = new System.Drawing.Point(38, 446);
            this.Datagridupdate2.Margin = new System.Windows.Forms.Padding(4);
            this.Datagridupdate2.Name = "Datagridupdate2";
            this.Datagridupdate2.Size = new System.Drawing.Size(1164, 100);
            this.Datagridupdate2.TabIndex = 53;
            this.Datagridupdate2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Datagridupdate2_CellContentClick);
            // 
            // txtserch2
            // 
            this.txtserch2.Location = new System.Drawing.Point(601, 410);
            this.txtserch2.Margin = new System.Windows.Forms.Padding(4);
            this.txtserch2.Multiline = true;
            this.txtserch2.Name = "txtserch2";
            this.txtserch2.Size = new System.Drawing.Size(177, 25);
            this.txtserch2.TabIndex = 52;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(2, 306);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1220, 20);
            this.panel1.TabIndex = 57;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Magenta;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(541, 562);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 34);
            this.btnSave.TabIndex = 58;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(642, 562);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 34);
            this.btnDelete.TabIndex = 58;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.BlueViolet;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(804, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 58;
            this.button1.Text = "New ";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txtcomment
            // 
            this.txtcomment.HeaderText = "Comments";
            this.txtcomment.Name = "txtcomment";
            // 
            // txtOther
            // 
            this.txtOther.HeaderText = "Other";
            this.txtOther.Name = "txtOther";
            // 
            // MonthlyFee
            // 
            this.MonthlyFee.HeaderText = "Montllyfee";
            this.MonthlyFee.Name = "MonthlyFee";
            // 
            // Txtmustfee
            // 
            this.Txtmustfee.HeaderText = "Mustfee";
            this.Txtmustfee.Name = "Txtmustfee";
            // 
            // txtexamfee
            // 
            this.txtexamfee.HeaderText = "Examfee";
            this.txtexamfee.Name = "txtexamfee";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(861, 133);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 21);
            this.label8.TabIndex = 44;
            this.label8.Text = "All";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // frmRecivePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 588);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmdClass2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Datagridupdate2);
            this.Controls.Add(this.txtserch2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmdClass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datagridupdate);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmRecivePayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRecivePayment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRecivePayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridupdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Datagridupdate2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmdClass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView datagridupdate;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmdClass2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView Datagridupdate2;
        private System.Windows.Forms.TextBox txtserch2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Txtmustfee;
        private System.Windows.Forms.DataGridViewTextBoxColumn MonthlyFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtOther;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtcomment;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtexamfee;
        private System.Windows.Forms.Label label8;
    }
}