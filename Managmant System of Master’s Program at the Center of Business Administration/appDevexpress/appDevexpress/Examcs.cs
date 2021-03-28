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

namespace appDevexpress
{
    public partial class Examcs : Form
    {
        DataClasses1DataContext data = new DataClasses1DataContext();
        BL.CLS_EXAM EXAM = new BL.CLS_EXAM();
        int id;
        public Examcs()
        {
            InitializeComponent();
            
            
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Examcs_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = data.GET_ALL_Exam();
            i.Properties.DataSource = data.Intakes;
            i.Properties.DisplayMember = "name";
           i.Properties.ValueMember = "Intake_code";
            a.Properties.DataSource = data.View_Acadimics;
            a.Properties.DisplayMember = "first_name";
            a.Properties.ValueMember = "doctor_code";
            c.Properties.DataSource = data.Add_Courses;
            c.Properties.DisplayMember = "name";
            c.Properties.ValueMember = "course_code";
            
        }

        private void buttonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            OpenFileDialog p = new OpenFileDialog();
            p.ShowDialog();
            path.Text = p.FileName.ToString();
            
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                id = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Exam_code").ToString());
                c.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Name OF Course").ToString();
                i.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Name OF Intake").ToString();
                a.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "First_name_Doctor").ToString();
                dateExa.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "From").ToString();
                dateEdit1.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "To").ToString();
                path.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Path OF Plan").ToString();
            }
        
           catch 
            {
                return;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (c.Text != "" && a.Text != "" && i.Text != "" && dateExa.Text != "" && dateEdit1.Text != "" && path.Text != "")
            {
                int c_i = Convert.ToInt32(c.EditValue);
                int d = Convert.ToInt32(a.EditValue);
                int i_i = Convert.ToInt32(i.EditValue);
                EXAM.Add_Exam(c_i, d, i_i, dateExa.Text, dateEdit1.Text, path.Text);
                MetroFramework.MetroMessageBox.Show(this, "\n \n Done add  " + c.Text + "  successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gridControl1.DataSource = data.GET_ALL_Exam();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "\n \nMake sure of the textbox not null or the Password like the Replay Password :", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (id != 0)
                {
                    if (c.Text != "" && a.Text != "" && i.Text != "" && dateExa.Text != "" && dateEdit1.Text != "" && path.Text != "")
                    {
                        int c_i = Convert.ToInt32(c.EditValue);
                        int d = Convert.ToInt32(a.EditValue);
                        int i_i = Convert.ToInt32(i.EditValue);
                        EXAM.UPDATE_Exam(c_i, d, i_i, dateExa.Text, dateEdit1.Text, path.Text, id);
                       


                        MetroFramework.MetroMessageBox.Show(this, "\n \n Done Update successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gridControl1.DataSource = data.GET_ALL_Exam();
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "\n \nMake sure of the textbox not null or the Password like the Replay Password :", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {

                    MetroFramework.MetroMessageBox.Show(this, "\n \n you most choose item to be update", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error :\n Number 1 " + ex.Message, "Error :\n", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                if (MetroFramework.MetroMessageBox.Show(this, "\n \n Are you sure to delete this item ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    EXAM.DELETE_Exam(id);

                    MetroFramework.MetroMessageBox.Show(this, "\n \n Done delete successefuly", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridControl1.DataSource = data.GET_ALL_Exam();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "\n \n Done delete cancel", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            else
            {

                MetroFramework.MetroMessageBox.Show(this, "\n \n you most choose item to be delete", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void path_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void a_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}