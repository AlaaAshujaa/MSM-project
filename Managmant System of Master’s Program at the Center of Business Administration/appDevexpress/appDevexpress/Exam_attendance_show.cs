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
    public partial class Exam_attendance_show : MetroFramework.Forms.MetroForm
    {
        public Exam_attendance_show()
        {
            InitializeComponent();
        }

        private void Exam_attendance_show_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'data_base1.student_view' table. You can move, or remove it, as needed.
           // this.student_viewTableAdapter.Fill(this.data_base1.student_view);

            //this.reportViewer1.RefreshReport();
        }
    }
}
