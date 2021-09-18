using DemoMediatr.Domain.Commands.User;
using DemoMediatr.Domain.Queries.User;
using DemoMediatr.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace DemoMediatr.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var query = new GetUserByIdQuery()
            {
                Id = id
            };

            var user = await _userService.GetUserByIdAsync(query);

            return Ok(user);
        }

        [HttpGet("{username}")]
        public async Task<IActionResult> GetByUsername(string username)
        {
            var query = new GetUserByUsernameQuery()
            {
                Username = username
            };

            var user = await _userService.GetUserByUsernameAsync(query);

            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] AddUserCommand command)
        {
            var result = await _userService.AddUserAsync(command);

            return result ? Ok() : BadRequest();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUser([FromBody] UpdateUserCommand command)
        {
            var result = await _userService.UpdateUserAsync(command);

            return result ? Ok() : BadRequest();
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeleteUser(Guid id)
        {
            var command = new DeleteUserCommand()
            {
                Id = id
            };

            var result = await _userService.DeleteUserAsync(command);

            return result ? Ok() : BadRequest();
        }
    }
}