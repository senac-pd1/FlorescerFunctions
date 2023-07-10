using Flc.Infrastructure.Models;

namespace Flc.Infrastructure.Adapters
{
    public interface ISendMail
    {
        Task<Notificacao> Send(Notificacao notificacao);
    }
}
