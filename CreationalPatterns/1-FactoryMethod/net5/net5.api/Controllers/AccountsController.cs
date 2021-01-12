using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using net5.api.Creators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net5.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        [HttpPost]
        [Route("saving")]
        public async Task<IActionResult> CreateSavingAccount() {
            return Created(string.Empty, new SavingAccountCreator().Create());
        }

        [HttpPost]
        [Route("checking")]
        public async Task<IActionResult> CreateCheckingAccount()
        {
            return Created(string.Empty, new CheckingAccountCreator().Create());
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetAccount()
        {
            return Ok();
        }
    }
}
