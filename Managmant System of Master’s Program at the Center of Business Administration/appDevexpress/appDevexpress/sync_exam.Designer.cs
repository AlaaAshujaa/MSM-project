namespace appDevexpress
{
    partial class sync_exam
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
            this.dataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable2TableAdapter = new appDevexpress.data_baseTableAdapters.DataTable2TableAdapter();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uniquenumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intakecodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assignmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalexamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonrequestDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otherresonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.previouslyexamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namecourseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.syncrequestexamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acceptedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Synchronization = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_base)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).BeginInit();
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
            this.assignmentDataGridViewTextBoxColumn,
            this.finalexamDataGridViewTextBoxColumn,
            this.reasonrequestDataGridViewTextBoxColumn,
            this.otherresonDataGridViewTextBoxColumn,
            this.previouslyexamDataGridViewTextBoxColumn,
            this.namecourseDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.syncrequestexamDataGridViewTextBoxColumn,
            this.acceptedDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataTable2BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(562, 318);
            this.dataGridView1.TabIndex = 0;
            // 
            // data_base
            // 
            this.data_base.DataSetName = "data_base";
            this.data_base.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable2BindingSource
            // 
            this.dataTable2BindingSource.DataMember = "DataTable2";
            this.dataTable2BindingSource.DataSource = this.data_base;
            // 
            // dataTable2TableAdapter
            // 
            this.dataTable2TableAdapter.ClearBeforeFill = true;
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
            // assignmentDataGridViewTextBoxColumn
            // 
            this.assignmentDataGridViewTextBoxColumn.DataPropertyName = "assignment";
            this.assignmentDataGridViewTextBoxColumn.HeaderText = "assignment";
            this.assignmentDataGridViewTextBoxColumn.Name = "assignmentDataGridViewTextBoxColumn";
            // 
            // finalexamDataGridViewTextBoxColumn
            // 
            this.finalexamDataGridViewTextBoxColumn.DataPropertyName = "final_exam";
            this.finalexamDataGridViewTextBoxColumn.HeaderText = "final_exam";
            this.finalexamDataGridViewTextBoxColumn.Name = "finalexamDataGridViewTextBoxColumn";
            // 
            // reasonrequestDataGridViewTextBoxColumn
            // 
            this.reasonrequestDataGridViewTextBoxColumn.DataPropertyName = "reason_request";
            this.reasonrequestDataGridViewTextBoxColumn.HeaderText = "reason_request";
            this.reasonrequestDataGridViewTextBoxColumn.Name = "reasonrequestDataGridViewTextBoxColumn";
            // 
            // otherresonDataGridViewTextBoxColumn
            // 
            this.otherresonDataGridViewTextBoxColumn.DataPropertyName = "other_reson";
            this.otherresonDataGridViewTextBoxColumn.HeaderText = "other_reson";
            this.otherresonDataGridViewTextBoxColumn.Name = "otherresonDataGridViewTextBoxColumn";
            // 
            // previouslyexamDataGridViewTextBoxColumn
            // 
            this.previouslyexamDataGridViewTextBoxColumn.DataPropertyName = "previously_exam";
            this.previouslyexamDataGridViewTextBoxColumn.HeaderText = "previously_exam";
            this.previouslyexamDataGridViewTextBoxColumn.Name = "previouslyexamDataGridViewTextBoxColumn";
            // 
            // namecourseDataGridViewTextBoxColumn
            // 
            this.namecourseDataGridViewTextBoxColumn.DataPropertyName = "name_course";
            this.namecourseDataGridViewTextBoxColumn.HeaderText = "name_course";
            this.namecourseDataGridViewTextBoxColumn.Name = "namecourseDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // syncrequestexamDataGridViewTextBoxColumn
            // 
            this.syncrequestexamDataGridViewTextBoxColumn.DataPropertyName = "sync_request_exam";
            this.syncrequestexamDataGridViewTextBoxColumn.HeaderText = "sync_request_exam";
            this.syncrequestexamDataGridViewTextBoxColumn.Name = "syncrequestexamDataGridViewTextBoxColumn";
            // 
            // acceptedDataGridViewTextBoxColumn
            // 
            this.acceptedDataGridViewTextBoxColumn.DataPropertyName = "accepted";
            this.acceptedDataGridViewTextBoxColumn.HeaderText = "accepted";
            this.acceptedDataGridViewTextBoxColumn.Name = "acceptedDataGridViewTextBoxColumn";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 348);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 47);
            this.button2.TabIndex = 9;
            this.button2.Text = "Export ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(370, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 47);
            this.button1.TabIndex = 8;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Synchronization
            // 
            this.Synchronization.Location = new System.Drawing.Point(232, 348);
            this.Synchronization.Name = "Synchronization";
            this.Synchronization.Size = new System.Drawing.Size(132, 47);
            this.Synchronization.TabIndex = 7;
            this.Synchronization.Text = "Synchronization";
            this.Synchronization.UseVisualStyleBackColor = true;
            this.Synchronization.Click += new System.EventHandler(this.Synchronization_Click);
            // 
            // sync_exam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 399);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Synchronization);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "sync_exam";
            this.Text = "sync_exam";
            this.Load += new System.EventHandler(this.sync_exam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_base)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private data_base data_base;
        private System.Windows.Forms.BindingSource dataTable2BindingSource;
        private data_baseTableAdapters.DataTable2TableAdapter dataTable2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uniquenumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intakecodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assignmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalexamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonrequestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn otherresonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn previouslyexamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namecourseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn syncrequestexamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acceptedDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Synchronization;
    }
}