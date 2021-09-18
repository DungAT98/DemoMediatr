using DemoMediatr.Data.Data;
using DemoMediatr.Domain.Commands.User;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DemoMediatr.Domain.Handlers.User
{
    public class UpdateUserHandler : IRequestHandler<UpdateUserCommand, bool>
    {
        private readonly MockUserData _mockUserData;

        public UpdateUserHandler(MockUserData mockUserData)
        {
            _mockUserData = mockUserData;
        }

        public async Task<bool> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            if (request == null)
            {
                throw new Exception("Request not valid");
            }

            var oldEntity = _mockUserData.GetUser(n => n.Id == request.Id).FirstOrDefault();
            if (oldEntity == null)
            {
                throw new Exception("Id not found");
            }

            oldEntity.DisplayName = request.DisplayName;
            oldEntity.Email = request.Email;
            oldEntity.Username = request.Username;

            return true;
        }
    }
}