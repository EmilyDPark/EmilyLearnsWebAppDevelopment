using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmilyLearnsWebAppDevelopment.Models;

namespace EmilyLearnsWebAppDevelopment.Services
{
    public interface ICatProvider : IEnumerable<KeyValuePair<string, Cat>>
    {
        Cat this[string name] { get; }
    }
}
