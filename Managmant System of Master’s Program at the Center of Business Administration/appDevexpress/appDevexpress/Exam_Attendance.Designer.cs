namespace appDevexpress
{
    partial class Exam_Attendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exam_Attendance));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.studentviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.data_base = new appDevexpress.data_base();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colstudent_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colM_F = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfirst_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmiddle_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfamily_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhoure_come = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.student_viewTableAdapter = new appDevexpress.data_baseTableAdapters.student_viewTableAdapter();
            this.fillBy1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.num_intakeToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.look1 = new System.Windows.Forms.ToolStripComboBox();
            this.nameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.look2 = new System.Windows.Forms.ToolStripComboBox();
            this.fillBy1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.addCoursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.add_CoursesTableAdapter = new appDevexpress.data_baseTableAdapters.Add_CoursesTableAdapter();
            this.intakeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.intakeTableAdapter = new appDevexpress.data_baseTableAdapters.IntakeTableAdapter();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_base)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.fillBy1ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addCoursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intakeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton2);
            this.panelControl1.Location = new System.Drawing.Point(793, 179);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(176, 63);
            this.panelControl1.TabIndex = 15;
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.simpleButton2.Location = new System.Drawing.Point(5, 5);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(165, 53);
            this.simpleButton2.TabIndex = 6;
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.AllowDrop = true;
            this.gridControl1.DataSource = this.studentviewBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(2, 20);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(724, 391);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // studentviewBindingSource
            // 
            this.studentviewBindingSource.DataMember = "student_view";
            this.studentviewBindingSource.DataSource = this.data_base;
            // 
            // data_base
            // 
            this.data_base.DataSetName = "data_base";
            this.data_base.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colstudent_id,
            this.colM_F,
            this.colfirst_name,
            this.colmiddle_name,
            this.colfamily_name,
            this.colhoure_come});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsPrint.PrintPreview = true;
            this.gridView1.OptionsPrint.RtfReportHeader = resources.GetString("gridView1.OptionsPrint.RtfReportHeader");
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
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
            // colhoure_come
            // 
            this.colhoure_come.FieldName = "houre_come";
            this.colhoure_come.Name = "colhoure_come";
            this.colhoure_come.Visible = true;
            this.colhoure_come.VisibleIndex = 5;
            this.colhoure_come.Width = 35;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Location = new System.Drawing.Point(20, 88);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(728, 413);
            this.groupControl1.TabIndex = 13;
            this.groupControl1.Text = "DATA";
            // 
            // student_viewTableAdapter
            // 
            this.student_viewTableAdapter.ClearBeforeFill = true;
            // 
            // fillBy1ToolStrip
            // 
            this.fillBy1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.num_intakeToolStripLabel,
            this.look1,
            this.nameToolStripLabel,
            this.look2,
            this.fillBy1ToolStripButton,
            this.toolStripSeparator1,
            this.toolStripButton1});
            this.fillBy1ToolStrip.Location = new System.Drawing.Point(20, 60);
            this.fillBy1ToolStrip.Name = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Size = new System.Drawing.Size(976, 25);
            this.fillBy1ToolStrip.TabIndex = 16;
            this.fillBy1ToolStrip.Text = "fillBy1ToolStrip";
            // 
            // num_intakeToolStripLabel
            // 
            this.num_intakeToolStripLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_intakeToolStripLabel.Name = "num_intakeToolStripLabel";
            this.num_intakeToolStripLabel.Size = new System.Drawing.Size(86, 22);
            this.num_intakeToolStripLabel.Text = "num_intake:";
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
            this.nameToolStripLabel.Size = new System.Drawing.Size(64, 22);
            this.nameToolStripLabel.Text = "Course :";
            // 
            // look2
            // 
            this.look2.Name = "look2";
            this.look2.Size = new System.Drawing.Size(100, 25);
            // 
            // fillBy1ToolStripButton
            // 
            this.fillBy1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy1ToolStripButton.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillBy1ToolStripButton.Name = "fillBy1ToolStripButton";
            this.fillBy1ToolStripButton.Size = new System.Drawing.Size(61, 22);
            this.fillBy1ToolStripButton.Text = "Display";
            this.fillBy1ToolStripButton.Click += new System.EventHandler(this.fillBy1ToolStripButton_Click);
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
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(63, 22);
            this.toolStripButton1.Text = "Refresh";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // searchControl1
            // 
            this.searchControl1.Client = this.gridControl1;
            this.searchControl1.Location = new System.Drawing.Point(764, 63);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Properties.Client = this.gridControl1;
            this.searchControl1.Properties.ShowDefaultButtonsMode = DevExpress.XtraEditors.Repository.ShowDefaultButtonsMode.Always;
            this.searchControl1.Size = new System.Drawing.Size(229, 20);
            this.searchControl1.TabIndex = 17;
            // 
            // Exam_Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 561);
            this.Controls.Add(this.searchControl1);
            this.Controls.Add(this.fillBy1ToolStrip);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Exam_Attendance";
            this.Text = "Exam_Attendance";
            this.Load += new System.EventHandler(this.Exam_Attendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_base)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.fillBy1ToolStrip.ResumeLayout(false);
            this.fillBy1ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addCoursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intakeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        public data_base data_base;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colstudent_id;
        private DevExpress.XtraGrid.Columns.GridColumn colM_F;
        private DevExpress.XtraGrid.Columns.GridColumn colfirst_name;
        private DevExpress.XtraGrid.Columns.GridColumn colmiddle_name;
        private DevExpress.XtraGrid.Columns.GridColumn colfamily_name;
        private DevExpress.XtraGrid.Columns.GridColumn colhoure_come;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.BindingSource studentviewBindingSource;
        private data_baseTableAdapters.student_viewTableAdapter student_viewTableAdapter;
        private System.Windows.Forms.ToolStrip fillBy1ToolStrip;
        private System.Windows.Forms.ToolStripLabel num_intakeToolStripLabel;
        private System.Windows.Forms.ToolStripLabel nameToolStripLabel;
        private System.Windows.Forms.ToolStripButton fillBy1ToolStripButton;
        private System.Windows.Forms.ToolStripComboBox look1;
        private System.Windows.Forms.ToolStripComboBox look2;
        private System.Windows.Forms.BindingSource addCoursesBindingSource;
        private data_baseTableAdapters.Add_CoursesTableAdapter add_CoursesTableAdapter;
        private System.Windows.Forms.BindingSource intakeBindingSource;
        private data_baseTableAdapters.IntakeTableAdapter intakeTableAdapter;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private DevExpress.XtraEditors.SearchControl searchControl1;

    }
}