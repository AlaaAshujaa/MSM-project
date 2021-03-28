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
using System.Data.SqlClient;

namespace appDevexpress
{
    public partial class Resture_Backup : Form
    {
        SqlConnection con = new SqlConnection(@"server=.\;Database=MSM; integrated security=true");

        public Resture_Backup()
        {
            InitializeComponent();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textEdit2.Text = openFileDialog1.FileName;


            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {

                if (textEdit2.Text != "")
                {
                    string strQuery = "ALTER Database MSM SET OFFLINE WITH ROLLBACK IMMEDIATE Restore Database MSM From Disk='" + textEdit2.Text + "'";
                    SqlCommand cmd = new SqlCommand(strQuery, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                   MessageBox.Show( "Done Restore of Backup successfully", "Restore of Backup  ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                   MessageBox.Show( "Please Choose the path of Backup", " Backup  ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :\n Number 1 " + ex.Message, "Error :\n", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
                    }

        private void Resture_Backup_Load(object sender, EventArgs e)
        {

        }
    }
}