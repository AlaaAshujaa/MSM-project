using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace appDevexpress
{
    
    public partial class Exam_Attendance : MetroFramework.Forms.MetroForm
    {
       // SqlConnection cn;
        SqlConnection cn = new SqlConnection(@"server=DESKTOP-DC0I9SP\SQLEXPRESS;Database=MSM; integrated security=true");
      

       // DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
          
        SqlDataAdapter da = new SqlDataAdapter();
        
        DataTable dt;
        public Exam_Attendance()
        {
            InitializeComponent();
        }

        private void Exam_Attendance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'data_base.Intake' table. You can move, or remove it, as needed.
          this.intakeTableAdapter.Fill(this.data_base.Intake);
            // TODO: This line of code loads data into the 'data_base.Add_Courses' table. You can move, or remove it, as needed.
            this.add_CoursesTableAdapter.Fill(this.data_base.Add_Courses);
            // TODO: This line of code loads data into the 'data_base.student_view' table. You can move, or remove it, as needed.
            this.student_viewTableAdapter.Fill(this.data_base.student_view);
            look1.ComboBox.DataSource = data_base.Intake;
            look1.ComboBox.DisplayMember = "num_intake";
            look1.ComboBox.ValueMember = "Intake_code";


            look2.ComboBox.DataSource = data_base.Add_Courses;
            look2.ComboBox.DisplayMember = "name";
            look2.ComboBox.ValueMember = "course_code";

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            //data_base db = new data_base();
            Exam_attendance_show eas2 = new Exam_attendance_show();
            //da = new SqlDataAdapter("SELECT course_code, name, Intake_code, num_intake, accepted, ID, student_id, M_F, Age, first_name, middle_name, family_name FROM dbo.student_view",cn);
           //this.student_viewTableAdapter.Fill(eas2.documentViewer1);

           //da.Fill(this.data_base.student_view);
            
              //eas2.documentViewer1.Refresh();
            //gridControl1.ShowRibbonPrintPreview();
            eas2.ShowDialog(); 
        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.student_viewTableAdapter.FillBy1(this.data_base.student_view, ((int)(System.Convert.ChangeType(look1.Text, typeof(int)))), look2.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.student_viewTableAdapter.Fill(this.data_base.student_view);
        }

        private void searchControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
