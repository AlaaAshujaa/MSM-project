namespace appDevexpress
{
    partial class sync_msm
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
            this.dataTable4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable4TableAdapter = new appDevexpress.data_baseTableAdapters.DataTable4TableAdapter();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uniquenumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intakecodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.institutionnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programlocationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lecturernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assignorExamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indorGropDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.graderesultDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supervisorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evaluatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeprojectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bHAPtitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coachDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evaluatorBHAPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateBHAPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motivationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.declarationdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.syncgrievancemsmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acceptedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Synchronization = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_base)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable4BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeDataGridViewTextBoxColumn,
            this.uniquenumDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.studentnameDataGridViewTextBoxColumn,
            this.programtypeDataGridViewTextBoxColumn,
            this.intakecodeDataGridViewTextBoxColumn,
            this.institutionnameDataGridViewTextBoxColumn,
            this.programlocationDataGridViewTextBoxColumn,
            this.coursenameDataGridViewTextBoxColumn,
            this.lecturernameDataGridViewTextBoxColumn,
            this.assignorExamDataGridViewTextBoxColumn,
            this.indorGropDataGridViewTextBoxColumn,
            this.graderesultDataGridViewTextBoxColumn,
            this.projectTitleDataGridViewTextBoxColumn,
            this.supervisorDataGridViewTextBoxColumn,
            this.evaluatorDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.gradeprojectDataGridViewTextBoxColumn,
            this.bHAPtitleDataGridViewTextBoxColumn,
            this.coachDataGridViewTextBoxColumn,
            this.evaluatorBHAPDataGridViewTextBoxColumn,
            this.dateBHAPDataGridViewTextBoxColumn,
            this.questionDataGridViewTextBoxColumn,
            this.objectionDataGridViewTextBoxColumn,
            this.motivationDataGridViewTextBoxColumn,
            this.declarationdateDataGridViewTextBoxColumn,
            this.syncgrievancemsmDataGridViewTextBoxColumn,
            this.acceptedDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataTable4BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(608, 309);
            this.dataGridView1.TabIndex = 0;
            // 
            // data_base
            // 
            this.data_base.DataSetName = "data_base";
            this.data_base.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable4BindingSource
            // 
            this.dataTable4BindingSource.DataMember = "DataTable4";
            this.dataTable4BindingSource.DataSource = this.data_base;
            // 
            // dataTable4TableAdapter
            // 
            this.dataTable4TableAdapter.ClearBeforeFill = true;
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
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // studentnameDataGridViewTextBoxColumn
            // 
            this.studentnameDataGridViewTextBoxColumn.DataPropertyName = "student_name";
            this.studentnameDataGridViewTextBoxColumn.HeaderText = "student_name";
            this.studentnameDataGridViewTextBoxColumn.Name = "studentnameDataGridViewTextBoxColumn";
            // 
            // programtypeDataGridViewTextBoxColumn
            // 
            this.programtypeDataGridViewTextBoxColumn.DataPropertyName = "program_type";
            this.programtypeDataGridViewTextBoxColumn.HeaderText = "program_type";
            this.programtypeDataGridViewTextBoxColumn.Name = "programtypeDataGridViewTextBoxColumn";
            // 
            // intakecodeDataGridViewTextBoxColumn
            // 
            this.intakecodeDataGridViewTextBoxColumn.DataPropertyName = "Intake_code";
            this.intakecodeDataGridViewTextBoxColumn.HeaderText = "Intake_code";
            this.intakecodeDataGridViewTextBoxColumn.Name = "intakecodeDataGridViewTextBoxColumn";
            // 
            // institutionnameDataGridViewTextBoxColumn
            // 
            this.institutionnameDataGridViewTextBoxColumn.DataPropertyName = "Institution_name";
            this.institutionnameDataGridViewTextBoxColumn.HeaderText = "Institution_name";
            this.institutionnameDataGridViewTextBoxColumn.Name = "institutionnameDataGridViewTextBoxColumn";
            // 
            // programlocationDataGridViewTextBoxColumn
            // 
            this.programlocationDataGridViewTextBoxColumn.DataPropertyName = "program_location";
            this.programlocationDataGridViewTextBoxColumn.HeaderText = "program_location";
            this.programlocationDataGridViewTextBoxColumn.Name = "programlocationDataGridViewTextBoxColumn";
            // 
            // coursenameDataGridViewTextBoxColumn
            // 
            this.coursenameDataGridViewTextBoxColumn.DataPropertyName = "Course_name";
            this.coursenameDataGridViewTextBoxColumn.HeaderText = "Course_name";
            this.coursenameDataGridViewTextBoxColumn.Name = "coursenameDataGridViewTextBoxColumn";
            // 
            // lecturernameDataGridViewTextBoxColumn
            // 
            this.lecturernameDataGridViewTextBoxColumn.DataPropertyName = "lecturer_name";
            this.lecturernameDataGridViewTextBoxColumn.HeaderText = "lecturer_name";
            this.lecturernameDataGridViewTextBoxColumn.Name = "lecturernameDataGridViewTextBoxColumn";
            // 
            // assignorExamDataGridViewTextBoxColumn
            // 
            this.assignorExamDataGridViewTextBoxColumn.DataPropertyName = "Assign_or_Exam";
            this.assignorExamDataGridViewTextBoxColumn.HeaderText = "Assign_or_Exam";
            this.assignorExamDataGridViewTextBoxColumn.Name = "assignorExamDataGridViewTextBoxColumn";
            // 
            // indorGropDataGridViewTextBoxColumn
            // 
            this.indorGropDataGridViewTextBoxColumn.DataPropertyName = "ind_or_Grop";
            this.indorGropDataGridViewTextBoxColumn.HeaderText = "ind_or_Grop";
            this.indorGropDataGridViewTextBoxColumn.Name = "indorGropDataGridViewTextBoxColumn";
            // 
            // graderesultDataGridViewTextBoxColumn
            // 
            this.graderesultDataGridViewTextBoxColumn.DataPropertyName = "grade_result";
            this.graderesultDataGridViewTextBoxColumn.HeaderText = "grade_result";
            this.graderesultDataGridViewTextBoxColumn.Name = "graderesultDataGridViewTextBoxColumn";
            // 
            // projectTitleDataGridViewTextBoxColumn
            // 
            this.projectTitleDataGridViewTextBoxColumn.DataPropertyName = "Project_Title";
            this.projectTitleDataGridViewTextBoxColumn.HeaderText = "Project_Title";
            this.projectTitleDataGridViewTextBoxColumn.Name = "projectTitleDataGridViewTextBoxColumn";
            // 
            // supervisorDataGridViewTextBoxColumn
            // 
            this.supervisorDataGridViewTextBoxColumn.DataPropertyName = "Supervisor";
            this.supervisorDataGridViewTextBoxColumn.HeaderText = "Supervisor";
            this.supervisorDataGridViewTextBoxColumn.Name = "supervisorDataGridViewTextBoxColumn";
            // 
            // evaluatorDataGridViewTextBoxColumn
            // 
            this.evaluatorDataGridViewTextBoxColumn.DataPropertyName = "Evaluator";
            this.evaluatorDataGridViewTextBoxColumn.HeaderText = "Evaluator";
            this.evaluatorDataGridViewTextBoxColumn.Name = "evaluatorDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // gradeprojectDataGridViewTextBoxColumn
            // 
            this.gradeprojectDataGridViewTextBoxColumn.DataPropertyName = "grade_project";
            this.gradeprojectDataGridViewTextBoxColumn.HeaderText = "grade_project";
            this.gradeprojectDataGridViewTextBoxColumn.Name = "gradeprojectDataGridViewTextBoxColumn";
            // 
            // bHAPtitleDataGridViewTextBoxColumn
            // 
            this.bHAPtitleDataGridViewTextBoxColumn.DataPropertyName = "BHAP_title";
            this.bHAPtitleDataGridViewTextBoxColumn.HeaderText = "BHAP_title";
            this.bHAPtitleDataGridViewTextBoxColumn.Name = "bHAPtitleDataGridViewTextBoxColumn";
            // 
            // coachDataGridViewTextBoxColumn
            // 
            this.coachDataGridViewTextBoxColumn.DataPropertyName = "Coach";
            this.coachDataGridViewTextBoxColumn.HeaderText = "Coach";
            this.coachDataGridViewTextBoxColumn.Name = "coachDataGridViewTextBoxColumn";
            // 
            // evaluatorBHAPDataGridViewTextBoxColumn
            // 
            this.evaluatorBHAPDataGridViewTextBoxColumn.DataPropertyName = "Evaluator_BHAP";
            this.evaluatorBHAPDataGridViewTextBoxColumn.HeaderText = "Evaluator_BHAP";
            this.evaluatorBHAPDataGridViewTextBoxColumn.Name = "evaluatorBHAPDataGridViewTextBoxColumn";
            // 
            // dateBHAPDataGridViewTextBoxColumn
            // 
            this.dateBHAPDataGridViewTextBoxColumn.DataPropertyName = "date_BHAP";
            this.dateBHAPDataGridViewTextBoxColumn.HeaderText = "date_BHAP";
            this.dateBHAPDataGridViewTextBoxColumn.Name = "dateBHAPDataGridViewTextBoxColumn";
            // 
            // questionDataGridViewTextBoxColumn
            // 
            this.questionDataGridViewTextBoxColumn.DataPropertyName = "Question";
            this.questionDataGridViewTextBoxColumn.HeaderText = "Question";
            this.questionDataGridViewTextBoxColumn.Name = "questionDataGridViewTextBoxColumn";
            // 
            // objectionDataGridViewTextBoxColumn
            // 
            this.objectionDataGridViewTextBoxColumn.DataPropertyName = "Objection";
            this.objectionDataGridViewTextBoxColumn.HeaderText = "Objection";
            this.objectionDataGridViewTextBoxColumn.Name = "objectionDataGridViewTextBoxColumn";
            // 
            // motivationDataGridViewTextBoxColumn
            // 
            this.motivationDataGridViewTextBoxColumn.DataPropertyName = "Motivation";
            this.motivationDataGridViewTextBoxColumn.HeaderText = "Motivation";
            this.motivationDataGridViewTextBoxColumn.Name = "motivationDataGridViewTextBoxColumn";
            // 
            // declarationdateDataGridViewTextBoxColumn
            // 
            this.declarationdateDataGridViewTextBoxColumn.DataPropertyName = "Declaration_date";
            this.declarationdateDataGridViewTextBoxColumn.HeaderText = "Declaration_date";
            this.declarationdateDataGridViewTextBoxColumn.Name = "declarationdateDataGridViewTextBoxColumn";
            // 
            // syncgrievancemsmDataGridViewTextBoxColumn
            // 
            this.syncgrievancemsmDataGridViewTextBoxColumn.DataPropertyName = "sync_grievance_msm";
            this.syncgrievancemsmDataGridViewTextBoxColumn.HeaderText = "sync_grievance_msm";
            this.syncgrievancemsmDataGridViewTextBoxColumn.Name = "syncgrievancemsmDataGridViewTextBoxColumn";
            // 
            // acceptedDataGridViewTextBoxColumn
            // 
            this.acceptedDataGridViewTextBoxColumn.DataPropertyName = "accepted";
            this.acceptedDataGridViewTextBoxColumn.HeaderText = "accepted";
            this.acceptedDataGridViewTextBoxColumn.Name = "acceptedDataGridViewTextBoxColumn";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(112, 336);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 47);
            this.button2.TabIndex = 9;
            this.button2.Text = "Export ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(389, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 47);
            this.button1.TabIndex = 8;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Synchronization
            // 
            this.Synchronization.Location = new System.Drawing.Point(251, 336);
            this.Synchronization.Name = "Synchronization";
            this.Synchronization.Size = new System.Drawing.Size(132, 47);
            this.Synchronization.TabIndex = 7;
            this.Synchronization.Text = "Synchronization";
            this.Synchronization.UseVisualStyleBackColor = true;
            this.Synchronization.Click += new System.EventHandler(this.Synchronization_Click);
            // 
            // sync_msm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 395);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Synchronization);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "sync_msm";
            this.Text = "sync_msm";
            this.Load += new System.EventHandler(this.sync_msm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_base)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable4BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private data_base data_base;
        private System.Windows.Forms.BindingSource dataTable4BindingSource;
        private data_baseTableAdapters.DataTable4TableAdapter dataTable4TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uniquenumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn programtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intakecodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn institutionnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn programlocationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lecturernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assignorExamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn indorGropDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn graderesultDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supervisorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evaluatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradeprojectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bHAPtitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coachDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evaluatorBHAPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateBHAPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motivationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn declarationdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn syncgrievancemsmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acceptedDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Synchronization;
    }
}