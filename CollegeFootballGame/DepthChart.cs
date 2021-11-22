using System;
using System.Collections.Generic;
using System.Text;

namespace CollegeFootballGame
{
    public class DepthChart
    {
        Dictionary<Position, List<Player>> PlayerDict { get; set; }

        public DepthChart(List<Player> roster)
        {
            PlayerDict = new Dictionary<Position, List<Player>>();
            foreach (Player player in roster)
            {
                PlayerInfo tempInfo = (PlayerInfo)player.Info;
                if (PlayerDict.ContainsKey(tempInfo.Position))
                {
                    PlayerDict[tempInfo.Position].Add(player);
                }
                else
                {
                    PlayerDict.Add(tempInfo.Position, new List<Player> { player });
                }
            }
        }
        public void PrintDepthChart()
        {
            foreach (Position pos in Position.GetValues(typeof(Position)))
            {
                List < Player > players = PlayerDict[pos];
                Console.WriteLine(pos);
                for(int i = 0; i < players.Count; i++)
                {
                    Console.WriteLine($"{i+1}. {players[i]}");
                }
                Console.WriteLine();
            }
        }
    }
}
