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
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public string sg;
        string name;
        public string na;
        public string type;
        BL.CLS_LOGIN log = new BL.CLS_LOGIN();
        public Login()
        {
            InitializeComponent();
        }

        bool enanble_form;
        public bool Enanble_Form {
            get { return this.enanble_form;
            }
            set { this.enanble_form = value; }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            DataTable dt = log.LOGIN(txtname.Text, txttype.Text);
             name = txtname.Text;
             na = txtname.Text;
             type = txttype.Text;

            if (dt.Rows.Count > 0)
            {
               
                Home h = new Home(name,type);
                string ds = log.get_priv(txtname.Text, txttype.Text);

                if (ds == "admin")
                {
                    this.Hide();
                    h.ShowDialog();

                }
                else if (ds == "secretary")
                {
                    this.Hide();
                   h.metru();
                   enanble_form = false;
                    h.ShowDialog();
                }
                else
                {
                    this.Hide();
                    h.metrperm();
                    h.ShowDialog();
                }

            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "\n \nLogin failed !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click_1(object sender, EventArgs e)
        {
           
        }

        private void simpleButton4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton3_Click_2(object sender, EventArgs e)
        {
            
            DataTable dt = log.LOGIN(txtname.Text, txttype.Text);
            Home_search hg = new Home_search();

            if (dt.Rows.Count > 0)
            {
                name = txtname.Text;
                type = txttype.Text;
                Home h = new Home(name,type);
                Home_search n = new Home_search();
                string ds = log.get_priv(txtname.Text, txttype.Text);

                if (ds == "admin")
                {
                    this.Hide();
                    h.ShowDialog();
                    
                }
                else if (ds == "secretary")
                {
                    this.Hide();
                    h.metru();

                    n.metroTile1.Enabled = false;
                    h.ShowDialog();
                  sg ="secretary";
                     
                    //h.metroTile16.
                }
                else
                {
                    this.Hide();
                    h.metrperm();
                    h.ShowDialog();
                }

            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "\n \nLogin failed !", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void simpleButton4_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroTile15_Click(object sender, EventArgs e)
        {

        }
    }
}