using Resend;

namespace neurosintergia.Services;

public class EmailSender(IResend resend)
{
    private readonly IResend _resend = resend;
    public async Task Execute()
    {
        var message = new EmailMessage
        {
            From = "",
            Subject = "",
            HtmlBody = ""
        };
        message.To.Add("");
        await _resend.EmailSendAsync(message);
    }
}