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
    public partial class Student_State : Form
    {
        BL.CLS_STATE state = new BL.CLS_STATE();
        public int id;
        public Student_State()
        {
            InitializeComponent();
            this.gridControl1.DataSource = state.GET_ALL_states();
            gridControl1.Columns[0].Visible = false;
           
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {

        }

        private void Student_State_Load(object sender, EventArgs e)
        {

        }
        

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtname.Text != "")
                {

                    state.ADD_states(txtname.Text);
                    MetroFramework.MetroMessageBox.Show(this, "\n \n Done Add " + txtname.Text + "  successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.gridControl1.DataSource = state.GET_ALL_states();

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

                if (txtname.Text != "")
                {
                    ;
                    state.UPDATE_states(txtname.Text, id);
                    MetroFramework.MetroMessageBox.Show(this, "\n \n Done Update " + txtname.Text + "  successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.gridControl1.DataSource = state.GET_ALL_states();
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
                if (txtname.Text != "")
                {

                    state.DELETE_states(txtname.Text, id);

                    MetroFramework.MetroMessageBox.Show(this, "\n \n Done Delete  " + txtname.Text + "  successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtname.Text = "";

                    this.gridControl1.DataSource = state.GET_ALL_states();
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

        private void gridControl1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                 this.txtname.Text = gridControl1.CurrentRow.Cells[1].Value.ToString();

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error :\n Number 1 " + ex.Message, "Error :\n", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = state.SEARCH_states(txtsearch.Text);
       
        }
    }
}