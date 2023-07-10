using System;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace Flc.Functions
{
    public class Scheduler
    {
        [FunctionName("SchedulerProcess")]
        public async Task Run([TimerTrigger("0 5 * * 1-5", RunOnStartup = true)] TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
        }
    }
}
