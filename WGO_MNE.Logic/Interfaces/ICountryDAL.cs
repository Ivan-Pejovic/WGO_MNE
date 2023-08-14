using WGO_MNE.Logic.DTOs;

namespace WGO_MNE.Logic.Interfaces
{
    public interface ICountryDAL
    {
        public bool Insert(CountryDTO newCountry);
        public List<CountryDTO> GetAll();
        public CountryDTO GetById(int id);
        public bool Update(CountryDTO updatedCountry);
        public bool Delete(CountryDTO countryToDelete);
    }
}
