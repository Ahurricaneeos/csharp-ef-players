using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_ef_players
{
    [Table ("players_table")]
    public class Player
    {
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int PlayerScore { get; set; }
        public int PlayerMatch { get; set; }
        public int PlayerVictories { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }

        public Player (string name, string surname, int playerScore, int playerMatch, int playerVictories, int teamId, Team team, int PlayerId = 0)
        {
            Name = name;
            Surname = surname;
            PlayerScore = playerScore;
            PlayerMatch = playerMatch;
            PlayerVictories = playerVictories;
            TeamId = teamId;
            Team = team;
        }
    }
}
