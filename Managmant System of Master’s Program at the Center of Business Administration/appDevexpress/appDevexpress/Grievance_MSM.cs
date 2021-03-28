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
    public partial class Grievance_MSM : Form
    {
        DataClasses1DataContext data = new DataClasses1DataContext();

        BL.CLS__grievance_msm msm = new BL.CLS__grievance_msm();

        int id;
        public Grievance_MSM()
        {
            InitializeComponent();
        }

        private void Grievance_MSM_Load(object sender, EventArgs e)
        {
            i.Properties.DataSource = data.Intakes;
            i.Properties.DisplayMember = "num_intake";
            i.Properties.ValueMember = "Intake_code";

            btnmod.Enabled = false;
        }

        private void gridLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            int intak = Convert.ToInt32(i.EditValue);
            gridControl1.DataSource = msm.GET_All_grievance_msm(intak);
        }
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
           
        }

        private void btnmod_Click(object sender, EventArgs e)
        {

            int intak = Convert.ToInt32(i.EditValue);
            try
            {

                if (accepted1.EditValue != "")
                {
                    msm.UPDATE_grievance_msm(accepted1.Text, id);

                    MetroFramework.MetroMessageBox.Show(this, "\n \n Done Update " + accepted1.EditValue + "  successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridControl1.DataSource = msm.GET_All_grievance_msm(intak);
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

        private void gridView3_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            id = Convert.ToInt32(gridView3.GetRowCellValue(gridView3.FocusedRowHandle, "code").ToString());
            accepted.Visible = true;
            accepted1.Visible = true;
            btnmod.Enabled = true;
        }
    }
}