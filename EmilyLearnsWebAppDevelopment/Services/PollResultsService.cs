using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmilyLearnsWebAppDevelopment.Services
{
    public class PollResultsService : IPollResultsService
    {
        private Dictionary<SelectedColor, int> _selectionVotes;

        public PollResultsService()
        {
            _selectionVotes = new Dictionary<SelectedColor, int>();
        }

        public void AddVote(SelectedColor color)
        {
            if (_selectionVotes.ContainsKey(color))
            {
                _selectionVotes[color]++;
            }
            else
            {
                _selectionVotes.Add(color, 1);
            }
        }

        public SortedDictionary<SelectedColor, int> GetVoteResult()
        {
            return new SortedDictionary<SelectedColor, int>(_selectionVotes);
        }
    }
}
