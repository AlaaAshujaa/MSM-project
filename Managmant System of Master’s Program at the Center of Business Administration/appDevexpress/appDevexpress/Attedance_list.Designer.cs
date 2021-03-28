namespace appDevexpress
{
    partial class Attedance_list
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attedance_list));
            this.gradeTableAdapter = new appDevexpress.data_baseTableAdapters.gradeTableAdapter();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.attendanceListview1BindingSource = new System.Windows.Forms.BindingSource();
            this.data_base = new appDevexpress.data_base();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnum_intake = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstudent_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colM_F = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfirst_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmiddle_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfamily_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.databaseBindingSource = new System.Windows.Forms.BindingSource();
            this.attendanceList_view1TableAdapter = new appDevexpress.data_baseTableAdapters.AttendanceList_view1TableAdapter();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.num_intakeToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.look1 = new System.Windows.Forms.ToolStripComboBox();
            this.nameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.look2 = new System.Windows.Forms.ToolStripComboBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.addCoursesBindingSource = new System.Windows.Forms.BindingSource();
            this.add_CoursesTableAdapter = new appDevexpress.data_baseTableAdapters.Add_CoursesTableAdapter();
            this.intakeBindingSource = new System.Windows.Forms.BindingSource();
            this.intakeTableAdapter = new appDevexpress.data_baseTableAdapters.IntakeTableAdapter();
            this.searchControl2 = new DevExpress.XtraEditors.SearchControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceListview1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_base)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addCoursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intakeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gradeTableAdapter
            // 
            this.gradeTableAdapter.ClearBeforeFill = true;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Location = new System.Drawing.Point(20, 90);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(622, 298);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.attendanceListview1BindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 20);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(618, 276);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // attendanceListview1BindingSource
            // 
            this.attendanceListview1BindingSource.DataMember = "AttendanceList_view1";
            this.attendanceListview1BindingSource.DataSource = this.data_base;
            // 
            // data_base
            // 
            this.data_base.DataSetName = "data_base";
            this.data_base.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnum_intake,
            this.colstudent_id,
            this.colM_F,
            this.colfirst_name,
            this.colmiddle_name,
            this.colfamily_name,
            this.colname});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colnum_intake
            // 
            this.colnum_intake.Caption = "Intake";
            this.colnum_intake.FieldName = "num_intake";
            this.colnum_intake.Name = "colnum_intake";
            this.colnum_intake.Visible = true;
            this.colnum_intake.VisibleIndex = 5;
            this.colnum_intake.Width = 93;
            // 
            // colstudent_id
            // 
            this.colstudent_id.Caption = "ID#";
            this.colstudent_id.FieldName = "student_id";
            this.colstudent_id.Name = "colstudent_id";
            this.colstudent_id.Visible = true;
            this.colstudent_id.VisibleIndex = 0;
            this.colstudent_id.Width = 86;
            // 
            // colM_F
            // 
            this.colM_F.Caption = "Title";
            this.colM_F.FieldName = "M_F";
            this.colM_F.Name = "colM_F";
            this.colM_F.Visible = true;
            this.colM_F.VisibleIndex = 1;
            this.colM_F.Width = 48;
            // 
            // colfirst_name
            // 
            this.colfirst_name.Caption = "F_Name";
            this.colfirst_name.FieldName = "first_name";
            this.colfirst_name.Name = "colfirst_name";
            this.colfirst_name.Visible = true;
            this.colfirst_name.VisibleIndex = 2;
            this.colfirst_name.Width = 93;
            // 
            // colmiddle_name
            // 
            this.colmiddle_name.Caption = "M_Name";
            this.colmiddle_name.FieldName = "middle_name";
            this.colmiddle_name.Name = "colmiddle_name";
            this.colmiddle_name.Visible = true;
            this.colmiddle_name.VisibleIndex = 3;
            this.colmiddle_name.Width = 93;
            // 
            // colfamily_name
            // 
            this.colfamily_name.Caption = "L_Name";
            this.colfamily_name.FieldName = "family_name";
            this.colfamily_name.Name = "colfamily_name";
            this.colfamily_name.Visible = true;
            this.colfamily_name.VisibleIndex = 4;
            this.colfamily_name.Width = 93;
            // 
            // colname
            // 
            this.colname.Caption = "Course";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 6;
            this.colname.Width = 96;
            // 
            // databaseBindingSource
            // 
            this.databaseBindingSource.DataSource = this.data_base;
            this.databaseBindingSource.Position = 0;
            // 
            // attendanceList_view1TableAdapter
            // 
            this.attendanceList_view1TableAdapter.ClearBeforeFill = true;
            // 
            // searchControl1
            // 
            this.searchControl1.Client = this.gridControl1;
            this.searchControl1.Location = new System.Drawing.Point(649, 63);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Properties.Client = this.gridControl1;
            this.searchControl1.Properties.ShowDefaultButtonsMode = DevExpress.XtraEditors.Repository.ShowDefaultButtonsMode.Always;
            this.searchControl1.Size = new System.Drawing.Size(241, 20);
            this.searchControl1.TabIndex = 2;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton2);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Location = new System.Drawing.Point(649, 90);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(261, 298);
            this.panelControl1.TabIndex = 3;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(25, 112);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(198, 36);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "PRINT";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.simpleButton1.Location = new System.Drawing.Point(25, 49);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(198, 41);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.num_intakeToolStripLabel,
            this.look1,
            this.nameToolStripLabel,
            this.look2,
            this.fillByToolStripButton,
            this.toolStripSeparator1,
            this.toolStripButton1});
            this.fillByToolStrip.Location = new System.Drawing.Point(20, 60);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(890, 25);
            this.fillByToolStrip.TabIndex = 4;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // num_intakeToolStripLabel
            // 
            this.num_intakeToolStripLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_intakeToolStripLabel.Name = "num_intakeToolStripLabel";
            this.num_intakeToolStripLabel.Size = new System.Drawing.Size(48, 22);
            this.num_intakeToolStripLabel.Text = "Intake";
            // 
            // look1
            // 
            this.look1.Name = "look1";
            this.look1.Size = new System.Drawing.Size(100, 25);
            // 
            // nameToolStripLabel
            // 
            this.nameToolStripLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameToolStripLabel.Name = "nameToolStripLabel";
            this.nameToolStripLabel.Size = new System.Drawing.Size(63, 22);
            this.nameToolStripLabel.Text = "COURSE";
            // 
            // look2
            // 
            this.look2.Name = "look2";
            this.look2.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(61, 22);
            this.fillByToolStripButton.Text = "Display";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(63, 22);
            this.toolStripButton1.Text = "Refresh";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // addCoursesBindingSource
            // 
            this.addCoursesBindingSource.DataMember = "Add_Courses";
            this.addCoursesBindingSource.DataSource = this.data_base;
            // 
            // add_CoursesTableAdapter
            // 
            this.add_CoursesTableAdapter.ClearBeforeFill = true;
            // 
            // intakeBindingSource
            // 
            this.intakeBindingSource.DataMember = "Intake";
            this.intakeBindingSource.DataSource = this.data_base;
            // 
            // intakeTableAdapter
            // 
            this.intakeTableAdapter.ClearBeforeFill = true;
            // 
            // searchControl2
            // 
            this.searchControl2.Client = this.gridControl1;
            this.searchControl2.Location = new System.Drawing.Point(667, 63);
            this.searchControl2.Name = "searchControl2";
            this.searchControl2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl2.Properties.Client = this.gridControl1;
            this.searchControl2.Properties.ShowDefaultButtonsMode = DevExpress.XtraEditors.Repository.ShowDefaultButtonsMode.Always;
            this.searchControl2.Size = new System.Drawing.Size(223, 20);
            this.searchControl2.TabIndex = 5;
            // 
            // Attedance_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 483);
            this.Controls.Add(this.searchControl2);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.searchControl1);
            this.Controls.Add(this.groupControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Attedance_list";
            this.Text = "Attedance_list";
            this.Load += new System.EventHandler(this.Attedance_list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceListview1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_base)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addCoursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intakeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private data_baseTableAdapters.gradeTableAdapter gradeTableAdapter;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource databaseBindingSource;
        private data_base data_base;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource attendanceListview1BindingSource;
        private data_baseTableAdapters.AttendanceList_view1TableAdapter attendanceList_view1TableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colnum_intake;
        private DevExpress.XtraGrid.Columns.GridColumn colstudent_id;
        private DevExpress.XtraGrid.Columns.GridColumn colM_F;
        private DevExpress.XtraGrid.Columns.GridColumn colfirst_name;
        private DevExpress.XtraGrid.Columns.GridColumn colmiddle_name;
        private DevExpress.XtraGrid.Columns.GridColumn colfamily_name;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel num_intakeToolStripLabel;
        private System.Windows.Forms.ToolStripLabel nameToolStripLabel;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.ToolStripComboBox look1;
        private System.Windows.Forms.ToolStripComboBox look2;
        private System.Windows.Forms.BindingSource addCoursesBindingSource;
        private data_baseTableAdapters.Add_CoursesTableAdapter add_CoursesTableAdapter;
        private System.Windows.Forms.BindingSource intakeBindingSource;
        private data_baseTableAdapters.IntakeTableAdapter intakeTableAdapter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private DevExpress.XtraEditors.SearchControl searchControl2;
    }
}