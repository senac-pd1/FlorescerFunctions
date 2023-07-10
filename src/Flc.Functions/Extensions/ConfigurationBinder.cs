using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flc.Functions.Extensions
{
    public static class ConfigurationBinder
    {
        public static T SafeGet<T>(this IConfiguration configuration)
        {
            string typeName = typeof(T).Name;
            if (configuration.GetChildren().Any((IConfigurationSection item) => item.Key == typeName))
            {
                configuration = configuration.GetSection(typeName);
            }

            return configuration.Get<T>() ?? throw new InvalidOperationException("The configuration '" + typeof(T).FullName + "' item doesn't exist.");
        }
    }
}
