namespace Email.SmtpService
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class Settings
    {
        public bool EnableSsl { get; set; }
        public string Host { get; set; }
        public string MailAccountPassword { get; set; }
        public string MailSenderAddress { get; set; }
        public string MailSenderName { get; set; }
        public string MailSenderUserName { get; set; }
        public int Port { get; set; }
    }
}
