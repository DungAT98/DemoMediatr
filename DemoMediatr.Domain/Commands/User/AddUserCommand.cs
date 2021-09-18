using MediatR;
using System.ComponentModel.DataAnnotations;

namespace DemoMediatr.Domain.Commands.User
{
    public class AddUserCommand : IRequest<bool>
    {
        [Required]
        public string Username { get; set; }

        public string DisplayName { get; set; }

        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}