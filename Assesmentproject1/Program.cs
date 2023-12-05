using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesmentproject1
{
    public class Program 
    {
        static void AddPlayer(OneDayTeam team)
        {
            Console.WriteLine("Enter Player Id: ");
            int playerId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Player Name: ");
            string playerName = Console.ReadLine();
            Console.WriteLine("Enter Player Age: ");
            int playerAge = int.Parse(Console.ReadLine());
            team.Add(new Player { PlayerId = playerId, PlayerName = playerName, PlayerAge = playerAge });

        }
        static void RemovePlayer(OneDayTeam team)
        {
            Console.WriteLine("Enter Player id to remove");
            int playerId = int.Parse(Console.ReadLine());
            team.Remove(playerId);
        }

        static void GetPlayerById(OneDayTeam team)
        {
            Console.WriteLine("Enter player id: ");
            int playerId = int.Parse(Console.ReadLine());
            Player player = team.GetPlayerById(playerId);
            if (player != null)
            {
                Console.WriteLine($"Id: {player.PlayerId}");
                Console.WriteLine($"Name: {player.PlayerName}");
                Console.WriteLine($"Age: {player.PlayerAge}");
            }
            else
            {
                Console.WriteLine("Player with that player id  not found");
            }
        }
        static void GetPlayerByName(OneDayTeam team)
        {
            Console.WriteLine("Enter Player name: ");
            string playerName = Console.ReadLine();
            Player player = team.GetPlayerByName(playerName);
            if (player != null)
            {
                Console.WriteLine($"Id: {player.PlayerId}");
                Console.WriteLine($"Name: {player.PlayerName}");
                Console.WriteLine($"Age: {player.PlayerAge}");

            }
            else
            {
                Console.WriteLine("Player not found");
            }

        }
        static void GetAllPlayers(OneDayTeam team)
        {
            List<Player> player = team.GetAllPlayers();
            foreach (Player p in player)
            {
                Console.WriteLine($"Id: {p.PlayerId}");
                Console.WriteLine($"Name: {p.PlayerName}");
                Console.WriteLine($"Age: {p.PlayerAge}");
            }
        }
        static void Main(string[] args)
        {
            OneDayTeam team = new OneDayTeam();
            string option;
            do
            {
                Console.WriteLine("Choose an operation to be performed  \n 1:To Add Player \n2:To Remove Player by Id \n3:Get Player By Id \n4:Get Player by Name \n5:Get All Players");
                int op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        AddPlayer(team);
                        break;

                    case 2:
                        RemovePlayer(team);
                        break;

                    case 3:
                        GetPlayerById(team);
                        break;

                    case 4:
                        GetPlayerByName(team);
                        break;

                    case 5:
                        GetAllPlayers(team);
                        break;

                    default:
                        Console.WriteLine("Invalid Operation");
                        break;
                }
                Console.WriteLine("Do you want to continue to perform (yes/no)?:");
                option = Console.ReadLine();
            }
            while (option == "yes");

            Console.ReadKey();

        }
    }
}
