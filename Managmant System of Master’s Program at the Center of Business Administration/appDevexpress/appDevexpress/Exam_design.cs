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
    public partial class Exam_design : MetroFramework.Forms.MetroForm
    {
        public Exam_design()
        {
            InitializeComponent();
        }

        private void Exam_design_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Result_design rd = new Result_design();
            rd.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            examination e1 = new examination();
            e1.ShowDialog();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            Exam_Attendance ea1 = new Exam_Attendance();
            ea1.ShowDialog();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {

        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
           
        }
    }
}
