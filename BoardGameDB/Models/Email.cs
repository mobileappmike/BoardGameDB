using System;
using System.Threading.Tasks;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace BoardGameDB.Models
{
    public class Email
    {
        private string apiKey = Environment.GetEnvironmentVariable("SENDGRID_APIKEY");

        public async Task SendWelcomeEmail(string address)
        {
            var client = new SendGridClient(apiKey);
            var msg = new SendGridMessage()
            {
                From = new EmailAddress("michael.gage.miles@gmail.com", "Michael Miles @ BoardGameDB"),
                Subject = "Thanks for registering!",
                PlainTextContent = "Hey, and thanks for registering with BoardGameDB!  We're happy to have you as part of our team."
            };
            msg.AddTo(new EmailAddress(address));
            var response = await client.SendEmailAsync(msg);
        }

        public async Task SendAddedEmail(string address, string gameName)
        {
            var client = new SendGridClient(apiKey);
            var msg = new SendGridMessage()
            {
                From = new EmailAddress("michael.gage.miles@gmail.com", "Michael Miles @ BoardGameDB"),
                Subject = "Thanks for your contribution!",
                PlainTextContent = $"We saw that you added {gameName} to our database yesterday.  Thanks!  Keep up the good work!"
            };
            msg.AddTo(new EmailAddress(address));
            var response = await client.SendEmailAsync(msg);
        }
    }
}
