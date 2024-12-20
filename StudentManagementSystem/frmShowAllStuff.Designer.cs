namespace StudentManagementSystem
{
    partial class frmShowAllStuff
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
            this.datagridStuff = new System.Windows.Forms.DataGridView();
            this.cmbDesignation = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAllstuff = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datagridStuff)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridStuff
            // 
            this.datagridStuff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridStuff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridStuff.Location = new System.Drawing.Point(43, 176);
            this.datagridStuff.Name = "datagridStuff";
            this.datagridStuff.Size = new System.Drawing.Size(1150, 420);
            this.datagridStuff.TabIndex = 8;
            // 
            // cmbDesignation
            // 
            this.cmbDesignation.FormattingEnabled = true;
            this.cmbDesignation.Location = new System.Drawing.Point(401, 109);
            this.cmbDesignation.Name = "cmbDesignation";
            this.cmbDesignation.Size = new System.Drawing.Size(185, 25);
            this.cmbDesignation.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(605, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAllstuff
            // 
            this.btnAllstuff.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAllstuff.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllstuff.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAllstuff.Location = new System.Drawing.Point(697, 110);
            this.btnAllstuff.Name = "btnAllstuff";
            this.btnAllstuff.Size = new System.Drawing.Size(75, 23);
            this.btnAllstuff.TabIndex = 6;
            this.btnAllstuff.Text = "All";
            this.btnAllstuff.UseVisualStyleBackColor = false;
            this.btnAllstuff.Click += new System.EventHandler(this.btnAllstuff_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(494, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Stuff List";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmShowAllStuff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 588);
            this.Controls.Add(this.datagridStuff);
            this.Controls.Add(this.cmbDesignation);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAllstuff);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmShowAllStuff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmShowAllStuff";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmShowAllStuff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridStuff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridStuff;
        private System.Windows.Forms.ComboBox cmbDesignation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAllstuff;
        private System.Windows.Forms.Label label1;
    }
}