using DemoMediatr.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoMediatr.Data.Data
{
    public class MockUserData
    {
        public static List<UserModel> UserData = new List<UserModel>()
        {
            new UserModel()
            {
                Id = Guid.Empty,
                DisplayName = "Tiến Dũng",
                Email = "dungat98@gmail.com",
                Password = "123456",
                Username = "DungAT"
            }
        };

        public IEnumerable<UserModel> GetUser(Func<UserModel, bool> predicate)
        {
            return UserData.Where(predicate);
        }

        public void AddUser(UserModel entity)
        {
            UserData.Add(entity);
        }

        public void Delete(UserModel entity)
        {
            UserData.Remove(entity);
        }

        public void Delete(Func<UserModel, bool> predicate)
        {
            var deletedList = GetUser(predicate);
            foreach (var user in deletedList)
            {
                Delete(user);
            }
        }
    }
}