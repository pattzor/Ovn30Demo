using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlLibrary
{
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }

        // A user should never be created without username/password etc
        private User()
        {

        }

        public User(int id, string username, string password, string role, string email)
        {
            ID = id;
            Username = username;
            Password = password;
            Role = role;
            Email = email;
        }
    }
}
