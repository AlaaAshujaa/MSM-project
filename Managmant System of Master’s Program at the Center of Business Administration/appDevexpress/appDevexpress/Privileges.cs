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
    public partial class Privileges : Form
    {
        DataClasses1DataContext data = new DataClasses1DataContext();
        public Privileges()
        {
            InitializeComponent();
            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gridView1.RowCount;i++ )
            {
                int screen_id = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Screen_ID"));
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Privileges_Load(object sender, EventArgs e)
        {
           
            l.Properties.DataSource = data.TB_Lists;
            l.Properties.DisplayMember = "list_name";
            l.Properties.ValueMember = "list_ID";

            u.Properties.DataSource = data.Users;
            u.Properties.DisplayMember = "employee_name";
            u.Properties.ValueMember = "user_code";

        }

        private void u_EditValueChanged(object sender, EventArgs e)
        {

            //try
            //{
            //    int k = Convert.ToInt32(l.EditValue);
            //    labelControl2.Text = k.ToString(); 
            //    int r = Convert.ToInt32(u.EditValue);
            //    labelControl3.Text = r.ToString();
            //    gridControl1.DataSource = data.GET_ALL_Privileges(k, r);
               
            //}
            //catch (Exception ex)
            //{
            //    MetroFramework.MetroMessageBox.Show(this, "Error :\n Number 1 " + ex.Message, "Error :\n", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            
        }
    }
}