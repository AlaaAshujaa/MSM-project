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
    public partial class Research : Form
    {
        DataClasses1DataContext data = new DataClasses1DataContext();
        int id;
        string cd;
        BL.CLS_Research Resea = new BL.CLS_Research();
        BL.CLS_Grade_Discussant g = new BL.CLS_Grade_Discussant();
        public Research()
        {
            InitializeComponent();
        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void txtname_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void Research_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = Resea.GET_All_Research();
            c.Properties.DataSource = data.Get_Supervisor();
            c.Properties.DisplayMember = "first_name";
            c.Properties.ValueMember = "doctor_code";



            id_par.Properties.DataSource = g.Get_Registered_stud();
            id_par.Properties.DisplayMember = "student_id";
            id_par.Properties.ValueMember = "Unique_num";


        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void add() {

            SqlConnection con = new SqlConnection(@"server=PC;Database=MSM; integrated security=true");
            string f = id_par.EditValue.ToString();
            con.Open();
            SqlCommand cmd = new SqlCommand("select count(Unique_num) from Research where Unique_num= '" + f + "'", con);
            int ir = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();

            if (ir == 0)
            {
                if (id_par.Text != "" && c.Text != "" && textEdit3.Text != "" && from.Text != "")
                {
                   // int d_c = 1;// Convert.ToInt32(((DataRowView)c.EditValue)["doctor_code"]);
                    string s = id_par.EditValue.ToString();
                int fd=Convert.ToInt32(c.EditValue.ToString());
                    Resea.Add_Research(s,fd , textEdit3.Text, cd, from.Text);
                    MetroFramework.MetroMessageBox.Show(this, "\n \n Done Add successefuly", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    gridControl1.DataSource = Resea.GET_All_Research();
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

         public void update() {
            if (id_par.Text != ""&& c.Text != "" && textEdit3.Text != "" && from.Text != "")
            {
                int b_c = Convert.ToInt32(c.EditValue);
                string s = id_par.EditValue.ToString();
                Resea.UPDATE_Research(s, b_c, textEdit3.Text, cd, from.Text, id);
                MetroFramework.MetroMessageBox.Show(this, "\n \n Done Update successefuly", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                gridControl1.DataSource = Resea.GET_All_Research();
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "\n \nMake sure of the textbox not null  :", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        
        }
        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
           id = Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle,"Research_code").ToString());
           textEdit3.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Title_research").ToString();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           
              
                if(checkEdit1.Checked==true && checkEdit2.Checked ==true){
               cd="SW AND HW";
               add();
                }
                if(checkEdit1.Checked==true && checkEdit2.Checked ==false){
                cd="SW";
                add();
                }
                 if(checkEdit1.Checked==false && checkEdit2.Checked ==true){
                cd="HW";
                add();
                }
                 if(checkEdit1.Checked==false && checkEdit2.Checked ==false){
                     MetroFramework.MetroMessageBox.Show(this, "\n \n Make sure of the textbox not null ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

             
               
            }
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
              if(checkEdit1.Checked==true && checkEdit2.Checked ==true){
               cd="SW AND HW";
               update();
                }
                if(checkEdit1.Checked==true && checkEdit2.Checked ==false){
                cd="SW";
                update();
                }
                 if(checkEdit1.Checked==false && checkEdit2.Checked ==true){
                cd="HW";
                update();
                }
                 if (checkEdit1.Checked == false && checkEdit2.Checked == false)
                 {
                     MetroFramework.MetroMessageBox.Show(this, "\n \n Done add  successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                 }

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
          try
            {

                if (id != 0)
                {

                    
                  Resea.DELETE_Research( id);

                    MetroFramework.MetroMessageBox.Show(this, "\n \n Done Delete  " + id_par.Text + "  successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridControl1.DataSource = Resea.GET_All_Research();
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

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}