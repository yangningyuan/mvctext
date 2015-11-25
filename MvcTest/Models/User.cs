using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcTest.Models
{
    public class User
    {
        public int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
    }
}