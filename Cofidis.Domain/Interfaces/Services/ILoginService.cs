using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cofidis.Domain.Interfaces.Services
{
    public interface ILoginService
    {
        string Login(string nif);
        bool CheckAuthentication(string token);
    }
}
