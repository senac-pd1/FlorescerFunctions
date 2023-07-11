using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Flc.Functions.Constants;
using Flc.Infrastructure.Adapters;
using Flc.Infrastructure.MailAccount;
using Flc.Infrastructure.Models;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace Flc.Functions
{
    public class Scheduler
    {
        private readonly ISendMail _sendMail;

        public Scheduler(ISendMail sendMailRepository)
        {
            _sendMail = sendMailRepository;
        }

        [FunctionName("SchedulerProcess")]
        public async Task Run([TimerTrigger("0 6 * * 1-5")] TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"[INICIO] Processo de Notificação: {DateTime.Now}");
            await Notifica();
            log.LogInformation($"[FINAL] Processo de Notificação: {DateTime.Now}");
        }   
        
        public async Task Notifica()
        {
            var notificacao = new Notificacao();
            var destinatarios = new List<string>() { "rvmatos@gmail.com", "wagnersouzadepaula@gmail.com", "patriciawentzm@gmail.com", "felipemarmor@hotmail.com", "joorgenho@gmail.com" };            

            notificacao.Subject = "Florescer - Lembrete Semanal de Cuidados com o seu Jardim";
            notificacao.Body = EmailBody.header + EmailBody.template + EmailBody.footer;
            notificacao.To = destinatarios;

            await _sendMail.Send(notificacao);
        }
    }
}
