using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Web.Compilation;
using System.Windows.Forms;

namespace QL_NhaSach.BUS
{
    public  class EmailBUS
    {
        public void SendEmail(string recipientEmail, int otp)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("gmaisender2@gmail.com");
                mail.To.Add(recipientEmail);
                mail.Subject = "Mật Khẩu của bạn là:" + otp;
                mail.Body = "mail test";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new NetworkCredential("gmaisender2@gmail.com", "aujc ayzo yalm qeqx");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                MessageBox.Show("Mail sent successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "loi");
            }
        }




    }
}
