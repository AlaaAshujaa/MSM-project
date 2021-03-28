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
using System.Security.Cryptography;

namespace appDevexpress
{
    public partial class Add_Users : Form
    {
          SqlConnection con = new SqlConnection(@"server=.\SQLEXPRESS;Database=MSM; integrated security=true");
        DataClasses1DataContext data = new DataClasses1DataContext();
        BL.CLS_USERS user = new BL.CLS_USERS();
        int id;
        public Add_Users()
        {
            InitializeComponent();
        }

        private void Add_Users_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource =user.GET_ALL_USER();
             
            perm.Properties.DataSource = user.GET_ALL_Priv();
            perm.Properties.DisplayMember ="name";
            perm.Properties.ValueMember = "code";
            simpleButton2.Enabled = false;
        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private string SHA512(string password)
        {
            SHA512Managed SHA512 = new SHA512Managed();
            byte[] Hash = System.Text.Encoding.UTF8.GetBytes(password);
            Hash = SHA512.ComputeHash(Hash);
            StringBuilder sb = new StringBuilder();
            foreach (byte b in Hash)
            {
                sb.Append(b.ToString("x2").ToLower());
            }
            return sb.ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           
                string password = SHA512(txtpass.Text);

                try
                {
                    if (txtname.Text != "" && perm.Text != "" && txtpass.Text != "" && txtpass.Text == txtrplay.Text)
                    {
                        int priv_code = Convert.ToInt32(perm.EditValue);
                        user.ADD_USERS(txtname.Text, txtpass.Text, priv_code);
                        MetroFramework.MetroMessageBox.Show(this, "\n \n Add done " + txtname.Text + "  successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtname.Text = "";
                        perm.Text = "";
                        txtpass.Text = "";

                        txtrplay.Text = "";
                        gridControl1.DataSource = user.GET_ALL_USER();
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "\n \nMake sure of the textbox not null or the Password like the Replay Password :", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Error :\n Number 1 " + ex.Message, "Error :\n", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                simpleButton2.Enabled = false;
            

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtname.Text != "" && perm.Text != "" && txtpass.Text != "" && txtpass.Text == txtrplay.Text)
                {
                    int priv_code = Convert.ToInt32(perm.EditValue);

                    user.UPDATE_USERS(txtname.Text, txtpass.Text, priv_code, id);
                    MetroFramework.MetroMessageBox.Show(this, "\n \n Done Update " + txtname.Text + "  successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtname.Text = "";
                    perm.Text = "";
                    txtpass.Text = "";

                    txtrplay.Text = "";
                    gridControl1.DataSource = user.GET_ALL_USER();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "\n \nMake sure of the textbox not null or the Password like the Replay Password :", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error :\n Number 1 " + ex.Message, "Error :\n", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            //try
            //{
               if(id!=0){
                 //  int priv_code = Convert.ToInt32(perm.EditValue);
                   
                   //MessageBox.Show(""+id);

                   user.DELETE_USERS(id);

                   MetroFramework.MetroMessageBox.Show(this, "\n \n Done Delete  " + txtname.Text + "  successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                   txtname.Text = "";
                   perm.Text = "";
                   txtpass.Text = "";

                   txtrplay.Text = "";
                   this.gridControl1.DataSource = user.GET_ALL_USER();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please choose the item to delete", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            //}
            //catch (Exception ex)
            //{
            //    MetroFramework.MetroMessageBox.Show(this, "Error :\n Number 1 " + ex.Message, "Error :\n", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            id = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "user_code").ToString());
            txtname.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "user_name").ToString();
        //    perm.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "priv_code").ToString();
            txtpass.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "password").ToString();
            txtrplay.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "password").ToString();

            simpleButton2.Enabled = true;
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
           // gridControl1.DataSource = user.SEARCH_USER(txtsear.Text);
        }
    }
}