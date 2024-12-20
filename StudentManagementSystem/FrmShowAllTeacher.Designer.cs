namespace StudentManagementSystem
{
    partial class FrmShowAllTeacher
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
            this.datagridTeachars = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAllstudent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTeachaerSerch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridTeachars)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridTeachars
            // 
            this.datagridTeachars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridTeachars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridTeachars.Location = new System.Drawing.Point(25, 180);
            this.datagridTeachars.Name = "datagridTeachars";
            this.datagridTeachars.Size = new System.Drawing.Size(1150, 420);
            this.datagridTeachars.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(618, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAllstudent
            // 
            this.btnAllstudent.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAllstudent.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllstudent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAllstudent.Location = new System.Drawing.Point(710, 114);
            this.btnAllstudent.Name = "btnAllstudent";
            this.btnAllstudent.Size = new System.Drawing.Size(75, 23);
            this.btnAllstudent.TabIndex = 6;
            this.btnAllstudent.Text = "All";
            this.btnAllstudent.UseVisualStyleBackColor = false;
            this.btnAllstudent.Click += new System.EventHandler(this.btnAllstudent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(507, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Teachers List";
            // 
            // txtTeachaerSerch
            // 
            this.txtTeachaerSerch.Location = new System.Drawing.Point(412, 114);
            this.txtTeachaerSerch.Name = "txtTeachaerSerch";
            this.txtTeachaerSerch.Size = new System.Drawing.Size(201, 23);
            this.txtTeachaerSerch.TabIndex = 9;
            // 
            // FrmShowAllTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 588);
            this.Controls.Add(this.txtTeachaerSerch);
            this.Controls.Add(this.datagridTeachars);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAllstudent);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmShowAllTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmShowAllTeacher";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmShowAllTeacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridTeachars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridTeachars;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAllstudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTeachaerSerch;
    }
}