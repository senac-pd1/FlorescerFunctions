using Flc.Infrastructure.Adapters;
using Flc.Infrastructure.Models;
using Microsoft.Extensions.Logging;
using System.Globalization;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;

namespace Flc.Infrastructure.MailAccount
{
    public class SendMailRepository : ISendMail
    {
        private readonly EmailConfiguration _emailConfiguration;
        private readonly ILogger<SendMailRepository> _logger;

        public SendMailRepository(EmailConfiguration emailConfiguration, ILogger<SendMailRepository> logger)
        {
            _emailConfiguration = emailConfiguration;
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<Notificacao> Send(Notificacao notificacao)
        {
            if (!_emailConfiguration.EnabledSendMails)
            {
                _logger.LogInformation("Envio de email desativado.");

                return notificacao;
            }

            try
            {
                using var mail = new MailMessage();               

                mail.From = new MailAddress(_emailConfiguration.From, _emailConfiguration.FromName);
                mail.Subject = notificacao.Subject;
                mail.Body = notificacao.Body;
                mail.IsBodyHtml = _emailConfiguration.IsEmailBodyHtml;

                

                SetRecipients(mail, notificacao);

                using var smtp = new SmtpClient(_emailConfiguration.HostAddress, 587);
                smtp.UseDefaultCredentials = false;
                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential(_emailConfiguration.AccountSender, _emailConfiguration.Password);
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                await smtp.SendMailAsync(mail);

                notificacao.AddResult("Sucesso: Email Enviado");
            }
            catch(Exception ex)
            {
                _logger.LogError($"Erro ao enviar email: {ex.Message}");
                notificacao.AddResult($"Error sending the email: {ex.Message}");
            }            

            return notificacao;
        }

        private void SetRecipients(MailMessage mail, Notificacao notificacao)
        {
            if (_emailConfiguration.Overwrite.Enabled)
            {
                var overwriteMailConfiguration = _emailConfiguration.Overwrite;

                _logger.LogWarning("The email settings To and CC was overwritten.");

                foreach (var mailTo in overwriteMailConfiguration.To)
                    mail.To.Add(mailTo);

                foreach (var mailCc in overwriteMailConfiguration.CC)
                    mail.CC.Add(mailCc);

                notificacao.Cc = overwriteMailConfiguration.CC;
                notificacao.To = overwriteMailConfiguration.To;
            }
            else
            {
                foreach (var mailTo in notificacao.To)
                    mail.To.Add(mailTo);

                if (notificacao.Cc != null && notificacao.Cc.Any())
                {
                    foreach (var mailCc in notificacao.Cc)
                        mail.CC.Add(mailCc);
                }
            }

            if(!string.IsNullOrWhiteSpace(_emailConfiguration.SubjectComplement))
            {
                mail.Subject = $"{mail.Subject} - {_emailConfiguration.SubjectComplement}";
            }

            foreach (var ccFollower in _emailConfiguration.CCFollowers)
                mail.CC.Add(ccFollower);
        }
    }
}
