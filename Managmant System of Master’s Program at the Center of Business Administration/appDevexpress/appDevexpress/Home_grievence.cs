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
    public partial class Home_grievence : MetroFramework.Forms.MetroForm
    {
        public Home_grievence()
        {
            InitializeComponent();
        }

        private void Home_grievence_Load(object sender, EventArgs e)
        {

        }

        private void metroTile15_Click(object sender, EventArgs e)
        {
            Grievance_Center gc = new Grievance_Center();
            gc.ShowDialog();
        }

        private void metroTile16_Click(object sender, EventArgs e)
        {
            Grievance_MSM gm = new Grievance_MSM();
            gm.ShowDialog();
        }
    }
}
