using ConfigTest.Infrastructure.Configurations;
using Microsoft.Extensions.Configuration;

namespace ConfigTest.Infrastructure.Configurations
{
    public class SecretManagerConfigSource : IConfigurationSource
    {
        private readonly string _secretName;
        public SecretManagerConfigSource( string secretName)
        {
            _secretName = secretName;
        }
        public IConfigurationProvider Build(IConfigurationBuilder builder)
        {
            return new SecretManagerConfigProvider(_secretName);
        }
    }
}
