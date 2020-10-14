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
        public static void send_message(Form1 form, ListBox.ObjectCollection items, string comment)
        {
            SmtpClient Client = new SmtpClient()
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
            MailAddress FromEmail = new MailAddress(Properties.Settings.Default.EmailFrom, "Pizzeria");
            MailAddress ToEmail = new MailAddress(Properties.Settings.Default.EmailTo, "Drogi Kliencie!");
            MailMessage Message = new MailMessage()
            {
                From = FromEmail,
                Subject = "Zamówienie",
                Body = create_message_body(items, comment),
                IsBodyHtml = true,
            };
            Message.To.Add(ToEmail);

            Client.SendCompleted += form.Client_SendCompleted;
            Client.SendMailAsync(Message);
        }

        static private string create_message_body(ListBox.ObjectCollection items, string comment)
        {
            string message_body = "<h2>Witam,</h2> <h3>Zamówienie:</h3>";
            int order_price = 0;

            foreach (Dish dish in items)
            {
                message_body += dish.name + " " + dish.extras + " - " + Convert.ToString(dish.Quantity) + "szt - " + dish.total_price + "zł <br />";
                order_price += Convert.ToInt32(dish.total_price);
            }
            message_body += "<br />";
            message_body += "<h3>" + "Koszt zamówienia: " + Convert.ToString(order_price) + "zł </h3>";
            if (comment.Count() > 0)
            {
                message_body += "<h3>Uwagi do zamówienia:</h3>" + comment + "<br />";
            }
            message_body += "<h2>Dziękujemy za zamówienie</h2>";

            return message_body;
        }

    }
}
