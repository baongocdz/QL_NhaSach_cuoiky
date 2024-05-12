using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Web.Compilation;

namespace QL_NhaSach.BUS
{
    public  class EmailBUS
    {
        private string senderemail;
        private string senderpassword;
        public EmailBUS(string senderemail, string senderpassword)
        {
            this.senderemail = senderemail;
            this.senderpassword = senderpassword;
        }
        public string SendEmail(string recipientEmail, string recipientPassword, bool isUpdate)
        {
            try
            {
                MailMessage mailMSG = new MailMessage();
                mailMSG.From = new MailAddress(senderemail);
                if (isUpdate)
                {
                    mailMSG.Body = "Chào bạn, mật khẩu mới truy cập vào phần mềm của bạn là: " + recipientPassword;
                    mailMSG.Subject = "Bạn đã yêu cầu cấp lại mật khẩu!";
                }
                else
                {
                    mailMSG.Body = string.Format("Chào mừng, tài khoản này đã được thêm vào phần mềm với " +
                             "thông tin đăng nhập là: \n- Email: {0} \n- Mật khẩu: {1} ", recipientEmail, recipientPassword);
                    mailMSG.Subject = "Thông tin đăng nhập phần mềm!";
                }
                using(SmtpClient client = new SmtpClient())
                {
                    client.EnableSsl = true;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential(senderemail, senderpassword);
                    client.Host = "smtp.gmail.com";
                    client.Port = 587;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.Send(mailMSG);
                }
                return "Vui lòng kiểm tra Email để nhận mật khẩu mới!";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string GetRandomPassword()
        {
            Random random = new Random();
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4, true));
            builder.Append(random.Next(1000, 9999));
            builder.Append(RandomString(2, false));
            return builder.ToString();
        }
        private string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random r = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * r.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
            {
                return builder.ToString().ToUpper();
            }
            else return builder.ToString().ToLower();
        }

    }
}
