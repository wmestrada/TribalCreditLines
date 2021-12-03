using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Tribal_CreditLine.Interfase;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tribal_CreditLine.Controllers
{
    [Route("api/creditline")]
    [ApiController]
    public class CreditLineController : ControllerBase
    {
        private readonly ICreditLineManager _creditLine;
        public CreditLineController(ICreditLineManager creditLine)
        {
            _creditLine = creditLine;
        }

        public ICreditLineManager CreditLine => _creditLine;

        // POST api/<CreditLineController>
        [HttpPost]
        public DTO.CreditLine ValidateCreditLine(DTO.CreditLine dto)
        {
            return _creditLine.GetCreditLine(dto);
        }
    }
}
