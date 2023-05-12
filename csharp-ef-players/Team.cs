using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_ef_players;
public class Team
{
    public int TeamId { get; set; }
    public string Name { get; set; }
    public string City { get; set; }
    public string Trainer { get; set; }
    public string Colors { get; set; }

    public List<Player> PlayerList { get; set; }

    public Team(string name, string city, string trainer, string colors, List<Player> playerList, int teamId = 0)
    {
        Name = name;
        City = city;
        Trainer = trainer;
        Colors = colors;
        PlayerList = playerList;
    }
}
