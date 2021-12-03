using System;
using System.Threading;

namespace Tribal_CreditLine.Managers
{
    public class CreditLineManager : Interfase.ICreditLineManager
    {
        public DTO.CreditLine GetCreditLine(DTO.CreditLine dto)
        {
            this.Validations(dto);

            decimal balanceCreditLine = dto.CashBalance / 3;
            decimal monthlyCreditLine = dto.MonthlyRevenue / 5;
            decimal creditLineValue = 0;

            if (dto.FoundingType == "SME")
            {
                creditLineValue = monthlyCreditLine;
            }
            else if (dto.FoundingType == "Startup")
            {
                creditLineValue = Math.Max(balanceCreditLine, monthlyCreditLine);
            }

            if (creditLineValue > dto.RequestedCreditLine)
            {
                dto.Response = "The requested credit line has been authorizated.";
                return dto;
            }
            else
            {
                dto.LastRequestedDate = DateTime.Now;
                dto.Response = "The requested credit line has been rejected.";
                Thread.Sleep(30000);
                return dto;
            }
        }


        private void Validations(DTO.CreditLine dto)
        {
            if (dto.FoundingType != "Startup" && dto.FoundingType.ToUpper() != "SME")
                throw new Exception("The bussines type is not valid");

            if (dto.RequestedCreditLine <= 0)
                throw new Exception("Requested line of credit should greater than zero");
        }
    }
}
