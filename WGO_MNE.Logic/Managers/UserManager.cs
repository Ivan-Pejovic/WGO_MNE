using WGO_MNE.Logic.DTOs;
using WGO_MNE.Logic.Exceptions;
using WGO_MNE.Logic.Interfaces;
using WGO_MNE.Logic.Mappers;
using WGO_MNE.Logic.Models;
using Bcrypt = BCrypt.Net.BCrypt;

namespace WGO_MNE.Logic.Managers
{
    public class UserManager
    {
        private IUserDAL iUserDAL;
        private ICountryDAL iCountryDAL;

        public UserManager(IUserDAL userDal, ICountryDAL countryDAL)
        {
            iUserDAL = userDal;
            iCountryDAL = countryDAL;
        }

        public bool Insert(User newUser)
        {
            if (iUserDAL.CheckIfEmailExists(newUser.Email))
            {
                throw new EmailAlreadyExistsException("Email already in use. Please log in.");
            }

            if (iUserDAL.CheckIfUsernameExists(newUser.Username))
            {
                throw new UsernameAlreadyExistsException("Username already exists. Please use another one.");
            }

            return iUserDAL.Insert(UserMapper.ToDTO(newUser));
        }

        public List<User> GetAll()
        {
            List<UserDTO> usersInDb = iUserDAL.GetAll();
            List<CountryDTO> countriesInDb = iCountryDAL.GetAll();

            List<Country> countries = new List<Country>();
            List<User> users = new List<User>();

            foreach(CountryDTO country in countriesInDb)
            {
                countries.Add(CountryMapper.ToModel(country));
            }

            foreach (UserDTO user in usersInDb)
            {
                users.Add(UserMapper.ToModel(user, countries));
            }

            return users;
        }

        public User GetById(int id)
        {
            return iUserDAL.GetById(id);
        }

        public bool Update(User updatedUser)
        {
            return iUserDAL.Update(updatedUser);
        }

        public bool Delete(User userToDelete)
        {
            return iUserDAL.Delete(userToDelete);
        }

        public User Login(string username, string password)
        {
            return iUserDAL.Login(username, password);
        }
    }
}
