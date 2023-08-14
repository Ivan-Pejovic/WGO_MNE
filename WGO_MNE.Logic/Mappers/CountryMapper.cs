using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WGO_MNE.Logic.DTOs;
using WGO_MNE.Logic.Models;

namespace WGO_MNE.Logic.Mappers
{
    public static class CountryMapper
    {
        public static Country ToModel(CountryDTO dto)
        {
            return new Country(dto.Id, dto.Name, dto.Icon);
        }

        public static CountryDTO ToDTO(Country country)
        {
            return new CountryDTO(country.Id, country.Name, country.Icon);
        }
    }
}
