using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appDevexpress
{
    public partial class Attendence : Form
    {
        DataClasses1DataContext data = new DataClasses1DataContext();

        BL.CLS_Attendances attend = new BL.CLS_Attendances();
        int id;
        public Attendence()
        {
            InitializeComponent();

      
            
        }

        private void Attendence_Load(object sender, EventArgs e)
        {
          
            c.Properties.DataSource = data.Add_Courses;
            c.Properties.DisplayMember = "name";
            c.Properties.ValueMember = "course_code";

            i.Properties.DataSource = data.Intakes;
            i.Properties.DisplayMember = "num_intake";
            i.Properties.ValueMember = "Intake_code";

         
            simpleButton7.Enabled = false;
            
        }

        private void gridLookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
          
        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            if (id_par.Text != "" && i.Text != "" && c.Text != "" && num.Text != " " && date.Text != " ")
            {
                
                string f = id_par.EditValue.ToString();
                int intak = Convert.ToInt32(i.EditValue);
                int numr = Convert.ToInt32(num.Text);
                int co = Convert.ToInt32(c.EditValue);
                int ad= 4-numr;
                attend.ADD_Attendances(f,numr,ad,date.Text,intak,co);
                MetroFramework.MetroMessageBox.Show(this, "\n \n Done Add successefuly  " + id_par.Text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                gridControl1.DataSource = attend.GET_ALL_Attendances(intak);
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "\n \nMake sure of the textbox not null  :", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void i_EditValueChanged(object sender, EventArgs e)
        {
            int intak = Convert.ToInt32(i.EditValue);
           // MetroFramework.MetroMessageBox.Show(this, "\n \nMake sure of the textbox not null  :" + intak, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            gridControl1.DataSource = attend.GET_ALL_Attendances(intak);
            id_par.Properties.DataSource = attend.GET_intake_student(intak);
            id_par.Properties.DisplayMember = "student_id";
            id_par.Properties.ValueMember = "Unique_num";

        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            if (id_par.Text != "" && i.Text != "" && c.Text != "" && num.Text != " " && date.Text != " ")
            {

                string f = id_par.EditValue.ToString();
                int intak = Convert.ToInt32(i.EditValue);
                int numr = Convert.ToInt32(num.Text);
                int co = Convert.ToInt32(c.EditValue);
                int ad = 4-numr ;
                attend.UPDATE_Attendances(f, numr, ad, date.Text, intak, co,id);
                MetroFramework.MetroMessageBox.Show(this, "\n \n Done Add successefuly  " + id_par.Text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                gridControl1.DataSource = attend.GET_ALL_Attendances(intak);
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "\n \nMake sure of the textbox not null  :", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
          //  int intak = Convert.ToInt32(i.EditValue);
            id = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle,"code").ToString());
            num.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "HoureCome").ToString();
           // id_par.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Unique_num").ToString();
           // i.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "num_intake").ToString(); 
           // date.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "date").ToString();
         //   gridControl1.DataSource = attend.GET_ALL_Attendances(intak);
            simpleButton7.Enabled = true;

        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            try
            {

                if (id != 0)
                {
                    int intak = Convert.ToInt32(i.EditValue);

                    attend.DELETE_Attendances(id);

                    MetroFramework.MetroMessageBox.Show(this, "\n \n Done Delete  " + id_par.Text + "  successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridControl1.DataSource = attend.GET_ALL_Attendances(intak);
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

        private void simpleButton5_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void id_par_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
