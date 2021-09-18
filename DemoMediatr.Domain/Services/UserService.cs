using System.Threading.Tasks;
using DemoMediatr.Domain.Commands.User;
using DemoMediatr.Domain.Queries.User;
using DemoMediatr.Domain.ViewModels.User;
using MediatR;

namespace DemoMediatr.Domain.Services
{
    public class UserService
    {
        private readonly IMediator _mediator;

        public UserService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public Task<bool> AddUserAsync(AddUserCommand command)
        {
            return _mediator.Send(command);
        }

        public Task<bool> DeleteUserAsync(DeleteUserCommand command)
        {
            return _mediator.Send(command);
        }

        public Task<bool> UpdateUserAsync(UpdateUserCommand command)
        {
            return _mediator.Send(command);
        }

        public Task<GetUserByUsernameViewModel> GetUserByUsernameAsync(GetUserByUsernameQuery query)
        {
            return _mediator.Send(query);
        }

        public Task<GetUserByIdViewModel> GetUserByIdAsync(GetUserByIdQuery query)
        {
            return _mediator.Send(query);
        }
    }
}