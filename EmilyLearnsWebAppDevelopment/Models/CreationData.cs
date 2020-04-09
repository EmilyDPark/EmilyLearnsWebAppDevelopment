using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmilyLearnsWebAppDevelopment.Models
{
    public class CreationData : ICreationData
    {
        public List<Creation> CreationsList { get; set; }

        public List<Creation> CreationsInitializeData()
        {
            CreationsList = new List<Creation>()
            {
                new Creation()
                {
                    Id = 1,
                    Name = "Ball in Cage",
                    Medium = "Wood",
                    FunFact = "I don't recommend whittling over carpet.",
                    ImageName1 = "ballincage.jpg"
                },
                new Creation()
                {
                    Id = 2,
                    Name = "Brother's Poster",
                    Medium = "Digital",
                    FunFact = "If you can't read/understand Korean, the poster is funny. Trust me.",
                    ImageName1 = "brothersposter.jpg"
                },

                new Creation()
                {
                    Id = 3,
                    Name = "Death By Powerpoint",
                    Medium = "Sharpie",
                    FunFact = "Disappointingly, only one person guessed what my costume was...",
                    ImageName1 = "deathbypowerpoint1.jpg",
                    ImageName2 = "deathbypowerpoint2.jpg"
                },
                new Creation()
                {
                    Id = 4,
                    Name = "Fireplace",
                    Medium = "Foam",
                    FunFact = "It's much better than the one I made the year before.",
                    ImageName1 = "fireplace.jpg"
                },
                new Creation()
                {
                    Id = 5,
                    Name = "Lion",
                    Medium = "Paper",
                    FunFact = "Army's 24 hour guard duty is great for undertaking massive projects.",
                    ImageName1 = "lion1.jpg",
                    ImageName2 = "lion2.jpg"
                },
                new Creation()
                {
                    Id = 6,
                    Name = "Spice Rack",
                    Medium = "Styrene",
                    FunFact = "Cutting styrene is incredibly satisfying.",
                    ImageName1 = "spicerack1.jpg",
                    ImageName2 = "spicerack2.jpg"
                },
                new Creation()
                {
                    Id = 7,
                    Name = "Ugly Christmas Sweater",
                    Medium = "Fabric",
                    FunFact = "I won my battalion's Ugly Christmas Sweater Contest with this monstrosity.",
                    ImageName1 = "uglychristmassweater.jpg"
                }
            };

            return CreationsList;
        }

        public Creation GetCreationById(int? id)
        {
            if (id == null)
            {
                return null;
            }
            else
            {
                return CreationsList.SingleOrDefault(c => c.Id == id);
            }
        }
    }
}
