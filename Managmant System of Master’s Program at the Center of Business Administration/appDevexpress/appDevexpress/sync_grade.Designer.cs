namespace appDevexpress
{
    partial class sync_grade
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
            this.gradesyncBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grade_syncTableAdapter = new appDevexpress.data_baseTableAdapters.grade_syncTableAdapter();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familynameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradecodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assignmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalExamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalgradeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalgradeResitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.Synchronization = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_base)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradesyncBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.studentidDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.familynameDataGridViewTextBoxColumn,
            this.gradecodeDataGridViewTextBoxColumn,
            this.assignmentDataGridViewTextBoxColumn,
            this.finalExamDataGridViewTextBoxColumn,
            this.totalgradeDataGridViewTextBoxColumn,
            this.totalgradeResitDataGridViewTextBoxColumn,
            this.yearDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gradesyncBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(605, 274);
            this.dataGridView1.TabIndex = 0;
            // 
            // data_base
            // 
            this.data_base.DataSetName = "data_base";
            this.data_base.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gradesyncBindingSource
            // 
            this.gradesyncBindingSource.DataMember = "grade_sync";
            this.gradesyncBindingSource.DataSource = this.data_base;
            // 
            // grade_syncTableAdapter
            // 
            this.grade_syncTableAdapter.ClearBeforeFill = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // studentidDataGridViewTextBoxColumn
            // 
            this.studentidDataGridViewTextBoxColumn.DataPropertyName = "student_id";
            this.studentidDataGridViewTextBoxColumn.HeaderText = "student_id";
            this.studentidDataGridViewTextBoxColumn.Name = "studentidDataGridViewTextBoxColumn";
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "first_name";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // familynameDataGridViewTextBoxColumn
            // 
            this.familynameDataGridViewTextBoxColumn.DataPropertyName = "family_name";
            this.familynameDataGridViewTextBoxColumn.HeaderText = "family_name";
            this.familynameDataGridViewTextBoxColumn.Name = "familynameDataGridViewTextBoxColumn";
            // 
            // gradecodeDataGridViewTextBoxColumn
            // 
            this.gradecodeDataGridViewTextBoxColumn.DataPropertyName = "grade_code";
            this.gradecodeDataGridViewTextBoxColumn.HeaderText = "grade_code";
            this.gradecodeDataGridViewTextBoxColumn.Name = "gradecodeDataGridViewTextBoxColumn";
            // 
            // assignmentDataGridViewTextBoxColumn
            // 
            this.assignmentDataGridViewTextBoxColumn.DataPropertyName = "Assignment";
            this.assignmentDataGridViewTextBoxColumn.HeaderText = "Assignment";
            this.assignmentDataGridViewTextBoxColumn.Name = "assignmentDataGridViewTextBoxColumn";
            // 
            // finalExamDataGridViewTextBoxColumn
            // 
            this.finalExamDataGridViewTextBoxColumn.DataPropertyName = "final_Exam";
            this.finalExamDataGridViewTextBoxColumn.HeaderText = "final_Exam";
            this.finalExamDataGridViewTextBoxColumn.Name = "finalExamDataGridViewTextBoxColumn";
            // 
            // totalgradeDataGridViewTextBoxColumn
            // 
            this.totalgradeDataGridViewTextBoxColumn.DataPropertyName = "Total_grade";
            this.totalgradeDataGridViewTextBoxColumn.HeaderText = "Total_grade";
            this.totalgradeDataGridViewTextBoxColumn.Name = "totalgradeDataGridViewTextBoxColumn";
            // 
            // totalgradeResitDataGridViewTextBoxColumn
            // 
            this.totalgradeResitDataGridViewTextBoxColumn.DataPropertyName = "Total_grade_Resit";
            this.totalgradeResitDataGridViewTextBoxColumn.HeaderText = "Total_grade_Resit";
            this.totalgradeResitDataGridViewTextBoxColumn.Name = "totalgradeResitDataGridViewTextBoxColumn";
            // 
            // yearDataGridViewTextBoxColumn
            // 
            this.yearDataGridViewTextBoxColumn.DataPropertyName = "year";
            this.yearDataGridViewTextBoxColumn.HeaderText = "year";
            this.yearDataGridViewTextBoxColumn.Name = "yearDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(287, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 47);
            this.button1.TabIndex = 11;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Synchronization
            // 
            this.Synchronization.Location = new System.Drawing.Point(149, 305);
            this.Synchronization.Name = "Synchronization";
            this.Synchronization.Size = new System.Drawing.Size(132, 47);
            this.Synchronization.TabIndex = 10;
            this.Synchronization.Text = "Synchronization";
            this.Synchronization.UseVisualStyleBackColor = true;
            this.Synchronization.Click += new System.EventHandler(this.Synchronization_Click);
            // 
            // sync_grade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 364);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Synchronization);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "sync_grade";
            this.Text = "sync_grade";
            this.Load += new System.EventHandler(this.sync_grade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_base)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradesyncBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private data_base data_base;
        private System.Windows.Forms.BindingSource gradesyncBindingSource;
        private data_baseTableAdapters.grade_syncTableAdapter grade_syncTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familynameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradecodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assignmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalExamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalgradeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalgradeResitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Synchronization;
    }
}