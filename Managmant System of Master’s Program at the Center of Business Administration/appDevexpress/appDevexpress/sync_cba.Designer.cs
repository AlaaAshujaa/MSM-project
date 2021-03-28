namespace appDevexpress
{
    partial class sync_cba
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
            this.dataTable3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable3TableAdapter = new appDevexpress.data_baseTableAdapters.DataTable3TableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unqiuenumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intakecodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.whatBeingGrievedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateoccurrenceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.explanationgrievedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasongrievedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datefilingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.syncgrievancecbaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acceptedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Synchronization = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_base)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.unqiuenumDataGridViewTextBoxColumn,
            this.studentnameDataGridViewTextBoxColumn,
            this.intakecodeDataGridViewTextBoxColumn,
            this.whatBeingGrievedDataGridViewTextBoxColumn,
            this.dateoccurrenceDataGridViewTextBoxColumn,
            this.explanationgrievedDataGridViewTextBoxColumn,
            this.reasongrievedDataGridViewTextBoxColumn,
            this.datefilingDataGridViewTextBoxColumn,
            this.syncgrievancecbaDataGridViewTextBoxColumn,
            this.acceptedDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataTable3BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(611, 308);
            this.dataGridView1.TabIndex = 0;
            // 
            // data_base
            // 
            this.data_base.DataSetName = "data_base";
            this.data_base.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTable3BindingSource
            // 
            this.dataTable3BindingSource.DataMember = "DataTable3";
            this.dataTable3BindingSource.DataSource = this.data_base;
            // 
            // dataTable3TableAdapter
            // 
            this.dataTable3TableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // unqiuenumDataGridViewTextBoxColumn
            // 
            this.unqiuenumDataGridViewTextBoxColumn.DataPropertyName = "Unqiue_num";
            this.unqiuenumDataGridViewTextBoxColumn.HeaderText = "Unqiue_num";
            this.unqiuenumDataGridViewTextBoxColumn.Name = "unqiuenumDataGridViewTextBoxColumn";
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
            // whatBeingGrievedDataGridViewTextBoxColumn
            // 
            this.whatBeingGrievedDataGridViewTextBoxColumn.DataPropertyName = "what_BeingGrieved";
            this.whatBeingGrievedDataGridViewTextBoxColumn.HeaderText = "what_BeingGrieved";
            this.whatBeingGrievedDataGridViewTextBoxColumn.Name = "whatBeingGrievedDataGridViewTextBoxColumn";
            // 
            // dateoccurrenceDataGridViewTextBoxColumn
            // 
            this.dateoccurrenceDataGridViewTextBoxColumn.DataPropertyName = "date_occurrence";
            this.dateoccurrenceDataGridViewTextBoxColumn.HeaderText = "date_occurrence";
            this.dateoccurrenceDataGridViewTextBoxColumn.Name = "dateoccurrenceDataGridViewTextBoxColumn";
            // 
            // explanationgrievedDataGridViewTextBoxColumn
            // 
            this.explanationgrievedDataGridViewTextBoxColumn.DataPropertyName = "explanation_grieved";
            this.explanationgrievedDataGridViewTextBoxColumn.HeaderText = "explanation_grieved";
            this.explanationgrievedDataGridViewTextBoxColumn.Name = "explanationgrievedDataGridViewTextBoxColumn";
            // 
            // reasongrievedDataGridViewTextBoxColumn
            // 
            this.reasongrievedDataGridViewTextBoxColumn.DataPropertyName = "reason_grieved";
            this.reasongrievedDataGridViewTextBoxColumn.HeaderText = "reason_grieved";
            this.reasongrievedDataGridViewTextBoxColumn.Name = "reasongrievedDataGridViewTextBoxColumn";
            // 
            // datefilingDataGridViewTextBoxColumn
            // 
            this.datefilingDataGridViewTextBoxColumn.DataPropertyName = "date_filing";
            this.datefilingDataGridViewTextBoxColumn.HeaderText = "date_filing";
            this.datefilingDataGridViewTextBoxColumn.Name = "datefilingDataGridViewTextBoxColumn";
            // 
            // syncgrievancecbaDataGridViewTextBoxColumn
            // 
            this.syncgrievancecbaDataGridViewTextBoxColumn.DataPropertyName = "sync_grievance_cba";
            this.syncgrievancecbaDataGridViewTextBoxColumn.HeaderText = "sync_grievance_cba";
            this.syncgrievancecbaDataGridViewTextBoxColumn.Name = "syncgrievancecbaDataGridViewTextBoxColumn";
            // 
            // acceptedDataGridViewTextBoxColumn
            // 
            this.acceptedDataGridViewTextBoxColumn.DataPropertyName = "accepted";
            this.acceptedDataGridViewTextBoxColumn.HeaderText = "accepted";
            this.acceptedDataGridViewTextBoxColumn.Name = "acceptedDataGridViewTextBoxColumn";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(130, 335);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 47);
            this.button2.TabIndex = 12;
            this.button2.Text = "Export ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(407, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 47);
            this.button1.TabIndex = 11;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Synchronization
            // 
            this.Synchronization.Location = new System.Drawing.Point(269, 335);
            this.Synchronization.Name = "Synchronization";
            this.Synchronization.Size = new System.Drawing.Size(132, 47);
            this.Synchronization.TabIndex = 10;
            this.Synchronization.Text = "Synchronization";
            this.Synchronization.UseVisualStyleBackColor = true;
            this.Synchronization.Click += new System.EventHandler(this.Synchronization_Click);
            // 
            // sync_cba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 390);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Synchronization);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.Name = "sync_cba";
            this.Text = "sync_cba";
            this.Load += new System.EventHandler(this.sync_cba_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_base)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable3BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private data_base data_base;
        private System.Windows.Forms.BindingSource dataTable3BindingSource;
        private data_baseTableAdapters.DataTable3TableAdapter dataTable3TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unqiuenumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intakecodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn whatBeingGrievedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateoccurrenceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn explanationgrievedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasongrievedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datefilingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn syncgrievancecbaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acceptedDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Synchronization;
    }
}