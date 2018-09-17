using System.Collections.Generic;

namespace Email.SmtpService.EmailSender
{
    public class EmailMessage
    {
        public EmailMessage()
        {
            
        }
        
        public string Body { get; set; }
        public string Subject { get; set; }
        public string UnsubscribeLink { get; set; }
    }
}

