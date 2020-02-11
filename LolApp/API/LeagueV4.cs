using LolApp.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolApp.API
{
    public class LeagueV4 : Api
    {
        public LeagueV4(string region) : base(region)
        {
        }

        public List<PositionDTO> getPositions(string summonerId)
        {
            string path = "league/v4/entries/by-summoner/" + summonerId;

            var response = get(getURI(path));
            string content = response.Content.ReadAsStringAsync().Result;

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<List<PositionDTO>>(content);
            }
            else
            {
                return null;
            }
        }
    }
}