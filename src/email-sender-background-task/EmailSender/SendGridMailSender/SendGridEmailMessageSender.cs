namespace Email.SmtpService.EmailSender
{
    using Microsoft.Extensions.Configuration;
    using SendGrid;
    using SendGrid.Helpers.Mail;
    using System.Threading.Tasks;

    public class SendGridMessageSubmitter : IEmailMessageSender
    {        
        private readonly ISendGridSettings sendGridSettings;

        public SendGridMessageSubmitter(ISendGridSettings sendGridSettings)
        {
            this.sendGridSettings = sendGridSettings;
        }

        public async Task SendEmail(EmailSendingRequest emailSendingRequest)
        {
            var client = new SendGridClient(this.sendGridSettings.ApiKey);

            var from = new EmailAddress(emailSendingRequest.Sender.Email, emailSendingRequest.Sender.FromLabel);

            var subject = emailSendingRequest.EmailMessage.Subject;
            var to = new EmailAddress(emailSendingRequest.Recipient.Email, emailSendingRequest.Recipient.Email);

            var plainTextContent = "";
            var htmlContent = emailSendingRequest.EmailMessage.Body;

            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);

            var response = await client.SendEmailAsync(msg);
        }
    }
}

