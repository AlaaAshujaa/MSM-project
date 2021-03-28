using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Microsoft.Win32;

namespace appDevexpress
{
    public partial class MSM : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MSM()
        {
            InitializeComponent();
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            Doctor d = new Doctor();
            d.Show();
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            Master_Programs mster = new Master_Programs();
            mster.Show();

        }

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem28_ItemClick(object sender, ItemClickEventArgs e)
        {
         

            if (MetroFramework.MetroMessageBox.Show(this, "\n \n Are you sure to exit from Programs ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Application.Exit();               
            }
            
        }

        private void barButtonItem25_ItemClick(object sender, ItemClickEventArgs e)
        {
            barAndDockingController1.LookAndFeel.SkinName = "Visual Studio 2013 Blue";
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void navBarControl1_Click(object sender, EventArgs e)
        {

        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Doctor d = new Doctor();
            d.Show();
        }

        
        private void MSM_Load(object sender, EventArgs e)
        {
            this.barStaticItem1.Caption ="User Name : "+" "+ Program1.name;
            this.barStaticItem2.Caption = "Date : " + " " + DateTime.Now.Date.ToShortDateString() + "  \t \t \t \t \t\t \t \t \t \t \t \t \t \t \t \t \t \t \t \t";

            RegistryKey SkinName = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\WINREGISTRY");
            if (SkinName != null) {
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName = SkinName.GetValue("SkinName").ToString();
            }
        
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.barStaticItem4.Caption = "  Time now : " + " " + DateTime.Now.ToLongTimeString();
        }

        private void MSM_FormClosing(object sender, FormClosingEventArgs e)
        {
            RegistryKey SkinName = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\WINREGISTRY");
            SkinName.SetValue("SkinName", DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName.ToString());
            SkinName.Close();
        }

        private void barButtonItem30_ItemClick(object sender, ItemClickEventArgs e)
        {
            Create_Backup create = new Create_Backup();
            create.Show();
        }

        private void barButtonItem31_ItemClick(object sender, ItemClickEventArgs e)
        {
            Resture_Backup resture = new Resture_Backup();
            resture.Show();
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            Examcs E = new Examcs();
            E.Show();
        }

        private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
        {
            Add__Courses add = new Add__Courses();
            add.Show();
        }

        private void barButtonItem29_ItemClick(object sender, ItemClickEventArgs e)
        {
            Course_B_D c = new Course_B_D();
            c.Show();
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Master_Programs m = new Master_Programs();
            m.Show();
        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Examcs d = new Examcs();
            d.Show();
        }

        private void navBarItem16_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Create_Backup c = new Create_Backup();
            c.Show();
        }

        private void navBarItem18_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Resture_Backup b = new Resture_Backup();
            b.Show();

        }

        private void navBarItem15_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Add__Courses d = new Add__Courses();
            d.Show();
        }

        private void navBarItem17_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Course_B_D c = new Course_B_D();
            c.Show();

        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            INTAKE i = new INTAKE();
            i.ShowDialog();
        }

        private void navBarItem14_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            INTAKE i = new INTAKE();
            i.ShowDialog();
        }

        private void barButtonItem35_ItemClick(object sender, ItemClickEventArgs e)
        {
            Add_Users add = new Add_Users();
            add.ShowDialog();
        }

        private void barStaticItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem36_ItemClick(object sender, ItemClickEventArgs e)
        {
            Privileges priv = new Privileges();
            priv.ShowDialog();
        }

        private void barButtonItem33_ItemClick(object sender, ItemClickEventArgs e)
        {
            Research r = new Research();
            r.ShowDialog();
        }

        private void barButtonItem32_ItemClick(object sender, ItemClickEventArgs e)
        {
            Add_Discussant a = new Add_Discussant();
            a.ShowDialog();
        }

        private void barButtonItem34_ItemClick(object sender, ItemClickEventArgs e)
        {
            Add_GradeDiscussion a = new Add_GradeDiscussion();
            a.ShowDialog();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            Grievance_MSM N = new Grievance_MSM();
            N.ShowDialog();
        
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            Grievance_Center c = new Grievance_Center();
            c.ShowDialog();
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            Add_Books b = new Add_Books();
            b.ShowDialog();
        
          
        }

        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Add_Books b = new Add_Books();
            b.ShowDialog();
        
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            //inta r = new inta();

            //r.ShowDialog();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            Graduate_Student g = new Graduate_Student();
            g.ShowDialog();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            Failed_Students f = new Failed_Students();
            f.ShowDialog();
        }

        private void navBarItem7_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            //inta r = new inta();

            //r.ShowDialog();
        }

        private void navBarItem8_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Graduate_Student g = new Graduate_Student();
            g.ShowDialog();
        }

        private void navBarItem9_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Failed_Students f = new Failed_Students();
            f.ShowDialog();
        }

        private void navBarItem10_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Grievance_MSM N = new Grievance_MSM();
            N.ShowDialog();
        }

        private void navBarItem11_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Grievance_Center c = new Grievance_Center();
            c.ShowDialog();
        }

        private void barButtonItem37_ItemClick(object sender, ItemClickEventArgs e)
        {
            Request_ResetExam s = new Request_ResetExam();
            s.ShowDialog();
        }

        private void barButtonItem38_ItemClick(object sender, ItemClickEventArgs e)
        {
            Requset_Course s = new Requset_Course();
            s.ShowDialog();
        }

        private void navBarItem19_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Request_ResetExam s = new Request_ResetExam();
            s.ShowDialog();
        }

        private void navBarItem20_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Requset_Course s = new Requset_Course();
            s.ShowDialog();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            Student_State s = new Student_State();
            s.ShowDialog();
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            Grades s = new Grades();
            s.ShowDialog();
        }

        private void navBarItem12_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Student_State s = new Student_State();
            s.ShowDialog();
        }

        private void navBarItem13_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Grades s = new Grades();
            s.ShowDialog();
        }

        private void barButtonItem39_ItemClick(object sender, ItemClickEventArgs e)
        {
            Student_Information_cs s = new Student_Information_cs();
            s.ShowDialog();
        }

        private void navBarItem21_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Student_Information_cs s = new Student_Information_cs();
            s.ShowDialog();
        }
    }
}