using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadachkaZakachka1._1
{
    public class LogAn: ILog
    {
        public void WriteTeamLog(Team team, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine($"Team: {team.Name}");
                writer.WriteLine($"Created at: {team.CreationTime}");
                writer.WriteLine();
                writer.WriteLine("Players:");
                foreach (var player in team.GetPlayers())
                {
                    writer.WriteLine($" - {player.Name} ({player.Position})");
                }
                writer.WriteLine();
                writer.WriteLine("History:");
                foreach (var log in team.History)
                {
                    writer.WriteLine(log);
                }
            }
        }
        public void WriteTeamHistory(Team team, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Team History:");
                foreach (var log in team.History)
                {
                    writer.WriteLine(log);
                }
            }
        }
    }
}
}
