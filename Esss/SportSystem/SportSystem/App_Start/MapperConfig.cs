using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using SportSystem.Model;
using SportSystem.Models.ViewModels;

namespace SportSystem.App_Start
{
    public static class MapperConfig
    {
        public static void RegisteredMappings()
        {
            Mapper.CreateMap<Match, MatchViewModel>().
                ForMember(vm => vm.HomeTeamName, opt => opt.MapFrom(m => m.HomeTeam.Name)).
                ForMember(vm => vm.AwayTeamName, opt => opt.MapFrom(m => m.AwayTeam.Name));

            Mapper.CreateMap<Team, TeamViewModel>().
                ForMember(vm => vm.VotesCount, opt => opt.MapFrom(t => t.Votes.Count));
        }
    }
}