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
    public partial class home_sync : MetroFramework.Forms.MetroForm
    {
        public home_sync()
        {
            InitializeComponent();
        }

        private void home_sync_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            sync_stcs st = new sync_stcs();
            st.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            sync_course co = new sync_course();
            co.ShowDialog();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            sync_exam exam = new sync_exam();
            exam.ShowDialog();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            sync_msm msm = new sync_msm();
            msm.ShowDialog();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            sync_cba cba = new sync_cba();
            cba.ShowDialog();
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            sync_grade grade = new sync_grade();
            grade.ShowDialog();
        }
    }
}
