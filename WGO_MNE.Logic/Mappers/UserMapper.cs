using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WGO_MNE.Logic.DTOs;
using WGO_MNE.Logic.Models;

namespace WGO_MNE.Logic.Mappers
{
    public static class UserMapper
    {
        public static User ToModel(UserDTO dto, List<Country> countries)
        {
            return new User(dto.Id, dto.FirstName, dto.LastName, dto.Username, dto.Biography, dto.DateOfBirth, dto.Email, dto.Password, countries.Where(c => c.Id == dto.CountryId), dto.ProfilePicture);
        }

        public static UserDTO ToDTO(User user)
        {
            return new UserDTO(user.Id, user.FirstName, user.LastName, user.Username, user.Biography, user.DateOfBirth, user.Email, user.Password, user.Country.Id, user.ProfilePicture);
        }
    }
}
