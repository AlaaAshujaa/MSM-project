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
    public partial class Grievance_Center : Form
    {
        DataClasses1DataContext data = new DataClasses1DataContext();

        BL.CLS_grievance_cba cba = new BL.CLS_grievance_cba();

        int id;
        public Grievance_Center()
        {
            InitializeComponent();
        }

        private void Grievance_Center_Load(object sender, EventArgs e)
        {
            i.Properties.DataSource = data.Intakes;
            i.Properties.DisplayMember = "num_intake";
            i.Properties.ValueMember = "Intake_code";

            btnmod.Enabled = false;
        }

        private void gridLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            int intak = Convert.ToInt32(i.EditValue);
            gridControl1.DataSource = cba.GET_All_grievance_cba(intak);
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            id = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ID").ToString());
            accepted.Visible = true;
            accepted1.Visible = true;
            btnmod.Enabled = true;
        }

        private void btnmod_Click(object sender, EventArgs e)
        {
            int intak = Convert.ToInt32(i.EditValue);
            try
            {

                if (accepted1.EditValue != "")
                {
                    cba.UPDATE_grievance_cba(accepted1.Text, id);

                    MetroFramework.MetroMessageBox.Show(this, "\n \n Done Update " + accepted1.EditValue + "  successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridControl1.DataSource = cba.GET_All_grievance_cba(intak);
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
    }
}