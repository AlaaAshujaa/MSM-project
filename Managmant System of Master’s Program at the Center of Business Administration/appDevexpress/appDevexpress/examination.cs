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
    public partial class examination : MetroFramework.Forms.MetroForm
    {
        public examination()
        {
            InitializeComponent();
        }

        private void examination_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'data_base.student_view' table. You can move, or remove it, as needed.
            this.student_viewTableAdapter.Fill(this.data_base.student_view);
            // TODO: This line of code loads data into the 'data_base.Intake' table. You can move, or remove it, as needed.
            this.intakeTableAdapter.Fill(this.data_base.Intake);
            // TODO: This line of code loads data into the 'data_base.Add_Courses' table. You can move, or remove it, as needed.
            this.add_CoursesTableAdapter.Fill(this.data_base.Add_Courses);
            // TODO: This line of code loads data into the 'data_base.student_view' table. You can move, or remove it, as needed.
            this.student_viewTableAdapter.Fill(this.data_base.student_view);
            // TODO: This line of code loads data into the 'data_base.student_view' table. You can move, or remove it, as needed.
            this.student_viewTableAdapter.Fill(this.data_base.student_view);
            // TODO: This line of code loads data into the 'data_base.Acadimic_Staff' table. You can move, or remove it, as needed.
            // this.acadimic_StaffTableAdapter.Fill(this.data_base.Acadimic_Staff);
            // TODO: This line of code loads data into the 'data_base.Intake' table. You can move, or remove it, as needed.
            // this.intakeTableAdapter.Fill(this.data_base.Intake);
            // TODO: This line of code loads data into the 'data_base.Add_Courses' table. You can move, or remove it, as needed.
            //  this.add_CoursesTableAdapter.Fill(this.data_base.Add_Courses);
            look1.ComboBox.DataSource = data_base.Intake;
            look1.ComboBox.DisplayMember = "num_intake";
            look1.ComboBox.ValueMember = "Intake_code";


            look2.ComboBox.DataSource = data_base.Add_Courses;
            look2.ComboBox.DisplayMember = "name";
            look2.ComboBox.ValueMember = "course_code";

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            examination_post ep = new examination_post();
            ep.ShowDialog();
            // lookUpEdit1.GetSelectedDataRow();

        }

        private void lookUpEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {


        }

        private void fillBy3ToolStripButton_Click(object sender, EventArgs e)
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

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = data_base.student_view;
            this.student_viewTableAdapter.Fill(this.data_base.student_view);

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
