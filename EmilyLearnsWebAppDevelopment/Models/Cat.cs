using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmilyLearnsWebAppDevelopment.Models
{
    public class Cat
    {
        public string Title { get; }
        public string Breed { get; }
        public string Name { get; }
        public string Birthday { get; }
        public CatData Data { get; }

        public Cat(string title, string breed, string catName, string birthday, CatData data)
        {
            Title = title;
            Breed = breed;
            Name = catName;
            Birthday = birthday;
            Data = data;
        }
    }
}
