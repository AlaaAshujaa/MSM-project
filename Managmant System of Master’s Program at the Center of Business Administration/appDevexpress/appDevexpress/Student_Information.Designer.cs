namespace appDevexpress
{
    partial class Student_Information_cs
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
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btnmod = new MetroFramework.Controls.MetroButton();
            this.gridControl1 = new System.Windows.Forms.DataGridView();
            this.btnExport = new MetroFramework.Controls.MetroButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl3.Location = new System.Drawing.Point(259, 32);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(230, 31);
            this.labelControl3.TabIndex = 438;
            this.labelControl3.Text = "Students Information";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::appDevexpress.Properties.Resources.logo1;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(149, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 437;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(154)))));
            this.pictureBox6.Location = new System.Drawing.Point(-46, 102);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(950, 3);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 436;
            this.pictureBox6.TabStop = false;
            // 
            // btnmod
            // 
            this.btnmod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(93)))), ((int)(((byte)(154)))));
            this.btnmod.Location = new System.Drawing.Point(430, 558);
            this.btnmod.Name = "btnmod";
            this.btnmod.Size = new System.Drawing.Size(180, 41);
            this.btnmod.TabIndex = 460;
            this.btnmod.Text = "Close";
            this.btnmod.UseCustomBackColor = true;
            this.btnmod.UseCustomForeColor = true;
            this.btnmod.UseSelectable = true;
            this.btnmod.Click += new System.EventHandler(this.btnmod_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.gridControl1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridControl1.Location = new System.Drawing.Point(17, 158);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(843, 375);
            this.gridControl1.TabIndex = 459;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(171)))), ((int)(((byte)(67)))));
            this.btnExport.Location = new System.Drawing.Point(231, 558);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(193, 41);
            this.btnExport.TabIndex = 461;
            this.btnExport.Text = "Convert to Excel";
            this.btnExport.UseCustomBackColor = true;
            this.btnExport.UseCustomForeColor = true;
            this.btnExport.UseSelectable = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // Student_Information_cs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 611);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnmod);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Student_Information_cs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student_Information_cs";
            this.Load += new System.EventHandler(this.Student_Information_cs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private MetroFramework.Controls.MetroButton btnmod;
        private System.Windows.Forms.DataGridView gridControl1;
        private MetroFramework.Controls.MetroButton btnExport;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}