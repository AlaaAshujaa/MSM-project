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
    public partial class Doctor : Form
    {
        BL.CLS_ACADIMIC ac = new BL.CLS_ACADIMIC();
        int id;
        DataClasses1DataContext data = new DataClasses1DataContext();

        public Doctor()
        {
            InitializeComponent();
            
          
        
           
        }

        private void Doctor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mSMDataSet.Acadimic_Staff' table. You can move, or remove it, as needed.

            gridControl1.DataSource = data.GET_ALL_Acadimic_Staff();
        }

        private void imageSlider1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl6_Click(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void buttonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            OpenFileDialog p = new OpenFileDialog();
            p.ShowDialog();
            txtcv.Text = p.FileName.ToString();
        }

        private void buttonEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtfirst.Text != "" && txtmid.Text != "" && txtlast.Text != "" && txtcell.Text != "" && txtoffice.Text != "" && txtfax.Text != "" && txtsex.Text != "" && txtmjor.Text != "" && txtdegree.Text != "" && txtqult.Text != "" && txtorg.Text != "" && txtnat.Text != "" && txtcv.Text != "" && txtadd.Text != "" && txtdate.Text != "")
                {
                    int d = Convert.ToInt32(txtcell.Text);
                    int dr = Convert.ToInt32(txtoffice.Text);
                    int dd = Convert.ToInt32(txtfax.Text);
                    ac.ADD_Acadimic_Staff(txtfirst.Text, txtmid.Text, txtlast.Text, d, dr, dd, txtsex.Text, txtmjor.Text, txtdegree.Text, txtqult.Text, txtorg.Text, txtnat.Text, txtcv.Text, txtadd.Text, txtdate.Text);
                    MetroFramework.MetroMessageBox.Show(this, "\n \n Done add " + txtfirst.Text + " " + txtmid.Text + " " + txtlast.Text + " " + "  successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridControl1.DataSource = data.GET_ALL_Acadimic_Staff();
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

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtfirst.Text != "" && txtmid.Text != "" && txtlast.Text != "" && txtcell.Text != "" && txtoffice.Text != "" && txtfax.Text != "" && txtsex.Text != "" && txtmjor.Text != "" && txtdegree.Text != "" && txtqult.Text != "" && txtorg.Text != "" && txtnat.Text != "" && txtcv.Text != "" && txtadd.Text != "" && txtdate.Text != "")
                {

                    int d = Convert.ToInt32(txtcell.Text);
                    int dr = Convert.ToInt32(txtoffice.Text);
                    int dd = Convert.ToInt32(txtfax.Text);
                    ac.UPDATE_Acadimic_Staff(txtfirst.Text, txtmid.Text, txtlast.Text, d, dr, dd, txtsex.Text, txtmjor.Text, txtdegree.Text, txtqult.Text, txtorg.Text, txtnat.Text, txtcv.Text, txtadd.Text, txtdate.Text, id);

                    MetroFramework.MetroMessageBox.Show(this, "\n \n Done update  " + txtfirst.Text + " " + txtmid.Text + " " + txtlast.Text + " " + "  successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   gridControl1.DataSource = data.GET_ALL_Acadimic_Staff();
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
                if (txtfirst.Text != "" && txtmid.Text != "" && txtlast.Text != "" && txtcell.Text != "" && txtoffice.Text != "" && txtfax.Text != "" && txtsex.Text != "" && txtmjor.Text != "" && txtdegree.Text != "" && txtqult.Text != "" && txtorg.Text != "" && txtnat.Text != "" && txtcv.Text != "" && txtadd.Text != "" && txtdate.Text != "")
                {
                    int d = Convert.ToInt32(txtcell.Text);
                    int dr = Convert.ToInt32(txtoffice.Text);
                    int dd = Convert.ToInt32(txtfax.Text);
                    ac.DELETE_Acadimic_Staff(txtfirst.Text, txtmid.Text, txtlast.Text, d, dr, dd, txtsex.Text, txtmjor.Text, txtdegree.Text, txtqult.Text, txtorg.Text, txtnat.Text, txtcv.Text, txtadd.Text, txtdate.Text, id);

                    MetroFramework.MetroMessageBox.Show(this, "\n \n Done delete  " + txtfirst.Text + txtmid.Text + txtlast.Text + "  successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtfirst.Text = "";
                    txtmid.Text = "";
                    txtlast.Text = "";
                    txtcell.Text = "";
                    txtoffice.Text = "";
                    txtfax.Text = "";
                    txtsex.Text = "";
                    txtmjor.Text = "";
                    txtdegree.Text = "";
                    txtqult.Text = "";
                    txtorg.Text = "";
                    txtnat.Text = "";
                    txtcv.Text = "";
                    txtadd.Text = "";
                    txtdate.Text = "";

                    gridControl1.DataSource = ac.GET_ALL_Acadimic_Staff();


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

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            id = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "doctor_code").ToString());
            txtfirst.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "First_Name").ToString();
            txtmid.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Middle_Name").ToString();
            txtlast.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Last_Name").ToString();
            txtcell.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Cell_Phone").ToString();
            txtoffice.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Office_Phone").ToString();
            txtfax.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Fax").ToString();
            txtsex.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Sex").ToString();
            txtmjor.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Major").ToString();
            txtdegree.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Scientific_degree").ToString();
            txtqult.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Qualifies").ToString();
            txtorg.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Organization").ToString();
            txtnat.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Nationality").ToString();
            txtdate.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Date").ToString();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void txtcell_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;

            }
        }
    }
}