using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmilyLearnsWebAppDevelopment.Models
{
    public interface ICreationData
    {
        List<Creation> CreationsList { get; set; }
        List<Creation> CreationsInitializeData();
        Creation GetCreationById(int? id);
    }
}
