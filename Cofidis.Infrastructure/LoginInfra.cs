using Cofidis.Domain.Interfaces.Database;
using Cofidis.Domain.Interfaces.Infrasctructure;

namespace Cofidis.Infrastructure
{
    public class LoginInfra : ILoginInfra
    {
        private const string TOKEN = "THISISAMOCKTOKEN123456";
        private readonly IDbEnv _dbEnv;

        public LoginInfra(IDbEnv dbEnv)
        {
            _dbEnv = dbEnv;
        }

        public string Login(string nif)
        {
            return TOKEN;
        }

        public bool CheckAuthentication(string token)
        {
            return token == TOKEN;
        }
    }
}
