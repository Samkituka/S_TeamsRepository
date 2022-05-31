using System;
using System.Collections.Generic;

#nullable disable

namespace MyDatabase.DataAccess.EF.Models
{
    public partial class Soccer
    {
        public int SoccerId { get; set; }
        public string SoccerTeams { get; set; }
        public string BestTeamPlayer { get; set; }
        public short GamesPlayed { get; set; }
        public short GamesWon { get; set; }
        public short GamesLost { get; set; }
        public DateTime DatePlayed { get; set; }

        public Soccer(int soccerid, string soccerteams, string bestteamplayers, short gamesplayed, short gameswon, short gameslost, DateTime dateplayed)
        {
            SoccerId = soccerid;
            BestTeamPlayer = bestteamplayers;
            GamesPlayed = gamesplayed;
            GamesWon = gameswon;
            GamesLost = gameslost;
            DatePlayed = dateplayed;
        }

        public Soccer()
        {

        }

    }
}
