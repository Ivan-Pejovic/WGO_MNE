using WGO_MNE.Logic.DTOs;

namespace WGO_MNE.Logic.Interfaces
{
    public interface IUserDAL
    {
        public bool Insert(UserDTO newUser);
        public List<UserDTO> GetAll();
        public UserDTO GetById(int id);
        public bool Update(UserDTO updatedUser);
        public bool Delete(UserDTO userToDelete);
        public UserDTO Login(string username, string password);
        public bool CheckIfEmailExists(string email);
        public bool CheckIfUsernameExists(string username);
    }
}
