using System;

namespace CollegeFootballGame
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerInfo info = new PlayerInfo(Position.QB);
            PlayerRatings ratings = new PlayerRatings(Position.QB);
            Console.WriteLine(ratings.Speed);
            Player player = new Player(info, ratings);

            /*Console.WriteLine("Hello and welcome to G&P Football!");
            Team team = new Team("Michigan State", "Spartans", States.los[22]);
            Console.WriteLine(team.Roster.Count);
            team.PrintInfoAndRoster();*/
            
        }
        public static double RandomUniform(Random rand, double mean, double stdDev)
        {
            double u1 = 1.0 - rand.NextDouble(); //uniform(0,1] random doubles
            double u2 = 1.0 - rand.NextDouble();
            double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) *
                         Math.Sin(2.0 * Math.PI * u2); //random normal(0,1)
            double randNormal =
                         mean + stdDev * randStdNormal; //random normal(mean,stdDev^2)
            return randNormal;
        }
    }
}

