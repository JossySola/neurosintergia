using Resend;
using System.Text.Encodings.Web;

namespace neurosintergia.Services;

public class EmailSender(IResend resend)
{
    private readonly IResend _resend = resend;
    public async Task<ResendResponse> ExecuteConfirmation(string email, string link)
    {
        var encodedLink = HtmlEncoder.Default.Encode(link);
        var message = new EmailMessage
        {
            From = "contact@jossysola.com",
            Subject = "Neurosintergia: Confirma tu correo electrónico",
            HtmlBody = $"<p>Confirma tu correo electrónico dando clic en este enlace: <a href=\"{encodedLink}\">confirmar correo electrónico</a>.</p>",
            TextBody = $"Confirm your email by clicking this link: {link}"
        };
        message.To.Add($"{email}");
        return await _resend.EmailSendAsync(message);
    }
}
