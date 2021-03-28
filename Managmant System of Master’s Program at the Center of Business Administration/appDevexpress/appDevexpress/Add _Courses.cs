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
    public partial class Add__Courses : Form
    {
        DataClasses1DataContext data = new DataClasses1DataContext();
        BL.CLS_ADD_COURSE CORS = new BL.CLS_ADD_COURSE();
        int id;
        public Add__Courses()
        {
            InitializeComponent();
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Add__Courses_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = CORS.GET_ALL_Add_course();
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            

        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            id = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "course_code").ToString());
            txtname.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Name").ToString();
            cmbotype.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Type").ToString();
         // textEdit1.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ECTS").ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            if (txtname.Text != "" && cmbotype.Text != "" && numhours.Text != "" && textEdit1.Text != "")
            {
                int hou = Convert.ToInt32(numhours.Text);
                CORS.ADD_Courses(txtname.Text, cmbotype.Text, hou, textEdit1.Text);
                MetroFramework.MetroMessageBox.Show(this, "\n \n Done add  " + txtname.Text + "  successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gridControl1.DataSource = CORS.GET_ALL_Add_course();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "\n \nMake sure of the textbox not null ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtname.Text != "" && cmbotype.Text != "" && numhours.Text != "" && textEdit1.Text != "")
                {

                    int hou = Convert.ToInt32(numhours.Text);
                    CORS.UPDATE_Courses(txtname.Text, cmbotype.Text, hou, textEdit1.Text, id);

                    MetroFramework.MetroMessageBox.Show(this, "\n \n Done Update " + txtname.Text + "  successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridControl1.DataSource = CORS.GET_ALL_Add_course();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "\n \nMake sure of the textbox not null or the Password like the Replay Password :", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error :\n Number 1 " + ex.Message, "Error :\n", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtname.Text != "" && cmbotype.Text != "")
                {

                    int hou = Convert.ToInt32(numhours.Text);
                    CORS.DELETE_Courses(txtname.Text, cmbotype.Text, hou,textEdit1.Text, id);

                    MetroFramework.MetroMessageBox.Show(this, "\n \n Done Delete  " + txtname.Text + "  successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtname.Text = "";
                    cmbotype.Text = "";
                    numhours.Text = "";
                    gridControl1.DataSource = CORS.GET_ALL_Add_course();
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

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbotype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textEdit1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
        }
    }
}