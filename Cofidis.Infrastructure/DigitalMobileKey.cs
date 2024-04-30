using Cofidis.Domain.Entities;
using Cofidis.Domain.Interfaces.Database;
using Cofidis.Domain.Interfaces.Infrasctructure;

namespace Cofidis.Infrastructure
{
    public class DigitalMobileKey : IDigitalMobileKey
    {
        private readonly IDbEnv _dbEnv;

        public DigitalMobileKey(IDbEnv dbEnv)
        {
            _dbEnv = dbEnv;
        }

        public UserData GetDigitalMobileKey(string token)
        {
            // Mocked data - just for demo presentation
            return new UserData()
            {
                Name = "John Doe",
                Nif = "313535757",
                PhoneNumber = "999666333",
                MontlyIncome = 2500m,
                CreditHistory = new List<CreditOperation>
                {
                    new CreditOperation
                    {
                        Date = new DateTime(2016,03,08),
                        PastValue = 10000m,
                        PresentValue = 11000m,
                        OwnedValue = 0m,
                        Settled = true
                    },
                    new CreditOperation
                    {
                        Date = new DateTime(2018,07,23),
                        PastValue = 4000m,
                        PresentValue = 4500m,
                        OwnedValue = 0m,
                        Settled = true
                    },
                    new CreditOperation
                    {
                        Date = new DateTime(2023,05,06),
                        PastValue = 6000m,
                        PresentValue = 6800m,
                        OwnedValue = 0m,
                        Settled = false
                    }
                }
            };
        }
    }
}
