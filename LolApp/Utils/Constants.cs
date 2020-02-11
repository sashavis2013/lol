using LolApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolApp.Utils
{
     public class Constants
     {
        public static string summonerName;
        public static string region;
        public static SummonerDTO SummonerDTO;

        public static string Summoner
        {
            get
            {
                return summonerName;
            }
            private set
            {
                Summoner = value;
            }
        }
        public static string Region
        {
            get
            {
                return region;
            }
            private set
            {
                region = value;
            }
        }
        public static SummonerDTO summonerDTO 
        { 
            get 
            { 
                return SummonerDTO;
            }
            private set
            {
                SummonerDTO = summonerDTO;
            }
        } 
        public Constants(string Name, string Region)
        {
            summonerName = Name;
            region = Region;
        }

        public void SetDTO(SummonerDTO summonerDTO)
        {
            SummonerDTO = summonerDTO;
            return;
        }

    }
}
