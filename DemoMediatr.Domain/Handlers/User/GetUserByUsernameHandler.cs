using DemoMediatr.Data.Data;
using DemoMediatr.Domain.Queries.User;
using DemoMediatr.Domain.ViewModels.User;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DemoMediatr.Domain.Handlers.User
{
    public class GetUserByUsernameHandler : IRequestHandler<GetUserByUsernameQuery, GetUserByUsernameViewModel>
    {
        private readonly MockUserData _mockUserData;

        public GetUserByUsernameHandler(MockUserData mockUserData)
        {
            _mockUserData = mockUserData;
        }

        public async Task<GetUserByUsernameViewModel> Handle(GetUserByUsernameQuery request, CancellationToken cancellationToken)
        {
            if (request == null)
            {
                throw new Exception("Request not valid");
            }

            var entity = _mockUserData.GetUser(n => n.Username.ToLower() == request.Username.Trim().ToLower()).FirstOrDefault();
            if (entity == null)
            {
                return null;
            }

            var userModel = new GetUserByUsernameViewModel()
            {
                Username = entity.Username,
                DisplayName = entity.DisplayName
            };

            return userModel;
        }
    }
}