using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace OnlyWorks.services
{
    public class EmailService
    {
        public String SendVerificationEmail(string recieverEmail)
        {
            try
            {
                Random rnd = new Random();
                int confirmationCode = rnd.Next(100000, 999999);
                MailMessage msj = new MailMessage();
                SmtpClient client = new SmtpClient();

                client.Credentials = new NetworkCredential("aybeydavutefe@gmail.com", "jspp odhm pbhw pewc");
                client.Port = 587;
                client.Host = "smtp.gmail.com";
                client.EnableSsl = true;

                msj.To.Add(recieverEmail);
                msj.From = new MailAddress("aybeydavutefe@gmail.com");
                msj.Subject = "Güvenlik Kodu";
                msj.Body = confirmationCode.ToString();

                client.Send(msj);

                MessageBox.Show("Güvenlik Kodu Gönderildi");

                return confirmationCode.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }


        }
    }
}
