using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TestProject.Data.Model;
using TestProject.Service.Account;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {

        private readonly IAccountService _accountService;
        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        public async Task<IActionResult> List(int userId)
        {
            var result = await _accountService.List(userId);
            return result  != null ? Ok(result) : BadRequest("Error while getting list");
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AccountFormModel model)
        {
           var result = await _accountService.Create(model);

            return result != null ? Ok(result) : BadRequest("Error while creating account");
        }


    }
}
