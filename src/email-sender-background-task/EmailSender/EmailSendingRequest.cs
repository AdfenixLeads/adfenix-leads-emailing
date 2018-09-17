namespace Email.SmtpService.EmailSender
{
    using System.Collections.Generic;

    public class EmailSendingRequest
    {
        public long Id { get; set; }
        public Recipient Recipient { get; set; }
        public EmailMessage EmailMessage { get; set; }
        public Dictionary<string, string> MergeFields { get; set; }
        public Sender Sender { get; set; }
        public string TemplateId { get; set; }
    }
}

