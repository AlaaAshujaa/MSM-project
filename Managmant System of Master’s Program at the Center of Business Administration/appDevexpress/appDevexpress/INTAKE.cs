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
    public partial class INTAKE : Form
    {
        DataClasses1DataContext data = new DataClasses1DataContext();
        int id;
        BL.CLS_INTAKE inta = new BL.CLS_INTAKE();
        public INTAKE()
        {
            InitializeComponent();
        }

        private void Intake_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = data.GET_ALL_intake();

        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            id = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Intake_code").ToString());
            txtname.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Name").ToString();
            dateEdit1.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Year").ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtname.Text != "" && numericUpDown1.Text != "" && dateEdit1.Text != "")
                {
                    int i = Convert.ToInt32(numericUpDown1.Text);
                    inta.ADD_intake(txtname.Text, i, dateEdit1.Text);
                    MetroFramework.MetroMessageBox.Show(this, "\n \n Done Add " + txtname.Text + "  successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridControl1.DataSource = data.GET_ALL_intake();

                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "\n \nMake sure of the textbox not null ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error :\n Number 1 " + ex.Message, "Error :\n", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtname.Text != "" && numericUpDown1.Text != "" && dateEdit1.Text != "")
                {
                    int i = Convert.ToInt32(numericUpDown1.Text);
                    inta.UPDATE_intake(txtname.Text, i, dateEdit1.Text, id);
                    MetroFramework.MetroMessageBox.Show(this, "\n \n Done Update " + txtname.Text + "  successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridControl1.DataSource = data.GET_ALL_intake();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "\n \nMake sure of the textbox not null  ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                if (txtname.Text != "" && numericUpDown1.Text != "" && dateEdit1.Text != "")
                {
                    int i = Convert.ToInt32(numericUpDown1.Text);
                    inta.DELETE_intake(txtname.Text, i, dateEdit1.Text, id);

                    MetroFramework.MetroMessageBox.Show(this, "\n \n Done Delete  " + txtname.Text + "  successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtname.Text = "";
                    dateEdit1.Text = "";
                    numericUpDown1.Text = "";

                    gridControl1.DataSource = data.GET_ALL_intake();
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

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
           // gridControl1.DataSource = inta.SEARCH_Intake(textEdit1.Text);
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}