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
    public partial class Master_Programs : Form
    {

        DataClasses1DataContext data = new DataClasses1DataContext();
        BL.CLS_Program pro = new BL.CLS_Program();
      public  int id;

        public Master_Programs()
        {
            InitializeComponent();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void Master_Programs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mSMDataSet4.Program' table. You can move, or remove it, as needed.
            gridControl1.DataSource = data.GET_ALL_Program();
            gridView1.Columns[0].Caption = "ID";

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            if (txtname.Text != "" && txttype.Text != "")
            {
                pro.ADD_Program(txtname.Text, txttype.Text);
              MetroFramework.MetroMessageBox.Show(this, "\n \n Done add  " + txtname.Text + "  successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gridControl1.DataSource = data.GET_ALL_Program();
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

                if (txtname.Text != "" && txttype.Text != "")
                {
                    pro.UPDATE_Program(txtname.Text, txttype.Text, id);

                    MetroFramework.MetroMessageBox.Show(this, "\n \n Done Update " + txtname.Text + "  successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridControl1.DataSource = data.GET_ALL_Program();
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

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            id = gridView1.FocusedRowHandle;
        
        }

        private void gridControl1_MouseClick(object sender, MouseEventArgs e)
        {
         
        }

        private void simpleButton4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
        
        
        
        }

        private void gridView1_RowClick_1(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            id = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "program_code").ToString());
            txtname.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Name").ToString();
            txttype.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Type").ToString();
      

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtname.Text != "" && txttype.Text != "")
                {

                    pro.DELETE_Program(id);

                    MetroFramework.MetroMessageBox.Show(this, "\n \n Done Delete  " + txtname.Text + "  successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtname.Text = "";
                    txttype.Text = "";
                    gridControl1.DataSource  =data.GET_ALL_Program();
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

        }
    }
}