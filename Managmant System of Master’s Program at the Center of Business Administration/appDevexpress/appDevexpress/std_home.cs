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
    public partial class std_home : MetroFramework.Forms.MetroForm
    {
        public std_home()
        {
            InitializeComponent();
        }

        private void std_home_Load(object sender, EventArgs e)
        {

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Request_ResetExam rre = new Request_ResetExam();
            rre.ShowDialog();
        }

        private void metroTile7_Click(object sender, EventArgs e)
        {
            Requset_Course rc = new Requset_Course();
            rc.ShowDialog();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
          //  inta rs = new inta();
            Regestered rs = new Regestered();
            rs.ShowDialog();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Grades gr = new Grades();
            gr.ShowDialog();
        }

        private void metroTile15_Click(object sender, EventArgs e)
        {
            Student_State ss = new Student_State();
            ss.ShowDialog();
        }

        private void metroTile11_Click(object sender, EventArgs e)
        {
            INTAKE i = new INTAKE();
            i.ShowDialog();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            Failed_Students fs = new Failed_Students();
            fs.ShowDialog();
        }

        private void metroTile9_Click(object sender, EventArgs e)
        {
            Graduate_Student gr_s = new Graduate_Student();
            gr_s.ShowDialog();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            Student_Information_cs st = new Student_Information_cs();
            st.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
