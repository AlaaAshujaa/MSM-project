namespace appDevexpress
{
    partial class research_design
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(research_design));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.viewreseachBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.data_base = new appDevexpress.data_base();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.coltitle_research = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltype = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colstudent_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfirst_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmiddle_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfamily_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.view_reseachTableAdapter = new appDevexpress.data_baseTableAdapters.View_reseachTableAdapter();
            this.displayToolStrip = new System.Windows.Forms.ToolStrip();
            this.num_intakeToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.look = new System.Windows.Forms.ToolStripComboBox();
            this.displayToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.intakeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.intakeTableAdapter = new appDevexpress.data_baseTableAdapters.IntakeTableAdapter();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewreseachBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_base)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.displayToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intakeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gridControl1);
            this.panelControl1.Location = new System.Drawing.Point(10, 88);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(573, 349);
            this.panelControl1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.viewreseachBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(569, 345);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // viewreseachBindingSource
            // 
            this.viewreseachBindingSource.DataMember = "View_reseach";
            this.viewreseachBindingSource.DataSource = this.data_base;
            // 
            // data_base
            // 
            this.data_base.DataSetName = "data_base";
            this.data_base.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.coltitle_research,
            this.coltype,
            this.coldate,
            this.colstudent_id,
            this.colID,
            this.colfirst_name,
            this.colmiddle_name,
            this.colfamily_name});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // coltitle_research
            // 
            this.coltitle_research.FieldName = "title_research";
            this.coltitle_research.Name = "coltitle_research";
            this.coltitle_research.Visible = true;
            this.coltitle_research.VisibleIndex = 5;
            // 
            // coltype
            // 
            this.coltype.FieldName = "type";
            this.coltype.Name = "coltype";
            this.coltype.Visible = true;
            this.coltype.VisibleIndex = 6;
            // 
            // coldate
            // 
            this.coldate.FieldName = "date";
            this.coldate.Name = "coldate";
            this.coldate.Visible = true;
            this.coldate.VisibleIndex = 7;
            // 
            // colstudent_id
            // 
            this.colstudent_id.FieldName = "student_id";
            this.colstudent_id.Name = "colstudent_id";
            this.colstudent_id.Visible = true;
            this.colstudent_id.VisibleIndex = 1;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colfirst_name
            // 
            this.colfirst_name.FieldName = "first_name";
            this.colfirst_name.Name = "colfirst_name";
            this.colfirst_name.Visible = true;
            this.colfirst_name.VisibleIndex = 2;
            // 
            // colmiddle_name
            // 
            this.colmiddle_name.FieldName = "middle_name";
            this.colmiddle_name.Name = "colmiddle_name";
            this.colmiddle_name.Visible = true;
            this.colmiddle_name.VisibleIndex = 3;
            // 
            // colfamily_name
            // 
            this.colfamily_name.FieldName = "family_name";
            this.colfamily_name.Name = "colfamily_name";
            this.colfamily_name.Visible = true;
            this.colfamily_name.VisibleIndex = 4;
            // 
            // view_reseachTableAdapter
            // 
            this.view_reseachTableAdapter.ClearBeforeFill = true;
            // 
            // displayToolStrip
            // 
            this.displayToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.num_intakeToolStripLabel,
            this.look,
            this.displayToolStripButton});
            this.displayToolStrip.Location = new System.Drawing.Point(20, 60);
            this.displayToolStrip.Name = "displayToolStrip";
            this.displayToolStrip.Size = new System.Drawing.Size(812, 25);
            this.displayToolStrip.TabIndex = 1;
            this.displayToolStrip.Text = "displayToolStrip";
            // 
            // num_intakeToolStripLabel
            // 
            this.num_intakeToolStripLabel.Name = "num_intakeToolStripLabel";
            this.num_intakeToolStripLabel.Size = new System.Drawing.Size(72, 22);
            this.num_intakeToolStripLabel.Text = "num_intake:";
            // 
            // look
            // 
            this.look.Name = "look";
            this.look.Size = new System.Drawing.Size(100, 25);
            // 
            // displayToolStripButton
            // 
            this.displayToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.displayToolStripButton.Name = "displayToolStripButton";
            this.displayToolStripButton.Size = new System.Drawing.Size(49, 22);
            this.displayToolStripButton.Text = "Display";
            this.displayToolStripButton.Click += new System.EventHandler(this.displayToolStripButton_Click);
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
            // searchControl1
            // 
            this.searchControl1.Client = this.gridControl1;
            this.searchControl1.Location = new System.Drawing.Point(592, 63);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Properties.Client = this.gridControl1;
            this.searchControl1.Size = new System.Drawing.Size(237, 20);
            this.searchControl1.TabIndex = 2;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.simpleButton2);
            this.panelControl2.Controls.Add(this.simpleButton1);
            this.panelControl2.Location = new System.Drawing.Point(607, 213);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(203, 203);
            this.panelControl2.TabIndex = 3;
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.simpleButton1.Location = new System.Drawing.Point(35, 44);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(127, 47);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(35, 129);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(127, 44);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "PRINT\r\n";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // research_design
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 467);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.searchControl1);
            this.Controls.Add(this.displayToolStrip);
            this.Controls.Add(this.panelControl1);
            this.Name = "research_design";
            this.Text = "research_design";
            this.Load += new System.EventHandler(this.research_design_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewreseachBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_base)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.displayToolStrip.ResumeLayout(false);
            this.displayToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.intakeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn coltitle_research;
        private DevExpress.XtraGrid.Columns.GridColumn coltype;
        private DevExpress.XtraGrid.Columns.GridColumn coldate;
        private DevExpress.XtraGrid.Columns.GridColumn colstudent_id;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colfirst_name;
        private DevExpress.XtraGrid.Columns.GridColumn colmiddle_name;
        private DevExpress.XtraGrid.Columns.GridColumn colfamily_name;
        private data_base data_base;
        private System.Windows.Forms.BindingSource viewreseachBindingSource;
        private data_baseTableAdapters.View_reseachTableAdapter view_reseachTableAdapter;
        private System.Windows.Forms.ToolStrip displayToolStrip;
        private System.Windows.Forms.ToolStripLabel num_intakeToolStripLabel;
        private System.Windows.Forms.ToolStripButton displayToolStripButton;
        private System.Windows.Forms.ToolStripComboBox look;
        private System.Windows.Forms.BindingSource intakeBindingSource;
        private data_baseTableAdapters.IntakeTableAdapter intakeTableAdapter;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}