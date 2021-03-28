namespace appDevexpress
{
    partial class Attendance_Design
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attendance_Design));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.attendanceSheetviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.data_base = new appDevexpress.data_base();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colhoure_absence = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstudent_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colM_F = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfirst_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmiddle_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfamily_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnum_intake1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhoure_come = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.addCoursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.intakeTableAdapter = new appDevexpress.data_baseTableAdapters.IntakeTableAdapter();
            this.add_CoursesTableAdapter = new appDevexpress.data_baseTableAdapters.Add_CoursesTableAdapter();
            this.intakeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendanceSheet_viewTableAdapter = new appDevexpress.data_baseTableAdapters.AttendanceSheet_viewTableAdapter();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.fillByToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.num_intakeToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.look1 = new System.Windows.Forms.ToolStripComboBox();
            this.nameToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.look2 = new System.Windows.Forms.ToolStripComboBox();
            this.fillByToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.gradeTableAdapter = new appDevexpress.data_baseTableAdapters.gradeTableAdapter();
            this.searchControl2 = new DevExpress.XtraEditors.SearchControl();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceSheetviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_base)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addCoursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intakeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.fillByToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Location = new System.Drawing.Point(17, 88);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(728, 413);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "DATA";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // gridControl1
            // 
            this.gridControl1.AllowDrop = true;
            this.gridControl1.DataSource = this.attendanceSheetviewBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode2.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.gridControl1.Location = new System.Drawing.Point(2, 20);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(724, 391);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click_1);
            // 
            // attendanceSheetviewBindingSource
            // 
            this.attendanceSheetviewBindingSource.DataMember = "AttendanceSheet_view";
            this.attendanceSheetviewBindingSource.DataSource = this.data_base;
            // 
            // data_base
            // 
            this.data_base.DataSetName = "data_base";
            this.data_base.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colhoure_absence,
            this.coldate,
            this.colstudent_id,
            this.colM_F,
            this.colfirst_name,
            this.colmiddle_name,
            this.colfamily_name,
            this.colnum_intake1,
            this.colhoure_come,
            this.colname1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowGroupExpandAnimation = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsDetail.EnableMasterViewMode = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            // 
            // colhoure_absence
            // 
            this.colhoure_absence.FieldName = "houre_absence";
            this.colhoure_absence.Name = "colhoure_absence";
            this.colhoure_absence.Visible = true;
            this.colhoure_absence.VisibleIndex = 6;
            this.colhoure_absence.Width = 41;
            // 
            // coldate
            // 
            this.coldate.FieldName = "date";
            this.coldate.Name = "coldate";
            this.coldate.Visible = true;
            this.coldate.VisibleIndex = 8;
            this.coldate.Width = 32;
            // 
            // colstudent_id
            // 
            this.colstudent_id.FieldName = "student_id";
            this.colstudent_id.Name = "colstudent_id";
            this.colstudent_id.Visible = true;
            this.colstudent_id.VisibleIndex = 0;
            this.colstudent_id.Width = 137;
            // 
            // colM_F
            // 
            this.colM_F.FieldName = "M_F";
            this.colM_F.Name = "colM_F";
            this.colM_F.Visible = true;
            this.colM_F.VisibleIndex = 1;
            this.colM_F.Width = 43;
            // 
            // colfirst_name
            // 
            this.colfirst_name.FieldName = "first_name";
            this.colfirst_name.Name = "colfirst_name";
            this.colfirst_name.Visible = true;
            this.colfirst_name.VisibleIndex = 2;
            this.colfirst_name.Width = 79;
            // 
            // colmiddle_name
            // 
            this.colmiddle_name.FieldName = "middle_name";
            this.colmiddle_name.Name = "colmiddle_name";
            this.colmiddle_name.Visible = true;
            this.colmiddle_name.VisibleIndex = 3;
            this.colmiddle_name.Width = 70;
            // 
            // colfamily_name
            // 
            this.colfamily_name.FieldName = "family_name";
            this.colfamily_name.Name = "colfamily_name";
            this.colfamily_name.Visible = true;
            this.colfamily_name.VisibleIndex = 4;
            this.colfamily_name.Width = 41;
            // 
            // colnum_intake1
            // 
            this.colnum_intake1.FieldName = "num_intake";
            this.colnum_intake1.Name = "colnum_intake1";
            this.colnum_intake1.Visible = true;
            this.colnum_intake1.VisibleIndex = 5;
            this.colnum_intake1.Width = 42;
            // 
            // colhoure_come
            // 
            this.colhoure_come.FieldName = "houre_come";
            this.colhoure_come.Name = "colhoure_come";
            this.colhoure_come.Visible = true;
            this.colhoure_come.VisibleIndex = 7;
            this.colhoure_come.Width = 35;
            // 
            // colname1
            // 
            this.colname1.FieldName = "name";
            this.colname1.Name = "colname1";
            this.colname1.Visible = true;
            this.colname1.VisibleIndex = 9;
            this.colname1.Width = 28;
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.BottomCenter;
            this.simpleButton2.Location = new System.Drawing.Point(30, 24);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(165, 53);
            this.simpleButton2.TabIndex = 6;
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // addCoursesBindingSource
            // 
            this.addCoursesBindingSource.DataMember = "Add_Courses";
            this.addCoursesBindingSource.DataSource = this.data_base;
            // 
            // intakeTableAdapter
            // 
            this.intakeTableAdapter.ClearBeforeFill = true;
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
            // attendanceSheet_viewTableAdapter
            // 
            this.attendanceSheet_viewTableAdapter.ClearBeforeFill = true;
            // 
            // searchControl1
            // 
            this.searchControl1.Client = this.gridControl1;
            this.searchControl1.Location = new System.Drawing.Point(762, 63);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Appearance.BorderColor = System.Drawing.Color.Black;
            this.searchControl1.Properties.Appearance.Options.UseBorderColor = true;
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Properties.Client = this.gridControl1;
            this.searchControl1.Properties.ShowDefaultButtonsMode = DevExpress.XtraEditors.Repository.ShowDefaultButtonsMode.Always;
            this.searchControl1.Size = new System.Drawing.Size(230, 20);
            this.searchControl1.TabIndex = 10;
            this.searchControl1.SelectedIndexChanged += new System.EventHandler(this.searchControl1_SelectedIndexChanged);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton3);
            this.panelControl1.Controls.Add(this.simpleButton2);
            this.panelControl1.Location = new System.Drawing.Point(753, 173);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(221, 210);
            this.panelControl1.TabIndex = 11;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(30, 104);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(165, 53);
            this.simpleButton3.TabIndex = 8;
            this.simpleButton3.Text = "PRINT";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // fillByToolStrip1
            // 
            this.fillByToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.num_intakeToolStripLabel1,
            this.look1,
            this.nameToolStripLabel1,
            this.look2,
            this.fillByToolStripButton1,
            this.toolStripSeparator1,
            this.toolStripButton1});
            this.fillByToolStrip1.Location = new System.Drawing.Point(20, 60);
            this.fillByToolStrip1.Name = "fillByToolStrip1";
            this.fillByToolStrip1.Size = new System.Drawing.Size(975, 25);
            this.fillByToolStrip1.TabIndex = 12;
            this.fillByToolStrip1.Text = "fillByToolStrip1";
            // 
            // num_intakeToolStripLabel1
            // 
            this.num_intakeToolStripLabel1.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_intakeToolStripLabel1.Name = "num_intakeToolStripLabel1";
            this.num_intakeToolStripLabel1.Size = new System.Drawing.Size(86, 22);
            this.num_intakeToolStripLabel1.Text = "num_intake:";
            // 
            // look1
            // 
            this.look1.Name = "look1";
            this.look1.Size = new System.Drawing.Size(100, 25);
            // 
            // nameToolStripLabel1
            // 
            this.nameToolStripLabel1.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameToolStripLabel1.Name = "nameToolStripLabel1";
            this.nameToolStripLabel1.Size = new System.Drawing.Size(48, 22);
            this.nameToolStripLabel1.Text = "name:";
            // 
            // look2
            // 
            this.look2.Name = "look2";
            this.look2.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByToolStripButton1
            // 
            this.fillByToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton1.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillByToolStripButton1.Name = "fillByToolStripButton1";
            this.fillByToolStripButton1.Size = new System.Drawing.Size(46, 22);
            this.fillByToolStripButton1.Text = "FillBy";
            this.fillByToolStripButton1.Click += new System.EventHandler(this.fillByToolStripButton1_Click);
            // 
            // gradeTableAdapter
            // 
            this.gradeTableAdapter.ClearBeforeFill = true;
            // 
            // searchControl2
            // 
            this.searchControl2.Client = this.gridControl1;
            this.searchControl2.Location = new System.Drawing.Point(762, 63);
            this.searchControl2.Name = "searchControl2";
            this.searchControl2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl2.Properties.Client = this.gridControl1;
            this.searchControl2.Properties.ShowDefaultButtonsMode = DevExpress.XtraEditors.Repository.ShowDefaultButtonsMode.Always;
            this.searchControl2.Size = new System.Drawing.Size(230, 20);
            this.searchControl2.TabIndex = 13;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(63, 22);
            this.toolStripButton1.Text = "Refresh";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // Attendance_Design
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 554);
            this.Controls.Add(this.searchControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.fillByToolStrip1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.searchControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Attendance_Design";
            this.Text = "Attendance_Design";
            this.Load += new System.EventHandler(this.Attendance_Design_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceSheetviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_base)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addCoursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intakeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.fillByToolStrip1.ResumeLayout(false);
            this.fillByToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private data_baseTableAdapters.IntakeTableAdapter intakeTableAdapter;
        private System.Windows.Forms.BindingSource addCoursesBindingSource;
        private data_baseTableAdapters.Add_CoursesTableAdapter add_CoursesTableAdapter;
        private data_baseTableAdapters.AttendanceSheet_view1TableAdapter attendanceSheet_view1TableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource intakeBindingSource;
        private System.Windows.Forms.BindingSource attendanceSheetviewBindingSource;
        private data_baseTableAdapters.AttendanceSheet_viewTableAdapter attendanceSheet_viewTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colhoure_absence;
        private DevExpress.XtraGrid.Columns.GridColumn coldate;
        private DevExpress.XtraGrid.Columns.GridColumn colstudent_id;
        private DevExpress.XtraGrid.Columns.GridColumn colM_F;
        private DevExpress.XtraGrid.Columns.GridColumn colfirst_name;
        private DevExpress.XtraGrid.Columns.GridColumn colmiddle_name;
        private DevExpress.XtraGrid.Columns.GridColumn colfamily_name;
        private DevExpress.XtraGrid.Columns.GridColumn colnum_intake1;
        private DevExpress.XtraGrid.Columns.GridColumn colhoure_come;
        private DevExpress.XtraGrid.Columns.GridColumn colname1;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        public data_base data_base;
        private System.Windows.Forms.ToolStrip fillByToolStrip1;
        private System.Windows.Forms.ToolStripLabel num_intakeToolStripLabel1;
        private System.Windows.Forms.ToolStripLabel nameToolStripLabel1;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton1;
        private System.Windows.Forms.ToolStripComboBox look1;
        private System.Windows.Forms.ToolStripComboBox look2;
        private data_baseTableAdapters.gradeTableAdapter gradeTableAdapter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private DevExpress.XtraEditors.SearchControl searchControl2;
    }
}