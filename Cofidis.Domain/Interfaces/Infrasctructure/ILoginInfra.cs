using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cofidis.Domain.Interfaces.Infrasctructure
{
    public interface ILoginInfra
    {
        string Login(string nif);
        bool CheckAuthentication(string token);
    }
}
