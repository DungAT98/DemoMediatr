using MediatR;
using System;
using System.ComponentModel.DataAnnotations;

namespace DemoMediatr.Domain.Commands.User
{
    public class DeleteUserCommand : IRequest<bool>
    {
        [Required]
        public Guid Id { get; set; }
    }
}