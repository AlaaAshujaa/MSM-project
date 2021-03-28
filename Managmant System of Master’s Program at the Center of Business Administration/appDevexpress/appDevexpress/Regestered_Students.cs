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
using System.Data.SqlClient;

namespace appDevexpress
{
    public partial class inta : Form
    {
        SqlConnection con = new SqlConnection(@"server=PC;Database=MSM; integrated security=true");
        string msm = "MSM";
        DataClasses1DataContext data = new DataClasses1DataContext();
        string id;
        string t;
        string a="";
        string stud_id;

        BL.CLS_INTAKE i = new BL.CLS_INTAKE();
        BL.CLS_REGISTERED_STUDNENT registered = new BL.CLS_REGISTERED_STUDNENT();
        public inta(string stud_id)
        {
            this.stud_id = stud_id;
            InitializeComponent();
        }

        private string GenerateID()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(Unique_num) from registered_student", con);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            i++;
            return msm + i.ToString();

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            //saveFileDialog1.InitialDirectory = "E:";
            //saveFileDialog1.Title = "Save as Excel file";
            //saveFileDialog1.FileName = "";
            //saveFileDialog1.Filter = "Excel Files(2003)|*.xls|Excel Files(2010)|*.xlsx";
            //if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            //{
            //    Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            //    ExcelApp.Application.Workbooks.Add(Type.Missing);

            //    ExcelApp.Columns.ColumnWidth = 20;

            //    //storing header part in Excel

            //    for (int i = 1; i < gridControl1.Columns.Count + 1; i++)
            //    {
            //        ExcelApp.Cells[1, i] = gridControl1.Columns[i - 1].Name;
            //    }
            //    // storing each row and column value to excel sheet
            //    for (int i = 0; i < gridControl1.Rows.Count; i++)
            //    {
            //        for (int j = 0; j < gridControl1.Columns.Count; j++)
            //        {
            //               ExcelApp.Cells[i + 2, j + 1] = gridControl1.Rows[i].Cells[j].Value;
            //        }
            //    }
            //    ExcelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName.ToString());
            //    ExcelApp.ActiveWorkbook.Saved = true;
            //    MetroFramework.MetroMessageBox.Show(this, "\n Process Completed Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    ExcelApp.Quit();
            //}
        }

        private void Regestered_Students_Load(object sender, EventArgs e)
        {
            textEdit1.Text = stud_id;
            gridControl1.DataSource = registered.GET_ALL_Registered();
            r_i.Properties.DataSource = data.Intakes;
            r_i.Properties.DisplayMember = "num_intake";
            r_i.Properties.ValueMember = "Intake_code";
        }




        private void simpleButton2_Click(object sender, EventArgs e)
        {
           
         

        }

        private void gridR_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void path_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void path_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            OpenFileDialog p = new OpenFileDialog();
            p.ShowDialog();
            path.Text = p.FileName.ToString();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
                    }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {


            if (r_i.Text != "" && wor.Text != "" && sp.Text != "" && path.Text != "")
            {
                int intak = Convert.ToInt32(r_i.EditValue);
                string d = tofel.EditValue.ToString();
                a = accepted.Text;
                if (a == "")
                {
                    a = "";
                }
                else
                {
                    a = accepted.EditValue.ToString();
                }
                int d_c = 1;// Convert.ToInt32(((DataRowView)c.EditValue)["doctor_code"]);
                registered.UPDATE_Registered_Student(tofel.EditValue.ToString(), sp.Text, wor.Text, path.Text, intak, a, id);

                MetroFramework.MetroMessageBox.Show(this, "\n \n Done update successefuly" + id, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                gridControl1.DataSource = registered.GET_ALL_Registered();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "\n \nMake sure of the textbox not null  :", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void tofel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(student_id) from registered_student where student_id= '" + stud_id +"'", con);
            int i = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();



           // MetroFramework.MetroMessageBox.Show(this, "\n \n Done Add successefuly" +i, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if(i==0){
                if (accepted.Text != "" && tofel.Text != "" && r_i.Text != "" && wor.Text != "" && sp.Text != "" && path.Text != "")
            {
                int intak = Convert.ToInt32(r_i.EditValue);
                string d = tofel.EditValue.ToString();

                string ff = GenerateID();
                int f = Convert.ToInt32(r_i.EditValue.ToString());
                registered.add_Registered_Student(ff, tofel.Text, sp.Text, wor.Text, path.Text, stud_id, f, accepted.Text);
                MetroFramework.MetroMessageBox.Show(this, "\n \n Done Add successefuly" + id, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                gridControl1.DataSource = registered.GET_ALL_Registered_Student();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "\n \nMake sure of the textbox not null  :", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }


        else{

            MetroFramework.MetroMessageBox.Show(this, "\n \nThis record have been added pervious  :", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

    
    }
            
        }

        private void simpleButton4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            //id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Unique_num").ToString();
            //stud_id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "student_id").ToString();
            //wor.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Worked_Fulltime").ToString();
            //sp.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Specialization").ToString();
            //path.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "document_path").ToString();
           // txtcell.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Cell_Phone").ToString();
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            if (r_i.Text != "" && wor.Text != "" && sp.Text != "" && path.Text != "")
            {
                int intak = Convert.ToInt32(r_i.EditValue);
                string d = tofel.EditValue.ToString();
            
                int d_c = 1;// Convert.ToInt32(((DataRowView)c.EditValue)["doctor_code"]);
                registered.UPDATE_Registered_Student(tofel.EditValue.ToString(), sp.Text, wor.Text, path.Text, intak, accepted.Text, id);

                MetroFramework.MetroMessageBox.Show(this, "\n \n Done update successefuly" + id, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                gridControl1.DataSource = registered.GET_ALL_Registered_Student();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "\n \nMake sure of the textbox not null  :", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void gridControl1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}