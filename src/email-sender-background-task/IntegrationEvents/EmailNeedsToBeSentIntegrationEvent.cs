namespace Email.SmtpService.IntegrationEvents
{
    using LeadsPlus.BuildingBlocks.EventBus.Events;
    using System.Collections.Generic;

    public class EmailNeedsToBeSentIntegrationEvent : IntegrationEvent
    {
        public string[] To { get; set; }
        public string[] Cc { get; set; }
        public string FromEmail { get; set; }
        public string FromName { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public bool IsBodyHtml { get; set; }
        public string ReplyTo { get; set; }
        public Dictionary<string, string> MergeFields { get; set; }
        public string TemplateId { get; set; }

        public EmailNeedsToBeSentIntegrationEvent()
        {

        }
    }
}

