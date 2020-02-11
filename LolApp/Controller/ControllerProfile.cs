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

            return new ViewModelProfile(Constants.summonerDTO.Name, Constants.summonerDTO.ProfileIconId, Constants.summonerDTO.SummonerLevel, position.Tier, position.Rank,
                position.Wins, position.Losses, position.LeaguePoints);
        }

        
        private PositionDTO getPosition(SummonerDTO summoner)
        {
            LeagueV4 league = new LeagueV4(Constants.Region);

            var position = league.getPositions(summoner.Id).Where(p => p.QueueType.Equals("RANKED_SOLO_5x5")).FirstOrDefault();

            return position ?? new PositionDTO();
        }

        public void OpenMain()
        {
            MainWindow profile = new MainWindow();
            profile.Show();
        }
    }
}