using Cofidis.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cofidis.Domain.Interfaces.Business
{
    public interface IRiskAnalysis
    {
        bool GetOpinionForCredit(float unemployeeRate,
                                 float inflation,
                                 string token);
    }
}
