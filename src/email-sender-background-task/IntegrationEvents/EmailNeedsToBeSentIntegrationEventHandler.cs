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

    public class EmailNeedsToBeSentIntegrationEventHandler
        : IIntegrationEventHandler<EmailNeedsToBeSentIntegrationEvent>
    {
        private IEmailMessageSender emailMessageSender;

        public EmailNeedsToBeSentIntegrationEventHandler(IEmailMessageSender emailMessageSender)
        {
            this.emailMessageSender = emailMessageSender;
        }

        public async Task Handle(EmailNeedsToBeSentIntegrationEvent @event)
        {
            EmailSendingRequest emailSendingRequest = new EmailSendingRequest()
            {
                EmailMessage = new EmailMessage()
                {
                    Subject = @event.Subject,
                    Body = @event.Body
                },
                Recipient = new Recipient()
                {
                    Email = @event.To.First()
                },
                Sender = new Sender
                {
                    Email = @event.FromEmail,
                    FromName = @event.FromName,
                },
                MergeFields = @event.MergeFields,
                TemplateId = @event.TemplateId
            };

            await emailMessageSender.SendEmail(emailSendingRequest);
        }
    }
}
