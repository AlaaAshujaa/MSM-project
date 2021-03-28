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
    public partial class Failed_Students : Form
    {
        DataClasses1DataContext data = new DataClasses1DataContext();
        BL.CLS_StudentFail fail = new BL.CLS_StudentFail();
        public Failed_Students()
        {
            InitializeComponent();
        }

        private void Failed_Students_Load(object sender, EventArgs e)
        {




            c.Properties.DataSource = data.Add_Courses;
            c.Properties.DisplayMember = "name";
            c.Properties.ValueMember = "course_code";


            i.Properties.DataSource = data.Intakes;
            i.Properties.DisplayMember = "num_intake";
            i.Properties.ValueMember = "Intake_code";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {


            int c_c = Convert.ToInt32(c.EditValue);

            int i_c = Convert.ToInt32(i.EditValue);
            gridControl1.DataSource = fail.Get_all_StudentFail(c_c, i_c);
        }

        private void c_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}

    
    
