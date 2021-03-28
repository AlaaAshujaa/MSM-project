namespace appDevexpress
{
    partial class sync_course
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.data_base = new appDevexpress.data_base();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter = new appDevexpress.data_baseTableAdapters.DataTable1TableAdapter();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uniquenumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intakecodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.segmenttakenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originallytakenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.retakeintakeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.syncrequestcourseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acceptedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Synchronization = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_base)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn,
            this.uniquenumDataGridViewTextBoxColumn,
            this.studentnameDataGridViewTextBoxColumn,
            this.intakecodeDataGridViewTextBoxColumn,
            this.coursenameDataGridViewTextBoxColumn,
            this.segmenttakenDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.originallytakenDataGridViewTextBoxColumn,
            this.retakeintakeDataGridViewTextBoxColumn,
            this.reasonDataGridViewTextBoxColumn,
            this.syncrequestcourseDataGridViewTextBoxColumn,
            this.acceptedDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataTable1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(575, 326);
            this.dataGridView1.TabIndex = 0;
            // 
            // data_base
            // 
            this.data_base.DataSetName = "data_base";
            this.data_base.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.data_base;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // uniquenumDataGridViewTextBoxColumn
            // 
            this.uniquenumDataGridViewTextBoxColumn.DataPropertyName = "Unique_num";
            this.uniquenumDataGridViewTextBoxColumn.HeaderText = "Unique_num";
            this.uniquenumDataGridViewTextBoxColumn.Name = "uniquenumDataGridViewTextBoxColumn";
            // 
            // studentnameDataGridViewTextBoxColumn
            // 
            this.studentnameDataGridViewTextBoxColumn.DataPropertyName = "student_name";
            this.studentnameDataGridViewTextBoxColumn.HeaderText = "student_name";
            this.studentnameDataGridViewTextBoxColumn.Name = "studentnameDataGridViewTextBoxColumn";
            // 
            // intakecodeDataGridViewTextBoxColumn
            // 
            this.intakecodeDataGridViewTextBoxColumn.DataPropertyName = "Intake_code";
            this.intakecodeDataGridViewTextBoxColumn.HeaderText = "Intake_code";
            this.intakecodeDataGridViewTextBoxColumn.Name = "intakecodeDataGridViewTextBoxColumn";
            // 
            // coursenameDataGridViewTextBoxColumn
            // 
            this.coursenameDataGridViewTextBoxColumn.DataPropertyName = "course_name";
            this.coursenameDataGridViewTextBoxColumn.HeaderText = "course_name";
            this.coursenameDataGridViewTextBoxColumn.Name = "coursenameDataGridViewTextBoxColumn";
            // 
            // segmenttakenDataGridViewTextBoxColumn
            // 
            this.segmenttakenDataGridViewTextBoxColumn.DataPropertyName = "segment_taken";
            this.segmenttakenDataGridViewTextBoxColumn.HeaderText = "segment_taken";
            this.segmenttakenDataGridViewTextBoxColumn.Name = "segmenttakenDataGridViewTextBoxColumn";
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            // 
            // originallytakenDataGridViewTextBoxColumn
            // 
            this.originallytakenDataGridViewTextBoxColumn.DataPropertyName = "originally_taken";
            this.originallytakenDataGridViewTextBoxColumn.HeaderText = "originally_taken";
            this.originallytakenDataGridViewTextBoxColumn.Name = "originallytakenDataGridViewTextBoxColumn";
            // 
            // retakeintakeDataGridViewTextBoxColumn
            // 
            this.retakeintakeDataGridViewTextBoxColumn.DataPropertyName = "retake_intake";
            this.retakeintakeDataGridViewTextBoxColumn.HeaderText = "retake_intake";
            this.retakeintakeDataGridViewTextBoxColumn.Name = "retakeintakeDataGridViewTextBoxColumn";
            // 
            // reasonDataGridViewTextBoxColumn
            // 
            this.reasonDataGridViewTextBoxColumn.DataPropertyName = "Reason";
            this.reasonDataGridViewTextBoxColumn.HeaderText = "Reason";
            this.reasonDataGridViewTextBoxColumn.Name = "reasonDataGridViewTextBoxColumn";
            // 
            // syncrequestcourseDataGridViewTextBoxColumn
            // 
            this.syncrequestcourseDataGridViewTextBoxColumn.DataPropertyName = "sync_request_course";
            this.syncrequestcourseDataGridViewTextBoxColumn.HeaderText = "sync_request_course";
            this.syncrequestcourseDataGridViewTextBoxColumn.Name = "syncrequestcourseDataGridViewTextBoxColumn";
            // 
            // acceptedDataGridViewTextBoxColumn
            // 
            this.acceptedDataGridViewTextBoxColumn.DataPropertyName = "accepted";
            this.acceptedDataGridViewTextBoxColumn.HeaderText = "accepted";
            this.acceptedDataGridViewTextBoxColumn.Name = "acceptedDataGridViewTextBoxColumn";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(99, 353);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 47);
            this.button2.TabIndex = 9;
            this.button2.Text = "Export ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(376, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 47);
            this.button1.TabIndex = 8;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Synchronization
            // 
            this.Synchronization.Location = new System.Drawing.Point(238, 353);
            this.Synchronization.Name = "Synchronization";
            this.Synchronization.Size = new System.Drawing.Size(132, 47);
            this.Synchronization.TabIndex = 7;
            this.Synchronization.Text = "Synchronization";
            this.Synchronization.UseVisualStyleBackColor = true;
            this.Synchronization.Click += new System.EventHandler(this.Synchronization_Click);
            // 
            // sync_course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 412);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Synchronization);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "sync_course";
            this.Text = "sync_course";
            this.Load += new System.EventHandler(this.sync_course_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_base)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private data_base data_base;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private data_baseTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uniquenumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intakecodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn segmenttakenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn originallytakenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn retakeintakeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn syncrequestcourseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acceptedDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Synchronization;
    }
}