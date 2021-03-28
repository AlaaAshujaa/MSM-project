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
using System.Web;
using System.Net.Mail;
using System.Net;
namespace appDevexpress
{
    public partial class Mail : Form
    {
        public Mail()
        {
            InitializeComponent();
            password.PasswordChar = '*';
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage(from.Text, to.Text, subject.Text, body.Text);
                mail.Attachments.Add(new Attachment(Attachment.Text));
                SmtpClient client = new SmtpClient(smtp.Text);
                client.Port = 587;
                client.Credentials = new System.Net.NetworkCredential(username.Text, password.Text);
                client.EnableSsl = true;
                client.Send(mail);
                MetroFramework.MetroMessageBox.Show(this, "Mail sent ! successfully", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Error :\n Number 1 " + ex.Message, "Error :\n", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string picPath = dlg.FileName.ToString();
                Attachment.Text = picPath;
            }
        }

        private void Mail_Load(object sender, EventArgs e)
        {

        }
    }
}