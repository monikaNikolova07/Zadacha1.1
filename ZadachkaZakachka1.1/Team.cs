using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadachkaZakachka1._1
{
    public class Team
    {
        public string Name { get; set; }
        private List<Player> players = new List<Player>();
        public List<string> History { get; set; }
        public DateTime CreationTime { get; }
        public Team(string name)
        {
            Name = name;
            CreationTime = DateTime.Now;
            History = new List<string>();
            History.Add($"Team '{Name}' created at {CreationTime}");
        }
        public void Add(Player player)
        {
            players.Add(player);
            History.Add($"Player {player.Name} ({player.Position}) joined at {DateTime.Now}");
        }
        public bool Remove(Player player)
        {
            bool removed = players.Remove(player);
            if (removed)
            {
                History.Add($"Player {player.Name} left at {DateTime.Now}");
            }
            return removed;
        }
        public IEnumerable<Player> GetPlayers()
        {
            return players;
        }
    }
}

