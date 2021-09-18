using DemoMediatr.Domain.ViewModels.User;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace DemoMediatr.Domain.Queries.User
{
    public class GetUserByUsernameQuery : IRequest<GetUserByUsernameViewModel>
    {
        [Required]
        public string Username { get; set; }
    }
}