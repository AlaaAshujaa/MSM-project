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
    public partial class Student_Information_cs : Form
    {
        DataClasses1DataContext data = new DataClasses1DataContext();

        BL.CLS_STUDENT student = new BL.CLS_STUDENT();
        int id;
        public Student_Information_cs()
        {
            InitializeComponent();
            gridControl1.DataSource = student.Get_All_student();
        }

        private void Student_Information_cs_Load(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = "E:";
            saveFileDialog1.Title = "Save as Excel file";
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "Excel Files(2003)|*.xls|Excel Files(2010)|*.xlsx";
            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
               Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                ExcelApp.Application.Workbooks.Add(Type.Missing);

               ExcelApp.Columns.ColumnWidth = 20;

                //storing header part in Excel

               for (int i = 1; i < gridControl1.Columns.Count + 1; i++)
                {
                    ExcelApp.Cells[1, i] = gridControl1.Columns[i - 1].Name;
               }
                // storing each row and column value to excel sheet
             for (int i = 0; i < gridControl1.Rows.Count; i++)
                {
                    for (int j = 0; j < gridControl1.Columns.Count; j++)
                    {
                         ExcelApp.Cells[i + 2, j + 1] = gridControl1.Rows[i].Cells[j].Value;
                    }
               }
               ExcelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName.ToString());
               ExcelApp.ActiveWorkbook.Saved = true;
             MetroFramework.MetroMessageBox.Show(this, "\n Process Completed Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ExcelApp.Quit();
            }
        }

        private void btnmod_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}