using System.Threading.Tasks;

namespace Email.SmtpService.EmailSender
{
    public interface IEmailMessageSender
    {
        Task SendEmail(EmailSendingRequest emailSendingRequest);
    }
} 

