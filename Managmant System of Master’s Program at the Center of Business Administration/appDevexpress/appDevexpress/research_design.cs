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
    public partial class research_design : MetroFramework.Forms.MetroForm
    {
        public research_design()
        {
            InitializeComponent();
        }

        private void research_design_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'data_base.Intake' table. You can move, or remove it, as needed.
            this.intakeTableAdapter.Fill(this.data_base.Intake);
            // TODO: This line of code loads data into the 'data_base.View_reseach' table. You can move, or remove it, as needed.
            this.view_reseachTableAdapter.Fill(this.data_base.View_reseach);
            // TODO: This line of code loads data into the 'data_base.View_reseach' table. You can move, or remove it, as needed.
            this.view_reseachTableAdapter.Fill(this.data_base.View_reseach);
          
            look.ComboBox.DataSource = data_base.Intake;
            //look.ComboBox.Controls.ControlRemoved;
            look.ComboBox.DisplayMember = "num_intake";
            look.ComboBox.ValueMember = "Intake_code";
            

        }

        private void displayToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.view_reseachTableAdapter.Display(this.data_base.View_reseach, ((int)(System.Convert.ChangeType(look.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            gridControl1.ShowRibbonPrintPreview();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            research_show rsh = new research_show();
            rsh.ShowDialog();
        }
    }
}
