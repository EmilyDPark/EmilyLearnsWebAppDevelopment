using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmilyLearnsWebAppDevelopment.Models
{
    public class Creation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Medium { get; set; }

        [Display(Name = "Fun Fact")]
        public string FunFact { get; set; }

        public string ImageName1 { get; set; }
        public string ImageName2 { get; set; }
    }
}
