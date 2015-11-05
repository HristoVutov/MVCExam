using System;

namespace SportSystem.Models.ViewModels
{
    public class MatchViewModel
    {
        public int Id { get; set; }

        public string HomeTeamName { get; set; }
        
        public string AwayTeamName { get; set; }

        public DateTime Date { get; set; }
    }
}