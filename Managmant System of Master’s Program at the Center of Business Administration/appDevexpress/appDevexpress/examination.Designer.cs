namespace appDevexpress
{
    partial class examination
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(examination));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.data_base = new appDevexpress.data_base();
            this.fillBy3ToolStrip = new System.Windows.Forms.ToolStrip();
            this.num_intakeToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.look1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.nameToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.look2 = new System.Windows.Forms.ToolStripComboBox();
            this.fillBy3ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.addCoursesBindingSource = new System.Windows.Forms.BindingSource();
            this.add_CoursesTableAdapter = new appDevexpress.data_baseTableAdapters.Add_CoursesTableAdapter();
            this.intakeBindingSource = new System.Windows.Forms.BindingSource();
            this.intakeTableAdapter = new appDevexpress.data_baseTableAdapters.IntakeTableAdapter();
            this.studentviewBindingSource = new System.Windows.Forms.BindingSource();
            this.student_viewTableAdapter = new appDevexpress.data_baseTableAdapters.student_viewTableAdapter();
            this.studentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middlenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_base)).BeginInit();
            this.fillBy3ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addCoursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intakeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentviewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.simpleButton1.Location = new System.Drawing.Point(578, 223);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(164, 47);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.dataGridView1);
            this.groupControl1.Location = new System.Drawing.Point(10, 63);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(564, 308);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "groupControl1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentidDataGridViewTextBoxColumn,
            this.mFDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.middlenameDataGridViewTextBoxColumn,
            this.familynameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentviewBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 20);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(560, 286);
            this.dataGridView1.TabIndex = 0;
            // 
            // data_base
            // 
            this.data_base.DataSetName = "data_base";
            this.data_base.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fillBy3ToolStrip
            // 
            this.fillBy3ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.num_intakeToolStripLabel,
            this.look1,
            this.toolStripSeparator1,
            this.nameToolStripLabel,
            this.look2,
            this.fillBy3ToolStripButton,
            this.toolStripButton2});
            this.fillBy3ToolStrip.Location = new System.Drawing.Point(20, 60);
            this.fillBy3ToolStrip.Name = "fillBy3ToolStrip";
            this.fillBy3ToolStrip.Size = new System.Drawing.Size(715, 25);
            this.fillBy3ToolStrip.TabIndex = 5;
            this.fillBy3ToolStrip.Text = "fillBy3ToolStrip";
            // 
            // num_intakeToolStripLabel
            // 
            this.num_intakeToolStripLabel.Name = "num_intakeToolStripLabel";
            this.num_intakeToolStripLabel.Size = new System.Drawing.Size(72, 22);
            this.num_intakeToolStripLabel.Text = "num_intake:";
            // 
            // look1
            // 
            this.look1.Name = "look1";
            this.look1.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // nameToolStripLabel
            // 
            this.nameToolStripLabel.Name = "nameToolStripLabel";
            this.nameToolStripLabel.Size = new System.Drawing.Size(40, 22);
            this.nameToolStripLabel.Text = "name:";
            // 
            // look2
            // 
            this.look2.Name = "look2";
            this.look2.Size = new System.Drawing.Size(100, 25);
            // 
            // fillBy3ToolStripButton
            // 
            this.fillBy3ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy3ToolStripButton.Name = "fillBy3ToolStripButton";
            this.fillBy3ToolStripButton.Size = new System.Drawing.Size(45, 22);
            this.fillBy3ToolStripButton.Text = "FillBy3";
            this.fillBy3ToolStripButton.Click += new System.EventHandler(this.fillBy3ToolStripButton_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(49, 22);
            this.toolStripButton2.Text = "Display";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(56, 22);
            this.toolStripButton1.Text = "Display";
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
            // studentviewBindingSource
            // 
            this.studentviewBindingSource.DataMember = "student_view";
            this.studentviewBindingSource.DataSource = this.data_base;
            // 
            // student_viewTableAdapter
            // 
            this.student_viewTableAdapter.ClearBeforeFill = true;
            // 
            // studentidDataGridViewTextBoxColumn
            // 
            this.studentidDataGridViewTextBoxColumn.DataPropertyName = "student_id";
            this.studentidDataGridViewTextBoxColumn.HeaderText = "student_id";
            this.studentidDataGridViewTextBoxColumn.Name = "studentidDataGridViewTextBoxColumn";
            // 
            // mFDataGridViewTextBoxColumn
            // 
            this.mFDataGridViewTextBoxColumn.DataPropertyName = "M_F";
            this.mFDataGridViewTextBoxColumn.HeaderText = "M_F";
            this.mFDataGridViewTextBoxColumn.Name = "mFDataGridViewTextBoxColumn";
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "first_name";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // middlenameDataGridViewTextBoxColumn
            // 
            this.middlenameDataGridViewTextBoxColumn.DataPropertyName = "middle_name";
            this.middlenameDataGridViewTextBoxColumn.HeaderText = "middle_name";
            this.middlenameDataGridViewTextBoxColumn.Name = "middlenameDataGridViewTextBoxColumn";
            // 
            // familynameDataGridViewTextBoxColumn
            // 
            this.familynameDataGridViewTextBoxColumn.DataPropertyName = "family_name";
            this.familynameDataGridViewTextBoxColumn.HeaderText = "family_name";
            this.familynameDataGridViewTextBoxColumn.Name = "familynameDataGridViewTextBoxColumn";
            // 
            // examination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 384);
            this.Controls.Add(this.fillBy3ToolStrip);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.simpleButton1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "examination";
            this.Text = "examination";
            this.Load += new System.EventHandler(this.examination_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_base)).EndInit();
            this.fillBy3ToolStrip.ResumeLayout(false);
            this.fillBy3ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addCoursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intakeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentviewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private data_base data_base;
        private System.Windows.Forms.ToolStrip fillBy3ToolStrip;
        private System.Windows.Forms.ToolStripLabel num_intakeToolStripLabel;
        private System.Windows.Forms.ToolStripLabel nameToolStripLabel;
        private System.Windows.Forms.ToolStripButton fillBy3ToolStripButton;
        private System.Windows.Forms.ToolStripComboBox look1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripComboBox look2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.BindingSource addCoursesBindingSource;
        private data_baseTableAdapters.Add_CoursesTableAdapter add_CoursesTableAdapter;
        private System.Windows.Forms.BindingSource intakeBindingSource;
        private data_baseTableAdapters.IntakeTableAdapter intakeTableAdapter;
        private System.Windows.Forms.BindingSource studentviewBindingSource;
        private data_baseTableAdapters.student_viewTableAdapter student_viewTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middlenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familynameDataGridViewTextBoxColumn;
    }
}