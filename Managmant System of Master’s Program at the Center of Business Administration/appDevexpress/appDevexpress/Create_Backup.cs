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
    public partial class Create_Backup : Form
    {
         SqlConnection con = new SqlConnection(@"server=.\;Database=MSM; integrated security=true");
        public Create_Backup()
        {
            InitializeComponent();
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textEdit2.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textEdit2.Text != "")
                {
                    string fileName = textEdit2.Text + "\\MSM" + DateTime.Now.ToShortDateString().Replace('/', '-')
                        + " - " + DateTime.Now.ToLongTimeString().Replace(':', '-');
                    string strQuery = "Backup Database MSM to Disk='" + fileName + ".bak'";
                    SqlCommand cmd = new SqlCommand(strQuery, con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                   MessageBox.Show(this, "\n \n Done Create  of Backup successfully", "Create  of Backup  ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                   MessageBox.Show(this, "\n \n Please Choose the path of Backup", " Backup  ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
             MessageBox.Show(this, "Error :\n Number 1 " + ex.Message + "\n \n You Most Choose the path in the other disk like D or E ", "Error :\n ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Create_Backup_Load(object sender, EventArgs e)
        {

        }
    }
}