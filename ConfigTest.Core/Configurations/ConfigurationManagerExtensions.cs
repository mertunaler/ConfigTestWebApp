using Microsoft.Extensions.Configuration;

namespace ConfigTest.Infrastructure.Configurations
{
    public static class ConfigurationManagerExtensions
    {
        public static IConfigurationBuilder AddSecretsToConfigs(
            this IConfigurationBuilder manager,
            string secretName,
            bool env)
        {
            if (!env)
            {

                IConfigurationBuilder configBuilder = manager;
                configBuilder.Add(new SecretManagerConfigSource(secretName));
            }
            return manager;
        }
    }
}
