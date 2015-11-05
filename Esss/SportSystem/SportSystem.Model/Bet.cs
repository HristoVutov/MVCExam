using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportSystem.Model
{
    public class Bet
    {
        public int Id { get; set; }

        public string BettingUserId { get; set; }

        [Required]
        public virtual User BettingUser { get; set; }

        public virtual Match Match { get; set; }

        public decimal? HomeBet { get; set; }

        public decimal? AwayBet { get; set; }
    }
}
