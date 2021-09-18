﻿using System;

namespace DemoMediatr.Data.Model
{
    public class UserModel
    {
        public Guid Id { get; set; }

        public string Username { get; set; }

        public string DisplayName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}