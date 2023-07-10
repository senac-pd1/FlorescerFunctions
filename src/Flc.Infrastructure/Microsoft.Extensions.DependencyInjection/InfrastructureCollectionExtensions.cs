using Azure.Data.Tables;
using Flc.Infrastructure.Adapters;
using Flc.Infrastructure.MailAccount;
using Microsoft.Extensions.Configuration;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.Extensions.DependencyInjection;

public static class InfrastructureCollectionExtensions
{
    [ExcludeFromCodeCoverage]
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        if (services == null)
        {
            throw new ArgumentNullException(nameof(services));
        }

        if (configuration == null)
        {
            throw new ArgumentNullException(nameof(configuration));
        }

        services.AddSingleton(configuration);

        var tableStorageConnectionString = configuration["AzureWebJobsStorage"];        

        services.AddScoped(s => new TableServiceClient(tableStorageConnectionString));

        services.AddScoped<ISendMail, SendMailRepository>();

        return services;
    }
}
