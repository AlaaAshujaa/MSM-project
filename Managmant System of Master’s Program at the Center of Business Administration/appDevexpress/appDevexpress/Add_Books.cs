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
    public partial class Add_Books : Form
    {
        DataClasses1DataContext data = new DataClasses1DataContext();

        BL.CLS_book BOOK = new BL.CLS_book();
        string id;
        public Add_Books()
        {
            InitializeComponent();
        }

        private void Add_Books_Load(object sender, EventArgs e)
        {
            grid.DataSource = BOOK.GET_ALL_book();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (txtispn.Text != "" && txtname.Text != "" && txtpup.Text != "" && txtauthor.Text != "" && txttext.Text != "")
            {



                BOOK.Add_book(txtispn.Text, txtname.Text, txtpup.Text, txtauthor.Text, txttext.Text);
                MetroFramework.MetroMessageBox.Show(this, "\n \n Done add  " + txtname.Text + "  successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.grid.DataSource = BOOK.GET_ALL_book();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "\n \nMake sure of the textbox not null or the Password like the Replay Password :", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtname.Text != "" && txtpup.Text != "" && txtauthor.Text != "" && txttext.Text != "")
                {



                    BOOK.UPDATE_Book(txtname.Text, txtpup.Text, txtauthor.Text, txttext.Text, id);

                    MetroFramework.MetroMessageBox.Show(this, "\n \n Done Update successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.grid.DataSource = BOOK.GET_ALL_book();
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
            try
            {

                if (txtispn.Text != "" && txtname.Text != "" && txtpup.Text != "" && txtauthor.Text != "" && txttext.Text != "")
                {




                    BOOK.DELETE_Book(id);

                    MetroFramework.MetroMessageBox.Show(this, "\n \n Done Delete   successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtispn.Text = "";
                    txtname.Text = "";
                    txtpup.Text = "";

                    txtauthor.Text = "";
                    txttext.Text = "";
                    this.grid.DataSource = BOOK.GET_ALL_book();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Please choose the item to delete", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error :\n Number 1 " + ex.Message, "Error :\n", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = grid.CurrentRow.Cells[0].Value.ToString();
            this.txtispn.Text = grid.CurrentRow.Cells[0].Value.ToString();
            this.txtname.Text = grid.CurrentRow.Cells[1].Value.ToString();
            this.txtpup.Text = grid.CurrentRow.Cells[2].Value.ToString();
            this.txtauthor.Text = grid.CurrentRow.Cells[3].Value.ToString();
            this.txttext.Text = grid.CurrentRow.Cells[4].Value.ToString();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            grid.DataSource = BOOK.SEARCH_book(txtsear.Text);
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}