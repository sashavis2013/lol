using LolApp.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolApp.API
{
    public class SummonerV4 : Api
    {
        public SummonerV4(string region) : base(region)
        {

        }

        public SummonerDTO getSummonerByName(string summonerName)
        {
            string path = "summoner/v4/summoners/by-name/" + summonerName;
            string pt = getURI(path);
            var response = get(pt);
            string content = response.Content.ReadAsStringAsync().Result;

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<SummonerDTO>(content);
            }
            else
            {
                return null;
            }

        }

    }
}
