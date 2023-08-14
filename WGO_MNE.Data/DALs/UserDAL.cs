using MySql.Data.MySqlClient;
using WGO_MNE.Logic.Interfaces;
using WGO_MNE.Logic.DTOs;

namespace WGO_MNE.Data.DALs
{
    public class UserDAL : IUserDAL
    {
        private Connection _connection;

        public UserDAL()
        {
            _connection = new Connection();
        }

        public bool Insert(UserDTO newUser)
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
                cmd.Parameters.AddWithValue("@COUNTRYID", newUser.CountryId);
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

        public List<UserDTO> GetAll()
        {
            List<UserDTO> users = new List<UserDTO>();

            try
            {
                string sql = "SELECT Id, FirstName, LastName, Username, Biography, DateOfBirth, Email, Password, CountryId, ProfilePicture FROM wgo_mne.users";
                MySqlCommand cmd = new MySqlCommand(@sql, _connection.sqlConn);

                _connection.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    users.Add(new UserDTO(Convert.ToInt32(dr[0]), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), DateOnly.FromDateTime(Convert.ToDateTime(dr[5].ToString())), dr[6].ToString(), dr[7].ToString(), Convert.ToInt32(dr[8]), (byte[])dr[9]));
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                _connection.Close();
            }

            return users;
        }

        public UserDTO GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(UserDTO updatedUser)
        {
            throw new NotImplementedException();
        }

        public bool Delete(UserDTO userToDelete)
        {
            throw new NotImplementedException();
        }

        public UserDTO Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public bool CheckIfEmailExists(string email)
        {
            throw new NotImplementedException();
        }

        public bool CheckIfUsernameExists(string username)
        {
            throw new NotImplementedException();
        }
    }
}
