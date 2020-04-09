using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmilyLearnsWebAppDevelopment.Services
{
    public interface IPollResultsService
    {
        void AddVote(SelectedColor color);
        SortedDictionary<SelectedColor, int> GetVoteResult();
    }
}
