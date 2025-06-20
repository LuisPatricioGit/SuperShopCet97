﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using SuperShopCet97.Web.Data.Entities;
using SuperShopCet97.Web.Models;

namespace SuperShopCet97.Web.Data
{
    public interface ICountryRepository : IGenericRepository<Country>
    {
        IQueryable GetCountriesWithCities();

        Task<Country> GetCountryWithCitiesAsync(int id);

        Task<City> GetCityAsync(int id);

        Task AddCityAsync(CityViewModel model);

        Task<int> UpdateCityAsync(City city);

        Task<int> DeleteCityAsync(City city);

        IEnumerable<SelectListItem> GetComboCountries();

        IEnumerable<SelectListItem> GetComboCities(int countryId);

        Task<Country> GetCountryAsync(City city);
    }
}
