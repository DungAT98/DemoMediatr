using System;

namespace DemoMediatr.Domain.ViewModels.User
{
    public class GetUserByIdViewModel
    {
        public Guid Id { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }
    }
}