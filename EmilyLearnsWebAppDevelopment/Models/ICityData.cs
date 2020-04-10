using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmilyLearnsWebAppDevelopment.Models
{
    public interface ICityData
    {
        List<City> CityList { get; set; }
        List<City> CityInitializeData();
        City GetCityById(int? id);
    }
}
