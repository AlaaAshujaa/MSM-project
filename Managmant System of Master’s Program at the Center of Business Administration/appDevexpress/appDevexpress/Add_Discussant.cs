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
using System.Data;
using System.Data.SqlClient;
namespace appDevexpress
{
    public partial class Add_Discussant : Form
    {
        BL.ADD_Discussant D = new BL.ADD_Discussant();
        BL.CLS_Attendances fff = new BL.CLS_Attendances();
        int id;
        DataClasses1DataContext data = new DataClasses1DataContext();
    
        public Add_Discussant()
        {
            InitializeComponent();
        }

        private void searchControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Add_Discussant_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = D.Get_All_Discussant(); ;

            i.Properties.DataSource = data.Intakes;
            i.Properties.DisplayMember = "num_intake";
            i.Properties.ValueMember = "Intake_code";
      
        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void i_EditValueChanged(object sender, EventArgs e)
        {
            int intas = Convert.ToInt32(i.EditValue.ToString());

            stu.Properties.DataSource = fff.GET_intake_student(intas);
            stu.Properties.DisplayMember = "student_id";
            stu.Properties.ValueMember = "Unique_num";
       
        }

        private void stu_EditValueChanged(object sender, EventArgs e)
        {
            Txtdoctor.Text = D.Get_DOCTOR(stu.EditValue.ToString());
            title.Text = D.Get_Title_research(stu.EditValue.ToString());
            last.Text = D.Get_DOCTOR_last(stu.EditValue.ToString());
       
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            id = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "code").ToString());
            inter.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Internal_Examainer").ToString();

            exter.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "External_Examiner").ToString();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string st = stu.EditValue.ToString();
                SqlConnection con = new SqlConnection(@"server=PC;Database=MSM; integrated security=true");
                con.Open();
                SqlCommand cmd = new SqlCommand(" select count(Unique_num) from Discussant where Unique_num= '" + st + "'", con);
                int ir = Convert.ToInt32(cmd.ExecuteScalar());
                if (ir == 0)
                {
                    if (i.Text != "" && inter.Text != "" && exter.Text != "" && stu.Text != "")
                    {

                        int i_c = Convert.ToInt32(i.EditValue);
                        D.Add_all_Discussant(i_c, st, exter.Text, inter.Text);



                        MetroFramework.MetroMessageBox.Show(this, "\n \n Done Add successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gridControl1.DataSource = D.Get_All_Discussant();
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "\n \nMake sure of the textbox not null  :", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "\n \n this record have been added pervious. ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


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

                if (id != 0)
                {


                    D.DELETE_Discussant(id);

                    MetroFramework.MetroMessageBox.Show(this, "\n \n Done Delete  " + stu.Text + "  successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridControl1.DataSource = D.Get_All_Discussant();
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

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                if (i.Text != "" && inter.Text != "" && exter.Text != "" && stu.Text != "")
                {

                    int i_c = Convert.ToInt32(i.EditValue);
                    string st = stu.EditValue.ToString();

                    D.UPDATE_Discussant(i_c, st, inter.Text, exter.Text, id);
                    MetroFramework.MetroMessageBox.Show(this, "\n \n Update Add successefuly", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridControl1.DataSource = D.Get_All_Discussant();

                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "\n \nMake sure of the textbox not null  :", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "Please choose the item to update", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}