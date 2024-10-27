using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace FutureMeApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string message = txtMessage.Text;
            DateTime deliveryDate = GetSelectedDate();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(message))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            SaveMessage(email, message, deliveryDate);

            MessageBox.Show("Your letter has been scheduled for delivery.");
        }

        private DateTime GetSelectedDate()
        {
            switch (cmbDeliveryTime.SelectedIndex)
            {
                case 0: return DateTime.Now.AddMonths(6);
                case 1: return DateTime.Now.AddYears(1);
                case 2: return DateTime.Now.AddYears(3);
                case 3: return DateTime.Now.AddYears(5);
                case 4: return DateTime.Now.AddYears(10);
                default: return DateTime.Now;
            }
        }

        private void SaveMessage(string email, string message, DateTime deliveryDate)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "scheduledMessages.json");

            FutureMessage futureMessage = new FutureMessage
            {
                Email = email,
                Message = message,
                DeliveryDate = deliveryDate
            };

            List<FutureMessage> messages = new List<FutureMessage>();
            if (File.Exists(filePath))
            {
                string existingData = File.ReadAllText(filePath);
                messages = JsonConvert.DeserializeObject<List<FutureMessage>>(existingData) ?? new List<FutureMessage>();
            }

            messages.Add(futureMessage);

            string jsonData = JsonConvert.SerializeObject(messages, Formatting.Indented);
            File.WriteAllText(filePath, jsonData);

            MessageBox.Show("Письмо и дата доставки успешно сохранены.");
        }

        private void SendEmail(string email, string message)
        {
            string smtpServer = "smtp.gmail.com";
            int smtpPort = 587;
            string smtpUser = "sadeval2011@gmail.com"; 
            string smtpPass = "password"; 

            try
            {
                using (SmtpClient client = new SmtpClient(smtpServer, smtpPort))
                {
                    client.Credentials = new NetworkCredential(smtpUser, smtpPass);
                    client.EnableSsl = true;

                    MailMessage mailMessage = new MailMessage();
                    mailMessage.From = new MailAddress(smtpUser);
                    mailMessage.To.Add(email);
                    mailMessage.Subject = "Letter to Future Me";
                    mailMessage.Body = message;

                    client.Send(mailMessage);
                    MessageBox.Show("Email sent successfully.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to send email: {ex.Message}");
            }
        }
    }

    public class FutureMessage
    {
        public string Email { get; set; }
        public string Message { get; set; }
        public DateTime DeliveryDate { get; set; }
    }
}
