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
    public partial class Requset_Course : Form
    {
        DataClasses1DataContext data = new DataClasses1DataContext();
        
        BL.CLS_req_course req = new BL.CLS_req_course();
     //   Update_Request_Course cou = new Update_Request_Course();
        int id;

       public string reson;
       public string name;
       public string dat;
        public Requset_Course()
        {
            InitializeComponent();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            int intak = Convert.ToInt32(i.EditValue);
            try
            {

                if (accepted1.EditValue != "" )
                {
                    req.UPDATE_request_course(accepted1.Text, id);

                    MetroFramework.MetroMessageBox.Show(this, "\n \n Done Update " + accepted1.EditValue + "  successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridControl1.DataSource = req.GET_All_request_course(intak);
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
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            /*
            id = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "code").ToString());
           cou.unique.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Unique_num").ToString();
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
             */
        }
        private void Requset_Course_Load(object sender, EventArgs e)
        {
            i.Properties.DataSource = data.Intakes;
            i.Properties.DisplayMember = "num_intake";
            i.Properties.ValueMember = "Intake_code";

            btnmod.Enabled = false;
        }

        private void i_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            
           //  MetroFramework.MetroMessageBox.Show(this, "\n \nMake sure of the textbox not null  :" + intak, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
           //gridControl1.DataSource = req.GET_All_request_course(intak);
            /*id_par.Properties.DataSource = req.GET_intake_student(intak);
            id_par.Properties.DisplayMember = "student_id";
            id_par.Properties.ValueMember = "Unique_num";*/
        }

        private void i_EditValueChanged(object sender, EventArgs e)
        {
            int intak = Convert.ToInt32(i.EditValue);
            gridControl1.DataSource = req.GET_All_request_course(intak);

        }

        private void gridView1_RowClick_1(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            id = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "code").ToString());
            accepted.Visible = true;
            accepted1.Visible = true;
            btnmod.Enabled = true;

           
          
        }
    }
}