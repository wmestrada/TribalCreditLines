using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tribal_CreditLine.Interfase
{
    public interface ICreditLineManager
    {
        public DTO.CreditLine GetCreditLine(DTO.CreditLine creditLine);
    }
}
