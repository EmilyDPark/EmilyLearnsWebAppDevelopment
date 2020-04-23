using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmilyLearnsWebAppDevelopment.Models;

namespace EmilyLearnsWebAppDevelopment.Services
{
    public class CatProvider : ICatProvider
    {
        Dictionary<string, Cat> _cats;

        public CatProvider()
        {
            _cats = CatInitializer();
        }

        public Cat this[string name]
        {
            get
            {
                return _cats[name];
            }
        }

        private Dictionary<string, Cat> CatInitializer()
        {
            Dictionary<string, Cat> _catList = new Dictionary<string, Cat>();
            _catList.Add("Sky", new Cat("Bread Loaves", "Domestic Shorthair", "Sky", "March 13th, 2019", new CatData(2020, 1, "Tuxedo (Black and White)", "Laser")));
            _catList.Add("Everest", new Cat("Cardboard Boxes", "Domestic Shorthair", "Everest", "April 12th, 2019", new CatData(2020, 1, "Gray Tabby", "Mouse on String")));
            return _catList;
        }

        public IEnumerator<KeyValuePair<string, Cat>> GetEnumerator()
        {
            return _cats.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _cats.GetEnumerator();
        }
    }
}
