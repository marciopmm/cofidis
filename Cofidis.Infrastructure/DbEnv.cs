using Cofidis.Domain.Interfaces.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cofidis.Infrastructure
{
    public class DbEnv : IDbEnv
    {
        // Mock shall not be used. This class is only to have an instance of IDbEnv
        public void Mock()
        {
            throw new NotImplementedException();
        }
    }
}
