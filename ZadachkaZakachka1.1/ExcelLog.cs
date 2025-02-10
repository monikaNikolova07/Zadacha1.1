using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadachkaZakachka1._1
{
    public class ExcelLog : ILog
    {
        public void WriteTeamLog(Team team, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Team,CreatedAt");
                writer.WriteLine($"{team.Name},{team.CreationTime}");
                writer.WriteLine();
                writer.WriteLine("Players");
                writer.WriteLine("Name,Position");
                foreach (var player in team.GetPlayers())
                {
                    writer.WriteLine($"{player.Name},{player.Position}");
                }
                writer.WriteLine();
                writer.WriteLine("History");
                writer.WriteLine("Event");
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
                writer.WriteLine("History");
                writer.WriteLine("Event");
                foreach (var log in team.History)
                {
                    writer.WriteLine(log);
                }
            }
        }
    }
}

