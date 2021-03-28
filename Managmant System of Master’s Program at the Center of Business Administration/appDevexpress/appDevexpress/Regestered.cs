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
    public partial class Regestered : Form
    {
           
      public  string id;
        BL.CLS_REGISTERED_STUDNENT registered = new BL.CLS_REGISTERED_STUDNENT();
        public Regestered()
        {
            InitializeComponent();
           
        }
     

        private void gridR_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //id = gridR.CurrentRow.Cells[0].Value.ToString();
            //labelControl3.Text = id;

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void searchControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void Regestered_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = registered.GET_ALL_Registered_Student();
            Registered_student r = new Registered_student();
          
 
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
             
            inta dt = new inta(id);
            dt.ShowDialog();
           
         

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            id = gridView1.GetRowCellValue(gridView1.FocusedRowHandle,"student_id").ToString();
            simpleButton6.Enabled = true;
            
            
        }
    }
}