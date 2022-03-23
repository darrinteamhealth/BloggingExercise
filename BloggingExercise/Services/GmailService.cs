using BloggingExercise.Interfaces;
using BloggingExercise.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace BloggingExercise.Services
{
    public class GmailService : IEmailService
    {
        private readonly IConfiguration _config;
        public GmailService(IConfiguration configuration)
        {
            _config = configuration;
        }

        public async Task SendEmailAsync(EmailMessage emailmessage)
        {
            try
            {
                using (MailMessage message = new MailMessage(
                    new MailAddress(_config["GmailSettings:Email"], _config["GmailSettings:DisplayName"]), 
                    new MailAddress(_config["GmailSettings:DefaultRecipient"])))
                {
                    message.Subject = emailmessage.Subject;
                    message.Body = emailmessage.Body;

                    using (SmtpClient client = new SmtpClient(
                        _config["GmailSettings:Host"], 
                        Convert.ToInt32(_config["GmailSettings:Port"])))
                    {
                        client.EnableSsl = true;
                        client.Credentials = new NetworkCredential(_config["GmailSettings:Email"], _config["GmailSettings:Password"]);
                        await client.SendMailAsync(message);
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
