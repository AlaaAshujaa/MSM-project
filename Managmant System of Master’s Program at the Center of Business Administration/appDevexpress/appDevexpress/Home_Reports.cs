using MetroFramework.Controls;
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
    public partial class Home_Reports : MetroFramework.Forms.MetroForm
    {
        public Home_Reports()
        {
            InitializeComponent();
        }

        private void Home_Reports_Load(object sender, EventArgs e)
        {
            
        }

      
        private void metroTile5_Click_1(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Report_student r_s = new Report_student();
            r_s.ShowDialog();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            
        }

        private void metroTile1_Click_1(object sender, EventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            doctor_show dsh = new doctor_show();
            dsh.ShowDialog();
        }

        private void metroTile6_Click_1(object sender, EventArgs e)
        {
            Report_student r_s = new Report_student();
            r_s.ShowDialog();
        }

        private void metroTile16_Click(object sender, EventArgs e)
        {

            Course_show c_sh = new Course_show();
            c_sh.ShowDialog();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
           
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
             }

        private void metroTile1_Click_2(object sender, EventArgs e)
        {
            research_design rsh = new research_design();
            rsh.ShowDialog();
        }

        private void metroTile3_Click_1(object sender, EventArgs e)
        {
            Exam_design ed1 = new Exam_design();
            ed1.ShowDialog();
        }

        private void metroTile2_Click_1(object sender, EventArgs e)
        {
            doctor_show dsh = new doctor_show();
            dsh.ShowDialog();
        }
    }
}
