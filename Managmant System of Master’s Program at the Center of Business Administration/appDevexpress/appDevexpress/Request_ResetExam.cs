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
    public partial class Request_ResetExam : Form
    {
        DataClasses1DataContext data = new DataClasses1DataContext();

        BL.CLS_req_exam exam = new BL.CLS_req_exam();
        int id;
        public Request_ResetExam()
        {
            InitializeComponent();

        }

        private void Request_ResetExam_Load(object sender, EventArgs e)
        {
            i.Properties.DataSource = data.Intakes;
            i.Properties.DisplayMember = "num_intake";
            i.Properties.ValueMember = "Intake_code";

            btnmod.Enabled = false;
        }

        private void i_EditValueChanged(object sender, EventArgs e)
        {
            int intak = Convert.ToInt32(i.EditValue);
            // MetroFramework.MetroMessageBox.Show(this, "\n \nMake sure of the textbox not null  :" + intak, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            gridControl1.DataSource = exam.GET_All_request_exam(intak);
        }
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            //  int intak = Convert.ToInt32(i.EditValue);
          // id_par.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Unique_num").ToString();
            // i.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "num_intake").ToString(); 
            // date.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "date").ToString();
            //   gridControl1.DataSource = attend.GET_ALL_Attendances(intak);
            btnmod.Enabled = true;

        }

        private void btnmod_Click(object sender, EventArgs e)
        {
            int intak = Convert.ToInt32(i.EditValue);
            try
            {

                if (accepted1.EditValue != "")
                {
                    exam.UPDATE_request_exam(accepted1.EditValue.ToString(), id);

                    MetroFramework.MetroMessageBox.Show(this, "\n \n Done Update " + accepted1.EditValue + "  successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridControl1.DataSource = exam.GET_All_request_exam(intak);
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

        private void gridView1_RowClick_1(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            id = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "code").ToString());
            accepted.Visible = true;
            accepted1.Visible = true;
            btnmod.Enabled = true;
        }
    }
}