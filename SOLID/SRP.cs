using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.SOLID
{
    internal class User
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }

    internal class UserActions
    {
        public void Login(User u)
        {
            Console.WriteLine($"Welcome {u.username}");
        }
        public void Logout(User u)
        {
            Console.WriteLine($"See you later {u.username}");
        }
    }

    internal class UserRepository
    {
        public UserRepository()
        {
            Users = new List<User>();
        }
        public List<User> Users;
        public void Add(User u)
        {
            Users.Add(u);
        }
    }
    internal class UserPresenter
    {
        public void WriteUserInfo(List<User> Users)
        {
            foreach (var user in Users)
            {
                Console.WriteLine($"{user.id}-{user.username}-{user.password}");
            }
        }
    }
}