using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace Email.SmtpService.EmailSender
{
    public class SendGridSettings : ISendGridSettings
    {
        public SendGridSettings(IConfiguration configuration, IOptions<Settings> settings)
        {
            this.ApiKey = configuration.GetValue<string>("SendgridApiKey");
        }

        public string ApiKey { get; protected set; }
        public string ServerId { get; private set; }
    }
}

