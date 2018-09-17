using System.Collections.Generic;

namespace Email.SmtpService.EmailSender
{
    public class Sender
    {
        public int UserId { get; set; }
        public string Email { get; set; }

        public string FromName { get; set; }

        public Footer Footer { get; set; }

        public string FromLabel
        {
            get
            {
                var from = string.Format("{0}<{1}>", FromName, Email).Trim();
                return "<>" == from ? "" : from;
            }
        }
    }

    public class Footer
    {
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string FooterName { get; set; }
    }
}

