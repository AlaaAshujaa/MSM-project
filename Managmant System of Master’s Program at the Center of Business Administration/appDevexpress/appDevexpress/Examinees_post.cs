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
    public partial class Examinees_post : MetroFramework.Forms.MetroForm
    {
        public Examinees_post()
        {
            InitializeComponent();
        }

        private void Examinees_post_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            examination_post eep = new examination_post();
            eep.ShowDialog();
        }
    }
}
