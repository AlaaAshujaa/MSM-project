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
    public partial class Home_search : MetroFramework.Forms.MetroForm
    {
        public Home_search()
        {
            InitializeComponent();
        }
        public void metr(){
            this.metroTile1.Enabled = false;
        }
      

        private void Home_search_Load(object sender, EventArgs e)
        {
            Login g = new Login();
            BL.CLS_LOGIN log = new BL.CLS_LOGIN();
           // label2.Text= g.na;
            //string ds = log.get_priv(g.na, g.type);
            //if (ds == "secretary") {
            //    metroTile1.Enabled = false;
            //}
        }

        private void metroTile15_Click(object sender, EventArgs e)
        {
            Research re = new Research();
            re.ShowDialog();
        }

        private void metroTile16_Click(object sender, EventArgs e)
        {
            Add_Discussant dis = new Add_Discussant();
            dis.ShowDialog();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Add_GradeDiscussion g_dis = new Add_GradeDiscussion();
            g_dis.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
