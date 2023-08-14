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

        public UserManager(IUserDAL dal)
        {
            iUserDAL = dal;
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
            return iUserDAL.GetAll();
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
