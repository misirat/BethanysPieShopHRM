using BethanysPieShopHRM.Shared.Domain;

namespace BethanysPieShopHRM.Services
{
    public interface ICountryDataService
    {
        Task<IEnumerable<Country>> GetAllCountries();
        Task<Country> GetCountryById(int countryId); 
    }
}
