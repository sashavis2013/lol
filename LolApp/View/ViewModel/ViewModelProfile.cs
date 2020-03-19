using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LolApp.Model;

namespace LolApp.View.ViewModel
{
    public class ViewModelProfile
    {
        private string name;
        private int profileIconId;
        private long summonerLevel;

        public string SummonerName { get; private set; }
        public string Icon { get; private set; }
        public long Level { get; private set; }
        public string Tier { get; private set; }
        public string Rank { get; private set; }
        public string Emblem { get; private set; }
        public int Wins { get; private set; }
        public int Losses { get; private set; }
        public int LeaguePoints { get; private set; }
        public List<MatchReferenceDto> Matches { get; private set; }
        public int MatchIndex { get; private set; }
        public int SeasonId { get; private set; }
        public int QueueId { get; private set; }
        public long GameId { get; private set; }
        public List<ParticipantIdentityDto> ParticipantIdentities { get; private set; }
        public string GameVersion { get; private set; }
        public string PlatformId { get; private set; }
        public string GameMode { get; private set; }
        public int MapId { get; private set; }
        public string GameType { get; private set; }
        public List<TeamStatsDto> Teams { get; private set; }
        public List<ParticipantDto> Participants { get; private set; }
        public long GameDuration { get; private set; }
        public long GameCreation { get; private set; }
        //public PlayerDto Player { get; private set; }
        //public int ParticipantId { get; private set; }

        public ViewModelProfile(string summonerName, int icon, long level, string tier, string rank, int wins, int losses, int leaguePoints, List<MatchReferenceDto> matches, int matchIndex, int seasonId, int queueId, long gameId, List<ParticipantIdentityDto> participantIdentities, string gameVersion, string platformId, string gameMode, int mapId, string gameType, List<TeamStatsDto> teams, List<ParticipantDto> participants, long gameDuration, long gameCreation/*, PlayerDto player,int participantId*/)
        {
            SummonerName = summonerName;
            Icon = "http://opgg-static.akamaized.net/images/profile_icons/profileIcon" + icon + ".jpg";
            Level = level;
            Tier = tier;
            Rank = rank;
            Wins = wins;
            Losses = losses;
            Matches = matches;
            MatchIndex = matchIndex;
            SeasonId = seasonId;
            QueueId = queueId;
            GameId = gameId;
            ParticipantIdentities = participantIdentities;
            GameVersion = gameVersion;
            PlatformId = platformId;
            GameMode = gameMode;
            MapId = mapId;
            GameType = gameType;
            Teams = teams;
            Participants = participants;
            GameDuration = gameDuration;
            GameCreation = gameCreation;
            //Player = player;
            //ParticipantId = participantId;

            LeaguePoints = leaguePoints;
            Emblem = "/LoLApp;component/Assets/" + tier + ".png";

            

        }

        public ViewModelProfile(string name, int profileIconId, long summonerLevel, string tier, string rank, int wins, int losses, int leaguePoints, int matchIndex, List<MatchReferenceDto> matches, long gameCreation, long gameDuration, long gameId, string gameMode, string gameType, string gameVersion, int mapId, List<ParticipantIdentityDto> participantIdentities, List<ParticipantDto> participants, string platformId, int queueId, int seasonId, List<TeamStatsDto> teams)
        {
            this.name = name;
            this.profileIconId = profileIconId;
            this.summonerLevel = summonerLevel;
            Tier = tier;
            Rank = rank;
            Wins = wins;
            Losses = losses;
            LeaguePoints = leaguePoints;
            MatchIndex = matchIndex;
            Matches = matches;
            GameCreation = gameCreation;
            GameDuration = gameDuration;
            GameId = gameId;
            GameMode = gameMode;
            GameType = gameType;
            GameVersion = gameVersion;
            MapId = mapId;
            ParticipantIdentities = participantIdentities;
            Participants = participants;
            PlatformId = platformId;
            QueueId = queueId;
            SeasonId = seasonId;
            Teams = teams;
        }
    }
}