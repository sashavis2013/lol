using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolApp.Model
{
    public class MatchDto
    {
        public int seasonId { get; set; }
        public int queueId { get; set; }
        public long gameId { get; set; }
        public List<ParticipantIdentityDto> participantIdentities { get; set; }
        public string gameVersion { get; set; }
        public string platformId { get; set; }
        public string gameMode { get; set; }
        public int mapId { get; set; }
        public string gameType { get; set; }
        public List<TeamStatsDto> teams { get; set; }
        public List<ParticipantDto> participants { get; set; }
        public long gameDuration { get; set; }
        public long gameCreation { get; set; }

    }
}
