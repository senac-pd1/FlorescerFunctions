using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flc.Infrastructure.Models
{
    public class Notificacao
    {
        public IEnumerable<string> To { get; set; } = default!;

        public IEnumerable<string> Cc { get; set; } = default!;

        public string Subject { get; set; } = default!;

        public string Body { get; set; } = default!;

        public string? Result { get; private set; }

        public void AddResult(string message)
        {
            Result = message;
        }

    }
}
