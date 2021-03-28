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
    public partial class Home : MetroFramework.Forms.MetroForm
    {
        string name;
        string type;
        public Home(string name, string type)
        {
            this.name = name;
            this.type = type;
            InitializeComponent();
        
        }

        public void LoadDefaultPermission(MetroFramework.Forms.MetroForm form)
        {
            //load default Permission
            foreach (var btn in form.Controls.OfType<MetroTile>())
            {

                btn.Enabled = false;
                //btn.BackColor = Color.FromArgb(0x91, 0xC0, 0xBC, 0xBC);

            }
        }

        public void metru()
        {

            LoadDefaultPermission(this);
            this.metroTile13.Enabled = true;
            this.metroTile13.BackColor = Color.FromArgb(230, 170, 65);
           
            this.metroTile15.Enabled = true;
            this.metroTile15.BackColor = Color.FromArgb(36, 151, 208);
            this.metroTile12.Enabled = true;
            this.metroTile12.BackColor = Color.FromArgb(230, 170, 65);
            this.metroTile3.Enabled = true;
            this.metroTile3.BackColor = Color.DarkGray;
            this.metroTile1.Enabled = true;
            this.metroTile1.BackColor = Color.Chocolate;
            string d;
      

        }

        public void metrperm()
        {
            LoadDefaultPermission(this);
            this.metroTile8.Enabled = true;

        }



        private void Home_Load(object sender, EventArgs e)
        {
            timer1.Start();
            label4.Text = DateTime.Now.ToLongTimeString();
            label5.Text = DateTime.Now.ToLongDateString();
            label3.Text = name;
            Home_search hf = new Home_search();
           
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Doctor a_t = new Doctor();
            a_t.ShowDialog();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
           Add_Users  u =new Add_Users();
           u.ShowDialog();

        }

        private void metroTile13_Click(object sender, EventArgs e)
        {
            Home_course hc = new Home_course();
            hc.ShowDialog();
        }

        private void metroTile14_Click(object sender, EventArgs e)
        {  
               Home_search d = new Home_search();
            d.ShowDialog();
            Login g=new Login();
            if (g.sg == "secretary") {

                d.metroTile1.Enabled = false;
            }
        }

        private void metroTile8_Click(object sender, EventArgs e)
        {
            Add_Books a = new Add_Books();
            a.ShowDialog();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Home_backup hb = new Home_backup();
            hb.ShowDialog();
        }

        private void metroTile9_Click(object sender, EventArgs e)
        {
            Home_grievence hg = new Home_grievence();
            hg.ShowDialog();
        }

        private void metroTile16_Click(object sender, EventArgs e)
        {
            Grades g = new Grades();
            g.ShowDialog();

        }

        private void metroTile12_Click(object sender, EventArgs e)
        {
            Master_Programs m = new Master_Programs();
            m.ShowDialog();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            Examcs ee = new Examcs();
            ee.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            std_home std = new std_home();
            std.ShowDialog();
        }

        private void metroTile10_Click(object sender, EventArgs e)
        {
            Mail m = new Mail();
            m.ShowDialog();
        }

        private void metroTile15_Click(object sender, EventArgs e)
        {
            Home_Reports report = new Home_Reports();
            report.ShowDialog();

        }

        private void metroTile11_Click(object sender, EventArgs e)
        {
            Home_backup bac = new Home_backup();
            bac.ShowDialog();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Attendence a = new Attendence();
            a.ShowDialog();
            
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

            
            Login log = new Login();
            log.ShowDialog();
            this.Close();
           
        }

        private void pictureBox8_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        private void metroTile18_Click(object sender, EventArgs e)
        {
            About_Programmers pro = new About_Programmers();
            pro.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
    }
}
