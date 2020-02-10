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
        public bool getSummoner(string SummonerName)
        {
            SummonerV4 summonerV4 = new SummonerV4(Constants.Region);

            var summoner = summonerV4.getSummonerByName(SummonerName);

            Constants.Summoner = summoner;

            return summoner != null;
        }
    }
}