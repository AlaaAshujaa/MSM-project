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
    public partial class Add_GradeDiscussion : Form
    {
        DataClasses1DataContext data = new DataClasses1DataContext();
        BL.CLS_Grade_Discussant g = new BL.CLS_Grade_Discussant();
        int id;
        public Add_GradeDiscussion()
        {
            InitializeComponent();
        }

        private void Add_GradeDiscussion_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = g.Get_All_Grade_Discussant();
            id_par.Properties.DataSource = g.Get_Registered_stud();
            id_par.Properties.DisplayMember = "student_id";
            id_par.Properties.ValueMember = "Unique_num";

            simpleButton2.Enabled = false;

           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"server=PC;Database=MSM; integrated security=true");
            string f = id_par.EditValue.ToString();
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(Unique_num) from Grade_Discussant where [Unique_num]= '" + f + "'", con);
            int ir = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            if (ir == 0)
            {
                if (id_par.Text != "" && i.Text != "" && s.Text != "" && eg.Text != "")
                {
                    decimal d = Convert.ToDecimal(s.Text);
                    decimal de = Convert.ToDecimal(i.Text);
                    decimal dei = Convert.ToDecimal(eg.Text);
                    // string f = id_par.EditValue.ToString();
                    g.ADD_Grade_Discussant(f, d, de, dei);
                    MetroFramework.MetroMessageBox.Show(this, "\n \n Done Add successefuly  " + id_par.Text, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    gridControl1.DataSource = g.Get_All_Grade_Discussant();
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "\n \nMake sure of the textbox not null  :", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

            else
            {

                MetroFramework.MetroMessageBox.Show(this, "\n \nThis record have been added pervious", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (id_par.Text != "" && i.Text != "" && s.Text != "" && eg.Text != "")
            {
                decimal d = Convert.ToDecimal(s.Text);
                decimal de = Convert.ToDecimal(i.Text);
                decimal dei = Convert.ToDecimal(eg.Text);
                string f = id_par.EditValue.ToString();
                g.UPDATE_Grade_Discussant(f, d, de, dei,id);
                MetroFramework.MetroMessageBox.Show(this, "\n \n Update Add successefuly", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                gridControl1.DataSource = g.Get_All_Grade_Discussant();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "\n \nMake sure of the textbox not null  :", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            id = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle,"code").ToString());
            simpleButton2.Enabled = true;

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            try
            {

                if (id != 0)
                {

                    
                    g.DELETE_Grade_Discussant( id);

                    MetroFramework.MetroMessageBox.Show(this, "\n \n Done Delete  " + id_par.Text + "  successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridControl1.DataSource = g.Get_All_Grade_Discussant();
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
    }
}