using LolApp.API;
using LolApp.Model;
using LolApp.Utils;
using LolApp.View.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolApp.Controller
{
    public class ControllerProfile
    {
        public object GetContext(Constants summoner)
        {
            ControllerMain cont = new ControllerMain();
            cont.getSummoner(summoner);

            var position = getPosition(Constants.summonerDTO);

            var matchlist = getMatchlist(Constants.summonerDTO);

            int matchIndex=0;

            var matchdto = getMatch(Constants.MatchlistDto, matchIndex);

            return new ViewModelProfile(Constants.summonerDTO.Name, Constants.summonerDTO.ProfileIconId, Constants.summonerDTO.SummonerLevel, position.Tier, position.Rank,
                position.Wins, position.Losses, position.LeaguePoints, matchIndex, matchlist.matches, matchdto.gameCreation, matchdto.gameDuration, matchdto.gameId, matchdto.gameMode, matchdto.gameType, matchdto.gameVersion, matchdto.mapId, matchdto.participantIdentities, matchdto.participants, matchdto.platformId, matchdto.queueId, matchdto.seasonId, matchdto.teams) ;
        }

        
        private PositionDTO getPosition(SummonerDTO summoner)
        {
            LeagueV4 league = new LeagueV4(Constants.Region);

            var position = league.getPositions(summoner.Id).Where(p => p.QueueType.Equals("RANKED_SOLO_5x5")).FirstOrDefault();

            return position ?? new PositionDTO();
        }

        private MatchlistDto getMatchlist(SummonerDTO summoner)
        {
            MatchV4 match = new MatchV4(Constants.Region);
            var matchlist = match.GetMatchlistByAccountId(summoner.accountId);
            return matchlist ?? new MatchlistDto();

        }

        private MatchDto getMatch(MatchlistDto matchlist, int matchIndex)
        {
            MatchV4 match = new MatchV4(Constants.Region);
            var matchdto = match.GetMatchByMatchId(matchlist.matches[matchIndex].ToString());
            return matchdto ?? new MatchDto();

        }
        
        public void OpenMain()
        {
            MainWindow profile = new MainWindow();
            profile.Show();
        }
    }
}