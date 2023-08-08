using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WGO_MNE.Logic.Models
{
    public class User
    {
        public int Id { private set; get; }
        public string FirstName { private set; get; }
        public string LastName { private set; get; }
        public string Username { private set; get; }
        public string Biography { private set; get; }
        public string Email { private set; get; }
        public string Password { private set; get; }
        public Country Country { private set; get; }
        public string ProfilePicture { private set; get; }

    }
}
