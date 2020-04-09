using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmilyLearnsWebAppDevelopment.Models;
using EmilyLearnsWebAppDevelopment.Services;
using System.Text;

namespace EmilyLearnsWebAppDevelopment.Controllers
{
    public class PollController : Controller
    {
        private IPollResultsService _pollResults;

        public PollController(IPollResultsService pollResults)
        {
            _pollResults = pollResults;
        }

        public IActionResult Index()
        {
            if (Request.Query.ContainsKey("submitted"))
            {
                StringBuilder results = new StringBuilder();
                SortedDictionary<SelectedColor, int> voteList = _pollResults.GetVoteResult();

                foreach (var gameVotes in voteList)
                {
                    results.Append($"Color name: {gameVotes.Key}. Votes: {gameVotes.Value}{Environment.NewLine}");
                }

                return Content(results.ToString());
            }
            else
            {
                return View();
            }
        }
    }
}