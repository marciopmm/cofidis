using Cofidis.Domain.Interfaces.Database;
using Cofidis.Domain.Interfaces.Infrasctructure;
using Cofidis.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cofidis.Domain.Services
{
    public class LoginService : ILoginService
    {
        private readonly IDbEnv _dbEnv;
        private readonly ILoginInfra _loginInfra;

        public LoginService(ILoginInfra loginInfra, IDbEnv dbEnv)
        {
            _dbEnv = dbEnv;
            _loginInfra = loginInfra;
        }

        public string Login(string nif)
        {
            return _loginInfra.Login(nif) ?? string.Empty;
        }

        public bool CheckAuthentication(string token)
        {
            return _loginInfra.CheckAuthentication(token);
        }
    }
}
