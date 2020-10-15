using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Pizzeria
{
    class EmailHandler
    {
        public static void SendMessage(Form1 aForm, ListBox.ObjectCollection aItems, string aComment)
        {
            SmtpClient client = new SmtpClient()
            {
                Host = Properties.Settings.Default.Host,
                Port = Properties.Settings.Default.Port,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential()
                {
                    UserName = Properties.Settings.Default.EmailFrom,
                    Password = Properties.Settings.Default.Password,
                }
            };
            MailAddress fromMail = new MailAddress(Properties.Settings.Default.EmailFrom, "Pizzeria");
            MailAddress toMail = new MailAddress(Properties.Settings.Default.EmailTo, "Drogi Kliencie!");
            MailMessage message = new MailMessage()
            {
                From = fromMail,
                Subject = "Zamówienie",
                Body = CreateMessageBody(aItems, aComment),
                IsBodyHtml = true,
            };
            message.To.Add(toMail);

            client.SendCompleted += aForm.EmailHandlerSendMessage_Completed;
            client.SendMailAsync(message);
        }

        static private string CreateMessageBody(ListBox.ObjectCollection aItems, string aComment)
        {
            string messageBody = "<h2>Witam,</h2> <h3>Zamówienie:</h3>";
            int orderPrice = 0;

            foreach (Dish dish in aItems)
            {
                messageBody += dish.Name + " " + dish.Extras + " - " + Convert.ToString(dish.Quantity) + "szt - " + dish.TotalPrice + "zł <br />";
                orderPrice += Convert.ToInt32(dish.TotalPrice);
            }
            messageBody += "<br />";
            messageBody += "<h3>" + "Koszt zamówienia: " + Convert.ToString(orderPrice) + "zł </h3>";
            if (aComment.Count() > 0)
            {
                messageBody += "<h3>Uwagi do zamówienia:</h3>" + aComment + "<br />";
            }
            messageBody += "<h2>Dziękujemy za zamówienie</h2>";

            return messageBody;
        }

    }
}
