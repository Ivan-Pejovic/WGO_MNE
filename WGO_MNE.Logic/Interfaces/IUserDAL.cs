using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WGO_MNE.Logic.Models;

namespace WGO_MNE.Logic.Interfaces
{
    public interface IUserDAL
    {
        public bool Insert(User newUser);
        public List<User> GetAll();
        public User GetById(int id);
        public bool Update(User updatedUser);
        public bool Delete(User userToDelete);
        public User Login(string username, string password);
    }
}
