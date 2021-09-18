using System;
using System.ComponentModel.DataAnnotations;
using MediatR;

namespace DemoMediatr.Domain.Commands.User
{
    public class UpdateUserCommand : IRequest<bool>
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string Username { get; set; }

        public string DisplayName { get; set; }

        public string Email { get; set; }
    }
}