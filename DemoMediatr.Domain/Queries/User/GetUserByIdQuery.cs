using DemoMediatr.Domain.ViewModels.User;
using MediatR;
using System;
using System.ComponentModel.DataAnnotations;

namespace DemoMediatr.Domain.Queries.User
{
    public class GetUserByIdQuery : IRequest<GetUserByIdViewModel>
    {
        [Required]
        public Guid Id { get; set; }
    }
}