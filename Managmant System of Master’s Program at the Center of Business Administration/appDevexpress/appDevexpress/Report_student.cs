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
    public partial class Report_student : MetroFramework.Forms.MetroForm
    {
        public Report_student()
        {
            InitializeComponent();
        }

        private void Report_student_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'data_base1.grade' table. You can move, or remove it, as needed.
           // this.gradeTableAdapter.Fill(this.data_base1.grade);

        }

        private void documentViewer1_Load(object sender, EventArgs e)
        {
                    }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Attendance_Design attendance= new Attendance_Design();
            attendance.Show();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Attedance_list al = new Attedance_list();
            al.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            student_reporting2 sr = new student_reporting2();
            sr.ShowDialog();
        }
    }
}
