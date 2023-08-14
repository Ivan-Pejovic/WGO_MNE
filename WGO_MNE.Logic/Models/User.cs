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
        public DateOnly DateOfBirth { private set; get; }
        public string Email { private set; get; }
        public string Password { private set; get; }
        public Country Country { private set; get; }
        public byte[] ProfilePicture { private set; get; }
        
        public User(int id, string firstName, string lastName, string username, string biography, DateOnly dateOfBirth, string email, string password, Country country, byte[] profilePicture)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Username = username;
            Biography = biography;
            DateOfBirth = dateOfBirth;
            Email = email;
            Password = password;
            Country = country;
            ProfilePicture = profilePicture;
        }

        public User(string firstName, string lastName, string username, string biography, DateOnly dateOfBirth, string email, string password, Country country, byte[] profilePicture)
        {
            FirstName = firstName;
            LastName = lastName;
            Username = username;
            Biography = biography;
            DateOfBirth = dateOfBirth;
            Email = email;
            Password = password;
            Country = country;
            ProfilePicture = profilePicture;
        }
    }
}
