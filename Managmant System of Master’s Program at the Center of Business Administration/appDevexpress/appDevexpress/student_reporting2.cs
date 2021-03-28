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
    public partial class student_reporting2 : MetroFramework.Forms.MetroForm
    {
        public student_reporting2()
        {
            InitializeComponent();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void student_reporting2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'data_base.student_view' table. You can move, or remove it, as needed.
            this.student_viewTableAdapter.Fill(this.data_base.student_view);
            // TODO: This line of code loads data into the 'data_base.Add_Courses' table. You can move, or remove it, as needed.
            this.add_CoursesTableAdapter.Fill(this.data_base.Add_Courses);
            // TODO: This line of code loads data into the 'data_base.Intake' table. You can move, or remove it, as needed.
            this.intakeTableAdapter.Fill(this.data_base.Intake);

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
                this.student_viewTableAdapter.FillBy(this.data_base.student_view, ((int)(System.Convert.ChangeType(look1.Text, typeof(int)))), look2.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            student_show ss = new student_show();
            ss.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.student_viewTableAdapter.Fill(this.data_base.student_view);
           
        }
    }
}
