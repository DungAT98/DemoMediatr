using System;
using System.Threading;
using System.Threading.Tasks;
using DemoMediatr.Data.Data;
using DemoMediatr.Domain.Commands.User;
using MediatR;

namespace DemoMediatr.Domain.Handlers.User
{
    public class DeleteUserHandler : IRequestHandler<DeleteUserCommand, bool>
    {
        private readonly MockUserData _mockUserData;

        public DeleteUserHandler(MockUserData mockUserData)
        {
            _mockUserData = mockUserData;
        }

        public async Task<bool> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            if (request == null)
            {
                throw new Exception("Request not valid");
            }

            _mockUserData.Delete(n => n.Id == request.Id);

            return true;
        }
    }
}