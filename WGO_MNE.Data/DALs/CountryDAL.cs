using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WGO_MNE.Logic.DTOs;
using WGO_MNE.Logic.Interfaces;

namespace WGO_MNE.Data.DALs
{
    public class CountryDAL : ICountryDAL
    {
        private Connection _connection;

        public CountryDAL()
        {
            _connection = new Connection();
        }

        public bool Insert(CountryDTO newCountry)
        {
            bool success = true;

            try
            {
                string sql = "INSERT INTO wgo_mne.countries (Name, Icon) VALUES(@NAME, @ICON);";
                MySqlCommand cmd = new MySqlCommand(sql, _connection.sqlConn);

                cmd.Parameters.AddWithValue("@NAME", newCountry.Name);
                cmd.Parameters.AddWithValue("@ICON", newCountry.Icon);

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

        public List<CountryDTO> GetAll()
        {
            List<CountryDTO> countries = new List<CountryDTO>();

            try
            {
                string sql = "SELECT Id, Name, Icon FROM wgo_mne.countries";
                MySqlCommand cmd = new MySqlCommand(@sql, _connection.sqlConn);

                _connection.Open();

                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    countries.Add(new CountryDTO(Convert.ToInt32(dr[0]), dr[1].ToString(), (byte[])dr[2]));
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                _connection.Close();
            }

            return countries;
        }

        public CountryDTO GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(CountryDTO updatedCountry)
        {
            throw new NotImplementedException();
        }

        public bool Delete(CountryDTO countryToDelete)
        {
            throw new NotImplementedException();
        }
    }
}
