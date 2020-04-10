using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmilyLearnsWebAppDevelopment.Models
{
    public class CityData : ICityData
    {
        public List<City> CityList { get; set; }

        public List<City> CityInitializeData()
        {
            CityList = new List<City>()
            {
                new City() { ID = 1, CityName = "London", ImageName = "london.jpg", Attribution = "Photo by Eva Dang on Unsplash", ImageMimeType = "image/jpeg" },
                new City() { ID = 2, CityName = "Sydney", ImageName = "sydney.jpg", Attribution = "Photo by Paul Carmona on Unsplash", ImageMimeType = "image/jpeg" },
                new City() { ID = 3, CityName = "Anchorage", ImageName = "anchorage.jpg", Attribution = "Photo by Will Swann on Unsplash", ImageMimeType = "image/jpeg" },
                new City() { ID = 4, CityName = "Rome", ImageName = "rome.jpg", Attribution = "Photo by Mathew Schwartz on Unsplash", ImageMimeType = "image/jpeg" },
                new City() { ID = 5, CityName = "Tokyo", ImageName = "tokyo.jpg", Attribution = "Photo by Jezael Melgoza on Unsplash", ImageMimeType = "image/jpeg" }
            };
            return CityList;
        }

        public City GetCityById(int? id)
        {
            if (id == null)
            {
                return null;
            }
            else
            {
                return CityList.SingleOrDefault(a => a.ID == id);
            }
        }
    }
}
