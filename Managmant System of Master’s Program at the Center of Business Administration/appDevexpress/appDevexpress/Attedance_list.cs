using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appDevexpress
{
    public partial class Attedance_list : MetroFramework.Forms.MetroForm
    {
        public Attedance_list()
        {
            InitializeComponent();
        }

        private void Attedance_list_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'data_base.Intake' table. You can move, or remove it, as needed.
            this.intakeTableAdapter.Fill(this.data_base.Intake);
            // TODO: This line of code loads data into the 'data_base.Add_Courses' table. You can move, or remove it, as needed.
            this.add_CoursesTableAdapter.Fill(this.data_base.Add_Courses);
            // TODO: This line of code loads data into the 'data_base.AttendanceList_view1' table. You can move, or remove it, as needed.
            //this.attendanceList_view1TableAdapter.Fill(this.data_base.AttendanceList_view1);
            //// TODO: This line of code loads data into the 'data_base1.grade' table. You can move, or remove it, as needed.
           // this.gradeTableAdapter.Fill(this.data_base1.grade);

            look1.ComboBox.DataSource = data_base.Intake;
            look1.ComboBox.DisplayMember = "num_intake";
            look1.ComboBox.ValueMember = "Intake_code";


            look2.ComboBox.DataSource = data_base.Add_Courses;
            look2.ComboBox.DisplayMember = "name";
            look2.ComboBox.ValueMember = "course_code";

            this.attendanceList_view1TableAdapter.Fill(this.data_base.AttendanceList_view1);


        
           


        }

       

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            list_show ls = new list_show();
            ls.ShowDialog();
        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
           
        //    try
        //    {
        //        this.attendanceList_view1TableAdapter.FillBy(this.data_base.AttendanceList_view1, ((int)(System.Convert.ChangeType(look1.Text, typeof(int)))), look2.Text);
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {

            try
            {
                this.attendanceList_view1TableAdapter.FillBy(this.data_base.AttendanceList_view1, ((int)(System.Convert.ChangeType(look1.Text, typeof(int)))), look2.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.attendanceList_view1TableAdapter.Fill(this.data_base.AttendanceList_view1);
        }
    }
}
