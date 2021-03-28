namespace appDevexpress
{
    partial class student_reporting2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(student_reporting2));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.studentviewBindingSource = new System.Windows.Forms.BindingSource();
            this.data_base = new appDevexpress.data_base();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnum_intake = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colaccepted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstudent_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colM_F = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfirst_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.hj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfamily_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.intakeBindingSource = new System.Windows.Forms.BindingSource();
            this.intakeTableAdapter = new appDevexpress.data_baseTableAdapters.IntakeTableAdapter();
            this.addCoursesBindingSource = new System.Windows.Forms.BindingSource();
            this.add_CoursesTableAdapter = new appDevexpress.data_baseTableAdapters.Add_CoursesTableAdapter();
            this.student_viewTableAdapter = new appDevexpress.data_baseTableAdapters.student_viewTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.num_intakeToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.look1 = new System.Windows.Forms.ToolStripComboBox();
            this.nameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.look2 = new System.Windows.Forms.ToolStripComboBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_base)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intakeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addCoursesBindingSource)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridControl1);
            this.groupControl1.Location = new System.Drawing.Point(5, 63);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(654, 376);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "groupControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.studentviewBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 20);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(650, 354);
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
            this.colnum_intake,
            this.colaccepted,
            this.colstudent_id,
            this.colM_F,
            this.colfirst_name,
            this.hj,
            this.colfamily_name});
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
            this.colnum_intake.Width = 27;
            // 
            // colaccepted
            // 
            this.colaccepted.Caption = "Accepted";
            this.colaccepted.FieldName = "accepted";
            this.colaccepted.Name = "colaccepted";
            this.colaccepted.Visible = true;
            this.colaccepted.VisibleIndex = 6;
            this.colaccepted.Width = 43;
            // 
            // colstudent_id
            // 
            this.colstudent_id.Caption = "ID #";
            this.colstudent_id.FieldName = "student_id";
            this.colstudent_id.Name = "colstudent_id";
            this.colstudent_id.Visible = true;
            this.colstudent_id.VisibleIndex = 0;
            this.colstudent_id.Width = 163;
            // 
            // colM_F
            // 
            this.colM_F.Caption = "Title";
            this.colM_F.FieldName = "M_F";
            this.colM_F.Name = "colM_F";
            this.colM_F.Visible = true;
            this.colM_F.VisibleIndex = 1;
            this.colM_F.Width = 47;
            // 
            // colfirst_name
            // 
            this.colfirst_name.Caption = "F_Name";
            this.colfirst_name.FieldName = "first_name";
            this.colfirst_name.Name = "colfirst_name";
            this.colfirst_name.Visible = true;
            this.colfirst_name.VisibleIndex = 2;
            this.colfirst_name.Width = 135;
            // 
            // hj
            // 
            this.hj.Caption = "M_Name";
            this.hj.FieldName = "middle_name";
            this.hj.Name = "hj";
            this.hj.Visible = true;
            this.hj.VisibleIndex = 3;
            this.hj.Width = 115;
            // 
            // colfamily_name
            // 
            this.colfamily_name.Caption = "L_Name";
            this.colfamily_name.FieldName = "family_name";
            this.colfamily_name.Name = "colfamily_name";
            this.colfamily_name.Visible = true;
            this.colfamily_name.VisibleIndex = 4;
            this.colfamily_name.Width = 104;
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
            // student_viewTableAdapter
            // 
            this.student_viewTableAdapter.ClearBeforeFill = true;
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
            this.fillByToolStrip.Size = new System.Drawing.Size(793, 25);
            this.fillByToolStrip.TabIndex = 1;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // num_intakeToolStripLabel
            // 
            this.num_intakeToolStripLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_intakeToolStripLabel.Name = "num_intakeToolStripLabel";
            this.num_intakeToolStripLabel.Size = new System.Drawing.Size(89, 22);
            this.num_intakeToolStripLabel.Text = "Intake Number:";
            // 
            // look1
            // 
            this.look1.Name = "look1";
            this.look1.Size = new System.Drawing.Size(100, 25);
            // 
            // nameToolStripLabel
            // 
            this.nameToolStripLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameToolStripLabel.Name = "nameToolStripLabel";
            this.nameToolStripLabel.Size = new System.Drawing.Size(42, 22);
            this.nameToolStripLabel.Text = "Name:";
            // 
            // look2
            // 
            this.look2.Name = "look2";
            this.look2.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(56, 22);
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
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.ForeColor = System.Drawing.Color.Black;
            this.toolStripButton1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(57, 22);
            this.toolStripButton1.Text = "Refresh";
            this.toolStripButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // searchControl1
            // 
            this.searchControl1.Client = this.gridControl1;
            this.searchControl1.Location = new System.Drawing.Point(560, 63);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Properties.Client = this.gridControl1;
            this.searchControl1.Properties.ShowDefaultButtonsMode = DevExpress.XtraEditors.Repository.ShowDefaultButtonsMode.Always;
            this.searchControl1.Size = new System.Drawing.Size(250, 20);
            this.searchControl1.TabIndex = 2;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Location = new System.Drawing.Point(675, 224);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(150, 52);
            this.panelControl1.TabIndex = 3;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.simpleButton1.Location = new System.Drawing.Point(5, 5);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(139, 39);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // student_reporting2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 445);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.searchControl1);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.groupControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "student_reporting2";
            this.Text = "student_reporting2";
            this.Load += new System.EventHandler(this.student_reporting2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_base)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intakeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addCoursesBindingSource)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private data_base data_base;
        private System.Windows.Forms.BindingSource intakeBindingSource;
        private data_baseTableAdapters.IntakeTableAdapter intakeTableAdapter;
        private System.Windows.Forms.BindingSource addCoursesBindingSource;
        private data_baseTableAdapters.Add_CoursesTableAdapter add_CoursesTableAdapter;
        private System.Windows.Forms.BindingSource studentviewBindingSource;
        private data_baseTableAdapters.student_viewTableAdapter student_viewTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colnum_intake;
        private DevExpress.XtraGrid.Columns.GridColumn colaccepted;
        private DevExpress.XtraGrid.Columns.GridColumn colstudent_id;
        private DevExpress.XtraGrid.Columns.GridColumn colM_F;
        private DevExpress.XtraGrid.Columns.GridColumn colfirst_name;
        private DevExpress.XtraGrid.Columns.GridColumn hj;
        private DevExpress.XtraGrid.Columns.GridColumn colfamily_name;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel num_intakeToolStripLabel;
        private System.Windows.Forms.ToolStripLabel nameToolStripLabel;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.ToolStripComboBox look1;
        private System.Windows.Forms.ToolStripComboBox look2;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;

    }
}