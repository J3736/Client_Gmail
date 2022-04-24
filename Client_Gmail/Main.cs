using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
namespace Client_Gmail
{
    public partial class frmMain : Form
    {
        public static readonly string _gmail = "testkhoadeptraivl@gmail.com";
        public static readonly string _pass = "Ivagrentina123";
        public static bool SendGmail (string sendto, string subject, string content)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress(_gmail);
                mail.To.Add(sendto);
                mail.Subject = subject;
                mail.IsBodyHtml = true;
                mail.Body = content;

                mail.Priority = MailPriority.High;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential(_gmail, _pass);
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public frmMain()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbGmail_Click(object sender, EventArgs e)
        {
            tbGmail.Clear();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (tbGmail.Text == String.Empty)
            {
                MessageBox.Show("Gmail's Receiver is empty.");
            }
            if (tbSubject.Text == String.Empty)
            {
                MessageBox.Show("Your gmail is empty.");
            }
            if (rtbContent.Text == String.Empty)
            {
                MessageBox.Show("Your content is empty.");
            }
            if (SendGmail(tbGmail.ToString(),tbSubject.ToString(),rtbContent.ToString()) == true)
            {
                MessageBox.Show("Successful.");
            }
            else
            {
                MessageBox.Show("WTF. Check lại hộ cái hoặc code lỗi rồi =))");
            }

        }

        private void tbSubject_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSubject_Click(object sender, EventArgs e)
        {
            tbSubject.Clear();
        }
    }
}
