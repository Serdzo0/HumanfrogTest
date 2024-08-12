using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace HFT.Utility
{
	public class EmailSender : IEmailSender
	{
        private readonly ISendGridClient _sendGridClient;
        private readonly SendGridSettings _sendGridSettings;
        public EmailSender(ISendGridClient sendGridClient, IOptions<SendGridSettings> sendGridSettings)
        {
            _sendGridClient = sendGridClient;
            _sendGridSettings = sendGridSettings.Value;
        }
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var msg = new SendGridMessage()
            {
                From = new EmailAddress(_sendGridSettings.FromEmail, _sendGridSettings.EmailName),
                Subject = subject,
                HtmlContent = htmlMessage
            };
            msg.AddTo(email);
            await _sendGridClient.SendEmailAsync(msg);
        }
    }
}
