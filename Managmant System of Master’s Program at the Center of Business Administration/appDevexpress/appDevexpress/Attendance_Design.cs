using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Data;

namespace appDevexpress
{
    public partial class Attendance_Design : MetroFramework.Forms.MetroForm
    {
        
        //DAL.DataAccessLayer=new DAL.DataAccessLayer();
       SqlConnection cn = new SqlConnection(@"server=DESKTOP-DC0I9SP\SQLEXPRESS;Database=MSM; integrated security=true");
       SqlDataAdapter dt;
       DataTable da = new System.Data.DataTable();
        public Attendance_Design()
        {
            InitializeComponent();
           
          
        }

        private void Attendance_Design_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'data_base1.grade' table. You can move, or remove it, as needed.
        //    this.gradeTableAdapter.Fill(this.data_base1.grade);
            look1.ComboBox.DataSource = data_base.Intake;
            look1.ComboBox.DisplayMember = "num_intake";
            look1.ComboBox.ValueMember = "Intake_code";


            look2.ComboBox.DataSource = data_base.Add_Courses;
            look2.ComboBox.DisplayMember = "name";
            look2.ComboBox.ValueMember = "course_code";

             this.attendanceSheet_viewTableAdapter.Fill(this.data_base.AttendanceSheet_view);
           
            
         
          
            
               // TODO: This line of code loads data into the 'data_base.Add_Courses' table. You can move, or remove it, as needed.
            this.add_CoursesTableAdapter.Fill(this.data_base.Add_Courses);
            // TODO: This line of code loads data into the 'data_base.Intake' table. You can move, or remove it, as needed.
            this.intakeTableAdapter.Fill(this.data_base.Intake);
           
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
          // Attendance_sheet as1 = new Attendance_sheet();
            

            Brief_show bsh = new Brief_show();
           
            bsh.ShowDialog();
           
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gridLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
          
     
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.attendanceSheet_viewTableAdapter.FillBy(this.data_base.AttendanceSheet_view, ((int)(System.Convert.ChangeType(look1.Text, typeof(int)))), look2.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void num_intakeToolStripTextBox_Click(object sender, EventArgs e)
        {
            
            
            
          
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripContainer1_BottomToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void num_intakeToolStripLabel_Click(object sender, EventArgs e)
        {

        }

        private void searchControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gridControl1_Click_1(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            gridControl1.ShowPrintPreview();
            
          //  data_base=new SqlDataAdapter("Select * from AttendanceSheet_view where student_id='"+gridControl1.DataSource);
            //Brief_show bsh = new Brief_show();
           
            //data_base.attendanceSheet_viewTableAdapter.Fill(bsh.data_base.AttendanceSheet_view);
           // dt = new SqlDataAdapter("Select * from AttendanceSheet_view where student_id='" + gridView1.GetRowCellValue(gridView1.FocusedRowHandle,"").ToString()"'",cn);
           // gridControl1.ShowPrintPreview();
            //bsh.Refresh
           // bsh.ShowDialog();
        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.attendanceSheet_viewTableAdapter.FillBy(this.data_base.AttendanceSheet_view, ((int)(System.Convert.ChangeType(look1.Text, typeof(int)))), look2.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}

