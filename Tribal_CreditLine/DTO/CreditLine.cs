using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Tribal_CreditLine.DTO
{
    public class CreditLine
    {
        public string FoundingType { get; set; }
        public decimal CashBalance { get; set; }
        public decimal MonthlyRevenue { get; set; }
        public decimal RequestedCreditLine { get; set; }
        public DateTime RequestedDate { get; set; }
        [DefaultValue(false)]
        public DateTime? LastRequestedDate { get; set; }
        public string Response { get; set; }
    }
}
