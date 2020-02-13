using LolApp.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolApp.API
{
    public class MatchV4 : Api
    {

        public MatchV4(string region) : base(region)
        {
        }

        public MatchlistDto GetMatchlistByAccountId(string accountId)
        {

            string path = "match/v4/matchlists/by-account/" + accountId; //+ "?queue=420&queue=400&endIndex=5";
            string pt = getURI(path);
            var response = get(pt);
            string content = response.Content.ReadAsStringAsync().Result;


            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<MatchlistDto>(content);
            }
            else
            {
                return null;
            }
        }


        public MatchDto GetMatchByMatchId(string gameId)
        {

            string path = "match/v4/matches/" + gameId ;
            string pt = getURI(path);
            var response = get(pt);
            string content = response.Content.ReadAsStringAsync().Result;


            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<MatchDto>(content);
            }
            else
            {
                return null;
            }
        }



    }
}
