using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data;
using System.Data.SqlClient;
namespace appDevexpress
{
    public partial class Grades : Form
    {
        BL.CLS_Grade c = new BL.CLS_Grade();
        int id;
        DataClasses1DataContext data = new DataClasses1DataContext();
        public Grades()
        {
            InitializeComponent();
        }

        private void Grades_Load(object sender, EventArgs e)
        {

            co.Properties.DataSource = data.Add_Courses;
            co.Properties.DisplayMember = "name";
            co.Properties.ValueMember = "course_code";

            i.Properties.DataSource = data.Intakes;
            i.Properties.DisplayMember = "num_intake";
            i.Properties.ValueMember = "Intake_code";


            simpleButton7.Enabled = false;

        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            //code for grade
            //add to add_bottun


            try{

            SqlConnection con = new SqlConnection(@"server=PC;Database=MSM; integrated security=true");
            con.Open();
            SqlCommand cmd = new SqlCommand(" select count(Unique_num) from grade where course_code= '" + co.EditValue + "' and intake_code= '" + i.EditValue + "'", con);
            int ir = Convert.ToInt32(cmd.ExecuteScalar());
            if (ir == 0)
            {

                if (id_par.Text != "" && i.Text != "" && co.Text != "" && ass.Text != " " && ex.Text != " " && date.Text != " ")
                {

                    decimal d = Convert.ToDecimal(ass.Text);
                    decimal de = Convert.ToDecimal(ex.Text);
                    decimal dei = d + de;
                    string f = id_par.EditValue.ToString();
                    int intak = Convert.ToInt32(i.EditValue);
                    int coy = Convert.ToInt32(co.EditValue);


                    c.Add_Grade(coy, intak,"msm7", d, de, dei, date.Text);
                    MetroFramework.MetroMessageBox.Show(this, "\n \n Done Add successefuly  " + f, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                gridControl1.DataSource = c.GET_ALL_grade(intak);
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "\n \nMake sure of the textbox not null  :", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "\n \n this record have been added pervious. ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
             }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error :\n Number 1 " + ex.Message, "Error :\n", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void i_EditValueChanged(object sender, EventArgs e)
        {
            int intak = Convert.ToInt32(i.EditValue);
            // MetroFramework.MetroMessageBox.Show(this, "\n \nMake sure of the textbox not null  :" + intak, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            gridControl1.DataSource = c.GET_ALL_grade(intak);
            id_par.Properties.DataSource = c.GET_intake_student(intak);
            id_par.Properties.DisplayMember = "student_id";
            id_par.Properties.ValueMember = "Unique_num";
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            if (id_par.Text != "" && i.Text != "" && co.Text != "" && ass.Text != " " && ex.Text != " " && date.Text != " ")
            {

                decimal d = Convert.ToDecimal(ass.Text);
                decimal de = Convert.ToDecimal(ex.Text);
                decimal dei = d + de;
                string f = id_par.EditValue.ToString();
                int intak = Convert.ToInt32(i.EditValue);
                int coy = Convert.ToInt32(co.EditValue);


                c.UPDATE_Garde(coy, intak, f, d, de, dei, date.Text,id);
                MetroFramework.MetroMessageBox.Show(this, "\n \n Done Add successefuly  " + id_par.Text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                gridControl1.DataSource = c.GET_ALL_grade(intak);
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "\n \nMake sure of the textbox not null  :", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            try
            {

                if (id != 0)
                {
                    int intak = Convert.ToInt32(i.EditValue);

                    c.DELETE_Grade(id);

                    MetroFramework.MetroMessageBox.Show(this, "\n \n Done Delete  " + id_par.Text + "  successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridControl1.DataSource = c.GET_ALL_grade(intak);
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please choose the item to delete", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error :\n Number 1 " + ex.Message, "Error :\n", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            id = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "grade_code").ToString());
            ass.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Assignment").ToString();
            ex.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "final_Exam").ToString();
            simpleButton7.Enabled = true;
           
        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void id_par_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void co_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}