namespace appDevexpress
{
    partial class Result_design
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Result_design));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.resultviewBindingSource = new System.Windows.Forms.BindingSource();
            this.data_base = new appDevexpress.data_base();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAssignment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfinal_Exam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal_grade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsync_grade = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnum_intake = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstudent_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.result_viewTableAdapter = new appDevexpress.data_baseTableAdapters.result_viewTableAdapter();
            this.intakeBindingSource = new System.Windows.Forms.BindingSource();
            this.intakeTableAdapter = new appDevexpress.data_baseTableAdapters.IntakeTableAdapter();
            this.addCoursesBindingSource = new System.Windows.Forms.BindingSource();
            this.add_CoursesTableAdapter = new appDevexpress.data_baseTableAdapters.Add_CoursesTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.num_intakeToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.look1 = new System.Windows.Forms.ToolStripComboBox();
            this.nameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.look2 = new System.Windows.Forms.ToolStripComboBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_base)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intakeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addCoursesBindingSource)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Location = new System.Drawing.Point(2, 63);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(635, 369);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.resultviewBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 20);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(631, 347);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // resultviewBindingSource
            // 
            this.resultviewBindingSource.DataMember = "result_view";
            this.resultviewBindingSource.DataSource = this.data_base;
            // 
            // data_base
            // 
            this.data_base.DataSetName = "data_base";
            this.data_base.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAssignment,
            this.colfinal_Exam,
            this.colTotal_grade,
            this.colsync_grade,
            this.colname,
            this.colnum_intake,
            this.colstudent_id});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colAssignment
            // 
            this.colAssignment.FieldName = "Assignment";
            this.colAssignment.Name = "colAssignment";
            this.colAssignment.Visible = true;
            this.colAssignment.VisibleIndex = 0;
            // 
            // colfinal_Exam
            // 
            this.colfinal_Exam.FieldName = "final_Exam";
            this.colfinal_Exam.Name = "colfinal_Exam";
            this.colfinal_Exam.Visible = true;
            this.colfinal_Exam.VisibleIndex = 1;
            // 
            // colTotal_grade
            // 
            this.colTotal_grade.FieldName = "Total_grade";
            this.colTotal_grade.Name = "colTotal_grade";
            this.colTotal_grade.Visible = true;
            this.colTotal_grade.VisibleIndex = 2;
            // 
            // colsync_grade
            // 
            this.colsync_grade.FieldName = "sync_grade";
            this.colsync_grade.Name = "colsync_grade";
            this.colsync_grade.Visible = true;
            this.colsync_grade.VisibleIndex = 3;
            // 
            // colname
            // 
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 4;
            // 
            // colnum_intake
            // 
            this.colnum_intake.FieldName = "num_intake";
            this.colnum_intake.Name = "colnum_intake";
            this.colnum_intake.Visible = true;
            this.colnum_intake.VisibleIndex = 5;
            // 
            // colstudent_id
            // 
            this.colstudent_id.FieldName = "student_id";
            this.colstudent_id.Name = "colstudent_id";
            this.colstudent_id.Visible = true;
            this.colstudent_id.VisibleIndex = 6;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton2);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Location = new System.Drawing.Point(643, 146);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(246, 238);
            this.panelControl1.TabIndex = 1;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(70, 113);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(116, 36);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "PRINT";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.simpleButton1.Location = new System.Drawing.Point(70, 45);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(116, 41);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // result_viewTableAdapter
            // 
            this.result_viewTableAdapter.ClearBeforeFill = true;
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
            // addCoursesBindingSource
            // 
            this.addCoursesBindingSource.DataMember = "Add_Courses";
            this.addCoursesBindingSource.DataSource = this.data_base;
            // 
            // add_CoursesTableAdapter
            // 
            this.add_CoursesTableAdapter.ClearBeforeFill = true;
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
            this.fillByToolStrip.Size = new System.Drawing.Size(872, 25);
            this.fillByToolStrip.TabIndex = 3;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // num_intakeToolStripLabel
            // 
            this.num_intakeToolStripLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_intakeToolStripLabel.Name = "num_intakeToolStripLabel";
            this.num_intakeToolStripLabel.Size = new System.Drawing.Size(52, 22);
            this.num_intakeToolStripLabel.Text = "Intake:";
            // 
            // look1
            // 
            this.look1.Name = "look1";
            this.look1.Size = new System.Drawing.Size(100, 25);
            // 
            // nameToolStripLabel
            // 
            this.nameToolStripLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameToolStripLabel.Name = "nameToolStripLabel";
            this.nameToolStripLabel.Size = new System.Drawing.Size(51, 22);
            this.nameToolStripLabel.Text = "Name:";
            // 
            // look2
            // 
            this.look2.Name = "look2";
            this.look2.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(61, 22);
            this.fillByToolStripButton.Text = "Display";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(56, 22);
            this.toolStripButton1.Text = "Refresh";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // searchControl1
            // 
            this.searchControl1.Client = this.gridControl1;
            this.searchControl1.Location = new System.Drawing.Point(660, 65);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Properties.Client = this.gridControl1;
            this.searchControl1.Properties.ShowDefaultButtonsMode = DevExpress.XtraEditors.Repository.ShowDefaultButtonsMode.Always;
            this.searchControl1.Size = new System.Drawing.Size(202, 20);
            this.searchControl1.TabIndex = 4;
            // 
            // Result_design
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 443);
            this.Controls.Add(this.searchControl1);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "Result_design";
            this.Text = "Result_design";
            this.Load += new System.EventHandler(this.Result_design_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_base)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.intakeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addCoursesBindingSource)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private data_base data_base;
        private System.Windows.Forms.BindingSource resultviewBindingSource;
        private data_baseTableAdapters.result_viewTableAdapter result_viewTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colAssignment;
        private DevExpress.XtraGrid.Columns.GridColumn colfinal_Exam;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal_grade;
        private DevExpress.XtraGrid.Columns.GridColumn colsync_grade;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colnum_intake;
        private DevExpress.XtraGrid.Columns.GridColumn colstudent_id;
        private System.Windows.Forms.BindingSource intakeBindingSource;
        private data_baseTableAdapters.IntakeTableAdapter intakeTableAdapter;
        private System.Windows.Forms.BindingSource addCoursesBindingSource;
        private data_baseTableAdapters.Add_CoursesTableAdapter add_CoursesTableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel num_intakeToolStripLabel;
        private System.Windows.Forms.ToolStripLabel nameToolStripLabel;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.ToolStripComboBox look1;
        private System.Windows.Forms.ToolStripComboBox look2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private DevExpress.XtraEditors.SearchControl searchControl1;
    }
}