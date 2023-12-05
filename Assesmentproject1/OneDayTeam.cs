using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesmentproject1
{
    public class OneDayTeam : ITeam
    {
        public static List<Player> oneDayTeam = new List<Player>();
        public OneDayTeam()
        {
            oneDayTeam.Capacity = 11;
        }
        public void Add(Player player)
        {

            if (oneDayTeam.Count < oneDayTeam.Capacity)
            {
                oneDayTeam.Add(player);
                Console.WriteLine("player added successfully");
            }
            else { Console.WriteLine("team is full"); }
        }
        public void Remove(int playerId)
        {
            Player player = oneDayTeam.Find(p => p.PlayerId == playerId);
            if (player != null)
            {
                oneDayTeam.Remove(player);
                Console.WriteLine("Player is removed successfully");
            }
            else
            {
                Console.WriteLine("No Player is found");

            }
        }
        public Player GetPlayerById(int playerId)
        {
            return oneDayTeam.Find(p => p.PlayerId == playerId);
        }

        public Player GetPlayerByName(string playerName)
        {
            return oneDayTeam.Find(p => playerName == playerName.ToLower());
        }

        public List<Player> GetAllPlayers()
        {
            Console.WriteLine();
            return oneDayTeam;
        }
    }
}
