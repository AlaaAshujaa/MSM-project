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
    public partial class Result_design : MetroFramework.Forms.MetroForm
    {
        // SqlConnection cn;
        SqlConnection cn = new SqlConnection(@"server=DESKTOP-DC0I9SP\SQLEXPRESS;Database=MSM; integrated security=true");


        // DAL.DataAccessLayer dal = new DAL.DataAccessLayer();

        SqlDataAdapter da = new SqlDataAdapter();

        DataTable dt;
        public Result_design()
        {
            InitializeComponent();
        }

        private void Result_design_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'data_base.Add_Courses' table. You can move, or remove it, as needed.
            this.add_CoursesTableAdapter.Fill(this.data_base.Add_Courses);
            // TODO: This line of code loads data into the 'data_base.Intake' table. You can move, or remove it, as needed.
            this.intakeTableAdapter.Fill(this.data_base.Intake);
            // TODO: This line of code loads data into the 'data_base.result_view' table. You can move, or remove it, as needed.
            this.result_viewTableAdapter.Fill(this.data_base.result_view);
            look1.ComboBox.DataSource = data_base.Intake;
            look1.ComboBox.DisplayMember = "num_intake";
            look1.ComboBox.ValueMember = "Intake_code";


            look2.ComboBox.DataSource = data_base.Add_Courses;
            look2.ComboBox.DisplayMember = "name";
            look2.ComboBox.ValueMember = "course_code";


        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.result_viewTableAdapter.FillBy(this.data_base.result_view, ((int)(System.Convert.ChangeType(look1.Text, typeof(int)))), look2.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
              Result_show rsh = new Result_show();
            //da = new SqlDataAdapter("SELECT grade_code, Unique_num, course_code, intake_code, Assignment, final_Exam, Total_grade, Total_grade_Resit, year, sync_grade, Expr1, name, Expr2, num_intake, student_id, ID FROM dbo.result_view", cn);
             //da.Fill(this.data_base.result_view);

         //   rsh.documentViewer1.Refresh();
           
           
            rsh.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.result_viewTableAdapter.Fill(this.data_base.result_view);
        }

        private void searchControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }
    }
}
