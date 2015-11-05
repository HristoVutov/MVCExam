using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportSystem.Models.ViewModels
{
    public class MatchTeamViewModel
    {
        public IEnumerable<MatchViewModel> Matches { get; set; }

        public IEnumerable<TeamViewModel> Teams { get; set; }
    }
}