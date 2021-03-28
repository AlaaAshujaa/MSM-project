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
    public partial class Home_backup : MetroFramework.Forms.MetroForm
    {
        public Home_backup()
        {
            InitializeComponent();
        }

        private void Home_backup_Load(object sender, EventArgs e)
        {

        }

        private void metroTile15_Click(object sender, EventArgs e)
        {
            Resture_Backup r = new Resture_Backup();
            r.ShowDialog();
        }

        private void metroTile16_Click(object sender, EventArgs e)
        {
            Create_Backup n = new Create_Backup();
            n.ShowDialog();
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            Add_Users user = new Add_Users();
            user.ShowDialog();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            home_sync sync1 = new home_sync();
            sync1.ShowDialog();
        }
    }
}
