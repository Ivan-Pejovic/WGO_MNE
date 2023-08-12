using MySql.Data.MySqlClient;
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
            bool success = true;

            try
            {
                string sql = "INSERT INTO wgo_mne.users (FirstName, LastName, Username, Biography, DateOfBirth, Email, Password, CountryId, ProfilePicture) VALUES(@FIRSTNAME, @LASTNAME, @USERNAME, @BIOGRAPHY, @DATEOFBIRTH, @EMAIL, @PASSWORD, @COUNTRYID, @PROFILEPICTURE);";
                MySqlCommand cmd = new MySqlCommand(sql, _connection.sqlConn);

                cmd.Parameters.AddWithValue("@FIRSTNAME", newUser.FirstName);
                cmd.Parameters.AddWithValue("@LASTNAME", newUser.LastName);
                cmd.Parameters.AddWithValue("@USERNAME", newUser.Username);
                cmd.Parameters.AddWithValue("@BIOGRAPHY", newUser.Biography);
                cmd.Parameters.AddWithValue("@DATEOFBIRTH", newUser.DateOfBirth);
                cmd.Parameters.AddWithValue("@EMAIL", newUser.Email);
                cmd.Parameters.AddWithValue("@PASSWORD", newUser.Password);
                cmd.Parameters.AddWithValue("@COUNTRYID", newUser.Country.Id);
                cmd.Parameters.AddWithValue("@PROFILEPICTURE", newUser.ProfilePicture);

                _connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                success = false;
            }
            finally
            {
                _connection.Close();
            }

            return success;
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
