using System.Threading.Tasks;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using MimeKit;

namespace PluralsightASP
{
    public class EmailService : IEmailSender
    {
        private readonly IConfiguration _configuration;

        public EmailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task SendEmailAsync(string email, string subject, string message)
        {
            var emailMessage = new MimeMessage();
 
            emailMessage.From.Add(new MailboxAddress("Администрация сайта", "mistaker"));
            emailMessage.To.Add(new MailboxAddress("", email));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = message
            };
             
            using (var client = new SmtpClient())
            {
                var smtpServerAddress = _configuration.GetSection("SmtpSettings")["smtpServerGmailAddress"];
                var smtpUsername = _configuration.GetSection("SmtpSettings")["smtpUsername"];
                var smtpPassword = _configuration.GetSection("SmtpSettings")["smtpPassword"];
                var smtpTlsPort = int.Parse( _configuration.GetSection("SmtpSettings")["smtpTlsPort"]);
                var smtpSslPort = int.Parse(_configuration.GetSection("SmtpSettings")["smtpSslPort"]);
                await client.ConnectAsync(smtpServerAddress,smtpSslPort,true);
                await client.AuthenticateAsync(smtpUsername, smtpPassword);
                await client.SendAsync(emailMessage);
 
                await client.DisconnectAsync(true);
            }
        }
    }
}