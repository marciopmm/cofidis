using Cofidis.Domain.Entities;
using Cofidis.Domain.Interfaces.Database;

namespace Cofidis.Domain.Interfaces.Infrasctructure
{
    public interface IDigitalMobileKey
    {
        UserData GetDigitalMobileKey(string token);
    }
}
