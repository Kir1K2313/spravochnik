using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Anime
{
    public partial class FeedbackForm : Form
    {
        public FeedbackForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailAddress fromMailAddress = new MailAddress("bleachspravochnik@mail.ru");

            MailAddress toMailAddress = new MailAddress("bleachspravochnik@mail.ru");

           using (MailMessage message = new MailMessage(fromMailAddress, toMailAddress))

           using (SmtpClient smtpClient = new SmtpClient())
            {
                message.Subject = comboBox1.Text;
                message.Body = textBox1.Text;
                message.IsBodyHtml = true;

                smtpClient.Host = "smtp.mail.ru";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(fromMailAddress.Address, "U6Wb4mJTkdFi3npqKG1C");
                smtpClient.Send(message);
            }
        }
    }
}
