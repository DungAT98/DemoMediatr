using DemoMediatr.Data.Data;
using DemoMediatr.Data.Model;
using DemoMediatr.Domain.Commands.User;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace DemoMediatr.Domain.Handlers.User
{
    public class AddUserHandler : IRequestHandler<AddUserCommand, bool>
    {
        private readonly MockUserData _mockUserData;

        public AddUserHandler(MockUserData mockUserData)
        {
            _mockUserData = mockUserData;
        }

        public async Task<bool> Handle(AddUserCommand request, CancellationToken cancellationToken)
        {
            if (request == null)
            {
                throw new Exception("Request not valid");
            }

            var entity = new UserModel()
            {
                Username = request.Username,
                DisplayName = request.DisplayName,
                Email = request.Email,
                Password = request.Password
            };

            _mockUserData.AddUser(entity);
            return true;
        }
    }
}