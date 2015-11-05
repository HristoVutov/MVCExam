namespace SportSystem.App.Controllers
{
    using AutoMapper;
    using Data.UnitOfWork;
    using Models.ViewModels;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Web.Mvc;

    public class HomeController : BaseController
    {
        public HomeController(ISportSystemData data)
            : base(data)
        {
        }

        public ActionResult Index()
        {
            var topMatches = this.Data.Matches.All()
                .OrderByDescending(m => m.Bets.Count)
                .Include(m=> m.HomeTeam)
                .Include(m => m.AwayTeam)
                .Take(3);
            var bestTeams = this.Data.Teams.All()
                .OrderByDescending(m => m.Votes.Count)
                .Take(3);
            var model = new MatchTeamViewModel()
            {
                Matches = Mapper.Map<IEnumerable<MatchViewModel>>(topMatches),
                Teams = Mapper.Map<IEnumerable<TeamViewModel>>(bestTeams)
            };
            return this.View(model);
        }
    }
}