using SportSystem.Data.Repositories;
using SportSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportSystem.Data.UnitOfWork
{
    public interface ISportSystemData
    {
        IRepository<User> Users { get; }

        IRepository<Team> Teams { get; }

        IRepository<Bet> Bets { get; }

        IRepository<Player> Players { get; }

        IRepository<Match> Matches { get; }

        IRepository<Comment> Comments { get; }

        IRepository<Vote> Vote { get; }

        int SaveChanges();
    }
}
