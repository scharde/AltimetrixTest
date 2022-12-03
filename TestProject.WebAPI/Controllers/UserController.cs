using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TestProject.Data.Model;
using TestProject.Service.User;

namespace TestProject.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<UserModel> users = await _userService.List();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            UserModel user = await _userService.GetUser(id);
            
            return user == null ? NotFound("User not found") : Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] UserFormModel model)
        {
            var result = await _userService.Create(model);
            return Ok(result);
        }
    }
}
