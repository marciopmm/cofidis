using Cofidis.Domain.Interfaces.Business;
using Cofidis.Domain.Interfaces.Infrasctructure;

namespace Cofidis.Domain.Business
{
    public class RiskAnalysis : IRiskAnalysis
    {
        private readonly ILoginInfra _loginInfra;
        private readonly IDigitalMobileKey _digitalMobileKey;

        public RiskAnalysis(ILoginInfra loginInfra,
                            IDigitalMobileKey digitalMobileKey)
        {
            _loginInfra = loginInfra;
            _digitalMobileKey = digitalMobileKey;
        }

        public bool GetOpinionForCredit(float unemploymentRate, 
                                        float inflation,
                                        string token)
        {
            if (!_loginInfra.CheckAuthentication(token))
                throw new KeyNotFoundException();
            
            var user = _digitalMobileKey.GetDigitalMobileKey(token);
            if (user.CreditHistory == null)
                throw new NullReferenceException("creditHistory was not supposed to be null");

            if (user.CreditHistory.Sum(x => x.OwnedValue) > 0m)
                return false;

            var avg = (user.CreditHistory.Count(x => x.Settled) + user.CreditHistory.Count(x => !x.Settled)) / 2;

            if (unemploymentRate > 30.0f || inflation > 15.0f)
            {
                if (avg > .7f)
                {
                    return true;
                }
            }
            else if (avg > .5f)
            {
                return true;
            }
            
            return false;
        }
    }
}
