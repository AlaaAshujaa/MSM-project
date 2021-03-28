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
    public partial class Home_course : MetroFramework.Forms.MetroForm
    {
        public Home_course()
        {
            InitializeComponent();
        }

        private void Home_course_Load(object sender, EventArgs e)
        {

        }

        private void metroTile15_Click(object sender, EventArgs e)
        {
            Course_B_D c_b = new Course_B_D();
            c_b.ShowDialog();
        }

        private void metroTile16_Click(object sender, EventArgs e)
        {
            Add__Courses ac = new Add__Courses();
            ac.ShowDialog();
        }
    }
}
