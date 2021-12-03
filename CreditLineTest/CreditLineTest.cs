using Microsoft.AspNetCore.Mvc;
using System;
using Tribal_CreditLine.Controllers;
using Tribal_CreditLine.Interfase;
using Tribal_CreditLine.DTO;
using Xunit;

namespace CreditLineTest
{
    public class CreditLineTest
    {
        CreditLineController _controller;
        ICreditLineManager _creditLine;

        public CreditLineTest()
        {
            _creditLine = new Tribal_CreditLine.Managers.CreditLineManager();
            _controller = new CreditLineController(_creditLine);
        }

        [Fact]
        public void Test1()
        {
            //Arrange
            var dto = new CreditLine();

            dto.FoundingType = "SME";
            dto.CashBalance = (decimal)435.30;
            dto.MonthlyRevenue = (decimal)4235.45;
            dto.RequestedCreditLine = (decimal)100;
            dto.RequestedDate = Convert.ToDateTime("2021-07-19T16:32:59.860Z");

            //Act
            var result = _controller.ValidateCreditLine(dto);
            Assert.IsType<string>(result.Response);

            var creditLine = result.Response;

            //Assert
            Assert.IsType<string>(creditLine);
        }
    }
}
