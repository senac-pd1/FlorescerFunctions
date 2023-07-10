using Flc.Functions.Extensions;
using Flc.Infrastructure.MailAccount;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: FunctionsStartup(typeof(Flc.Functions.Startup))]

namespace Flc.Functions
{
    public class Startup : FunctionsStartup
    {
        //public override void ConfigureAppConfiguration(IFunctionsConfigurationBuilder builder)
        //{
        //    var configuration = builder.ConfigureAppSettings();
        //}

        public override void Configure(IFunctionsHostBuilder builder)
        {
            var configuration = builder.GetContext().Configuration;

            builder.Services
                .AddSingleton(configuration.SafeGet<EmailConfiguration>())
                .AddInfrastructure(configuration);
        }
    }
}
