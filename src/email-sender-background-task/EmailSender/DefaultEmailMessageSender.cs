namespace Email.SmtpService.IntegrationEvents
{
    using LeadsPlus.BuildingBlocks.EventBus.Abstractions;
    using System;
    using System.Net;
    using System.Net.Mail;
    using System.Threading.Tasks;
    using System.Linq;
    using Microsoft.Extensions.Options;
    using Email.SmtpService;
    using Email.SmtpService.EmailSender;

    public class DefaultEmailMessageSender
        : IEmailMessageSender
    {
        private IOptions<Settings> settings;

        public DefaultEmailMessageSender(IOptions<Settings> settings)
        {
            this.settings = settings;
        }

        public async Task SendEmail(EmailSendingRequest emailSendingRequest)
        {
            //using (var client = new SmtpClient
            //{
            //    Port = settings.Value.Port,
            //    DeliveryMethod = SmtpDeliveryMethod.Network,
            //    EnableSsl = settings.Value.EnableSsl,
            //    Host = settings.Value.Host,
            //    UseDefaultCredentials = false,
            //    Credentials = new NetworkCredential(settings.Value.MailSenderUserName, settings.Value.MailAccountPassword)
            //})
            //{
            //    using (MailMessage mail = new MailMessage
            //    {
            //        IsBodyHtml = @event.IsBodyHtml,
            //        Subject = @event.Subject,
            //        Body = @event.Body
            //    })
            //    {
            //        mail.From = new MailAddress(settings.Value.MailSenderAddress, settings.Value.MailSenderName);

            //        mail.To.Add(new MailAddress(@event.To.First()));

            //        if (string.IsNullOrWhiteSpace(@event.ReplyTo) == false)
            //        {
            //            mail.ReplyToList.Add(@event.ReplyTo);
            //        }

            //        Console.WriteLine("Sending email to: {0} using {1}", @event.To.First(), settings.Value.MailSenderAddress);
            //        Console.WriteLine(@event.Body);

            //        await client.SendMailAsync(mail);
            //    }
            //}
        }
    }
}
