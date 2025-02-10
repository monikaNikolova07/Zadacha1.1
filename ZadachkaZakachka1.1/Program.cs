using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ZadachkaZakachka1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var teams = new Dictionary<string, Team>();
            var players = new Dictionary<string, Player>();
            string input = Console.ReadLine().Trim();
            while (input != "exit")
            {
                string[] parts = input.Split(' ');
                string command = parts[0].ToLower();
                switch (command)
                {
                    case "create_team":
                        string teamName = parts[1];
                        teams[teamName] = new Team(teamName);
                        Console.WriteLine($"Team '{teamName}' created.");
                        break;

                    case "create_player":
                        string playerName = parts[1];
                        string position = parts[2];
                        players[playerName] = new Player(playerName, position);
                        Console.WriteLine($"Player '{playerName}' created.");
                        break;

                    case "add_player":
                        teamName = parts[1];
                        playerName = parts[2];
                        position = parts[3];
                        Team team = new Team(parts[1]);
                        Player player = new Player(parts[2], parts[3]);
                        team.Add(player);
                        Console.WriteLine($"Player '{playerName}' added to team '{teamName}'.");
                        break;
                    case "remove_player":
                        teamName = parts[1];
                        playerName = parts[2];
                        position = parts[3];
                        Team team1 = new Team(parts[1]);
                        Player player1 = new Player(parts[2], parts[3]);
                        team1.Remove(player1);
                        Console.WriteLine($"Player '{playerName}' removed from team '{teamName}'.");
                        break;

                    case "print_team":
                        teamName = parts[1];
                        string filePath = parts[2];
                        string logType = parts[3].ToLower();
                        Team team2 = new Team(parts[1]);
                        ILog log;
                        if (logType == "txt")
                        {
                            log = new LogAn();
                        }
                        else
                        {
                            log = logType == "xlsx" ? new ExcelLog() : null;
                        }

                        log.WriteTeamLog(team2, filePath);
                        Console.WriteLine($"Team '{teamName}' written to '{filePath}' as {logType}.");
                        break;
                    case "print_log_txt":
                        teamName = parts[1];
                        filePath = parts[2];
                        Team team3 = new Team(parts[1]);
                        new LogAn().WriteTeamHistory(team3, filePath);
                        Console.WriteLine($"Team history for '{teamName}' written to '{filePath}'.");
                        break;
                    case "print_log_excel":
                        teamName = parts[1];
                        filePath = parts[2];
                        Team team4 = new Team(parts[1]);
                        new ExcelLog().WriteTeamHistory(team4, filePath);
                        Console.WriteLine($"Team history for '{teamName}' written to '{filePath}'.");
                        break;
                    default:
                        Console.WriteLine("Unknown command.");
                        break;
                        input = Console.ReadLine();
                }
            }
        }
    }
}
    

