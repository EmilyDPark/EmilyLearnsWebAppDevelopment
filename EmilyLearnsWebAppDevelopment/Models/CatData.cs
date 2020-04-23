using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmilyLearnsWebAppDevelopment.Models
{
    public class CatData
    {
        public int Year { get; }
        public int Age { get; }
        public string Color { get; }
        public string FavoriteToy { get; }

        public CatData(int year, int age, string color, string favoriteToy)
        {
            Year = year;
            Age = age;
            Color = color;
            FavoriteToy = favoriteToy;
        }
    }
}
