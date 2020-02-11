using LolApp.API;
using LolApp.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolApp.Controller
{
    public class ControllerMain
    {
        public bool getSummoner(Constants Summoner)
        {
            SummonerV4 summonerV4 = new SummonerV4(Constants.Region);

            var summoner = summonerV4.getSummonerByName(Constants.Summoner);

            Summoner.SetDTO(summoner);

            return summoner != null;
        }
    }
}