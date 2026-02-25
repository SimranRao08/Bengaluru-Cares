using System;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MimeKit;

namespace BlrCares
{
    public class EmailService
    {
        private string SenderEmail = AppSecrets.EmailAccount;
        private string SenderAppPassword = AppSecrets.EmailPassword;    

        public string GenerateOTP()
        {
            return new Random().Next(1000, 9999).ToString();
        }

        public async Task SendOtpAsync(string receiverEmail, string otp)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Bengaluru Cares", SenderEmail));
            message.To.Add(new MailboxAddress("Volunteer", receiverEmail));
            message.Subject = "Your Login OTP";

            message.Body = new TextPart("html")
            {
                Text = $"<h1>Welcome!</h1><p>Your OTP is: <b style='font-size:20px; color:teal;'>{otp}</b></p>"
            };

            using (var client = new SmtpClient())
            {
                // Connect to Gmail
                await client.ConnectAsync("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);

                // Authenticate
                await client.AuthenticateAsync(SenderEmail, SenderAppPassword);

                // Send
                await client.SendAsync(message);
                await client.DisconnectAsync(true);
            }
        }
    }
}