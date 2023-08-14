using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WGO_MNE.Logic.Models;

namespace WGO_MNE.Logic.DTOs
{
    public class UserDTO
    {
        public int Id { private set; get; }
        public string FirstName { private set; get; }
        public string LastName { private set; get; }
        public string Username { private set; get; }
        public string Biography { private set; get; }
        public DateOnly DateOfBirth { private set; get; }
        public string Email { private set; get; }
        public string Password { private set; get; }
        public int CountryId { private set; get; }
        public byte[] ProfilePicture { private set; get; }
        
        public UserDTO(int id, string firstName, string lastName, string username, string biography, DateOnly dateOfBirth, string email, string password, int countryId, byte[] profilePicture)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Username = username;
            Biography = biography;
            DateOfBirth = dateOfBirth;
            Email = email;
            Password = password;
            CountryId = countryId;
            ProfilePicture = profilePicture;
        }

        public UserDTO(string firstName, string lastName, string username, string biography, DateOnly dateOfBirth, string email, string password, int countryId, byte[] profilePicture)
        {
            FirstName = firstName;
            LastName = lastName;
            Username = username;
            Biography = biography;
            DateOfBirth = dateOfBirth;
            Email = email;
            Password = password;
            CountryId = countryId;
            ProfilePicture = profilePicture;
        }
    }
}
