using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Anime
{
    public partial class SendMailForm : Form
    {
        public SendMailForm()
        {
            InitializeComponent();
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Sendbutton_Click(object sender, EventArgs e)
        {
            MailAddress fromMailAddress = new MailAddress(AdresstextBox.Text);
            
            if(AdresstextBox.Text == "")
            {
                MessageBox.Show("Введите электронную почту");
            }

            MailAddress toMailAddress = new MailAddress(AdresstextBox.Text);

            using (MailMessage message = new MailMessage(fromMailAddress, toMailAddress))

            using (SmtpClient smtpClient = new SmtpClient())
            {
                message.Subject = "Ваш список избранного";
                message.Body = "Здравствуйте. " + Environment.NewLine + "Мы прислали Вам список прислали";
                message.IsBodyHtml = true;

                File.WriteAllText("Избранное.csv", "Название");
                foreach(KeyValuePair<charactersstruct, int> mycharac in SelectForm.characters_list)
                {
                    charactersstruct chara = mycharac.Key;
                    File.AppendAllText("Избранное.csv",
                           Environment.NewLine +
                           chara.Name);
                }

                message.Attachments.Add(new Attachment("Избранное.csv"));
                
                smtpClient.Host = "smtp.mail.ru";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential(fromMailAddress.Address, "U6Wb4mJTkdFi3npqKG1C");
                smtpClient.Send(message);
            }
            MessageBox.Show("Письмо отправлено");
            Close();
        }
    }
}
