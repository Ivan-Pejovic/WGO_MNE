using WGO_MNE.Logic.Interfaces;
using WGO_MNE.Logic.Models;

namespace WGO_MNE.Data.DALs
{
    public class UserDAL : IUserDAL
    {
        private Connection _connection;

        public UserDAL()
        {
            _connection = new Connection();
        }

        public bool Insert(User newUser)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(User updatedUser)
        {
            throw new NotImplementedException();
        }

        public bool Delete(User userToDelete)
        {
            throw new NotImplementedException();
        }

        public User Login(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
