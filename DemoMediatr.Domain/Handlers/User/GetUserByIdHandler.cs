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
    public class GetUserByIdHandler : IRequestHandler<GetUserByIdQuery, GetUserByIdViewModel>
    {
        private readonly MockUserData _mockUserData;

        public GetUserByIdHandler(MockUserData mockUserData)
        {
            _mockUserData = mockUserData;
        }

        public async Task<GetUserByIdViewModel> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            if (request == null)
            {
                throw new Exception("Request not valid");
            }

            var entity = _mockUserData.GetUser(n => n.Id == request.Id).FirstOrDefault();
            if (entity == null)
            {
                return null;
            }

            var userViewModel = new GetUserByIdViewModel()
            {
                Id = entity.Id,
                Email = entity.Email,
                Username = entity.Username
            };

            return userViewModel;
        }
    }
}