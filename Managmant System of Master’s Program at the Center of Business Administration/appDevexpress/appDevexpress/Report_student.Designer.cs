namespace appDevexpress
{
    partial class Report_student
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
            this.components = new System.ComponentModel.Container();
            this.gradeTableAdapter = new appDevexpress.data_baseTableAdapters.gradeTableAdapter();
            this.documentViewerRibbonController1 = new DevExpress.XtraPrinting.Preview.DocumentViewerRibbonController(this.components);
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.documentViewerRibbonController1)).BeginInit();
            this.SuspendLayout();
            // 
            // gradeTableAdapter
            // 
            this.gradeTableAdapter.ClearBeforeFill = true;
            // 
            // documentViewerRibbonController1
            // 
            this.documentViewerRibbonController1.RibbonControl = null;
            this.documentViewerRibbonController1.RibbonStatusBar = null;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(176)))), ((int)(((byte)(181)))));
            this.metroTile2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile2.Location = new System.Drawing.Point(204, 192);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(233, 77);
            this.metroTile2.TabIndex = 4;
            this.metroTile2.Text = "Informaition Students";
            this.metroTile2.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile2.UseCustomBackColor = true;
            this.metroTile2.UseCustomForeColor = true;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.UseStyleColors = true;
            this.metroTile2.UseTileImage = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(159)))), ((int)(((byte)(122)))));
            this.metroTile3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile3.Location = new System.Drawing.Point(204, 109);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(233, 77);
            this.metroTile3.TabIndex = 5;
            this.metroTile3.Text = "Brife Attendance";
            this.metroTile3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile3.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile3.UseCustomBackColor = true;
            this.metroTile3.UseCustomForeColor = true;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.UseStyleColors = true;
            this.metroTile3.UseTileImage = true;
            this.metroTile3.Click += new System.EventHandler(this.metroTile3_Click);
            // 
            // Report_student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 335);
            this.Controls.Add(this.metroTile3);
            this.Controls.Add(this.metroTile2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Report_student";
            this.Text = "Report_student";
            this.Load += new System.EventHandler(this.Report_student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.documentViewerRibbonController1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private data_baseTableAdapters.gradeTableAdapter gradeTableAdapter;
        private DevExpress.XtraPrinting.Preview.DocumentViewerRibbonController documentViewerRibbonController1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile3;
    }
}