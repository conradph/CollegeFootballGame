using System;
using System.Collections.Generic;
using System.Text;

namespace CollegeFootballGame
{
    public class Team
    {
        public List<Player> Roster { get; set; }
        public string CollegeName { get; set; }
        public string NickName { get; set; }
        public State State { get; set; }
        public DepthChart DepthChart { get; set; }
        public Team(List<Player> roster, string collegeName, string nickName, State state)
        {
            Roster = roster;
            CollegeName = collegeName;
            NickName = nickName;
            State = state;
            DepthChart = new DepthChart(Roster);
        }

        public Team(string collegeName, string nickName, State state)
        {
            Roster = new List<Player>();
            //Create QBs
            for(int i = 0; i < 3; i++)
            {
                Roster.Add(new Player(Position.QB));
            }
            //Create HBs
            for (int i = 0; i < 4; i++)
            {
                Roster.Add(new Player(Position.HB));
            }
            //Create FBs
            for (int i = 0; i < 2; i++)
            {
                Roster.Add(new Player(Position.FB));
            }
            //Create TEs
            for (int i = 0; i < 3; i++)
            {
                Roster.Add(new Player(Position.TE));
            }
            //Create WRs
            for (int i = 0; i < 7; i++)
            {
                Roster.Add(new Player(Position.WR));
            }
            //Create LTs
            for (int i = 0; i < 2; i++)
            {
                Roster.Add(new Player(Position.LT));
            }
            //Create LGs
            for (int i = 0; i < 2; i++)
            {
                Roster.Add(new Player(Position.LG));
            }
            //Create Cs
            for (int i = 0; i < 2; i++)
            {
                Roster.Add(new Player(Position.C));
            }
            //Create RGs
            for (int i = 0; i < 2; i++)
            {
                Roster.Add(new Player(Position.RG));
            }
            //Create RTs
            for (int i = 0; i < 2; i++)
            {
                Roster.Add(new Player(Position.RT));
            }
            //Create RGs
            for (int i = 0; i < 2; i++)
            {
                Roster.Add(new Player(Position.RG));
            }
            //Create LEs
            for (int i = 0; i < 2; i++)
            {
                Roster.Add(new Player(Position.LE));
            }
            //Create REs
            for (int i = 0; i < 2; i++)
            {
                Roster.Add(new Player(Position.RE));
            }
            //Create DTs
            for (int i = 0; i < 4; i++)
            {
                Roster.Add(new Player(Position.DT));
            }
            //Create ROLBs
            for (int i = 0; i < 2; i++)
            {
                Roster.Add(new Player(Position.ROLB));
            }
            //Create LOLBs
            for (int i = 0; i < 2; i++)
            {
                Roster.Add(new Player(Position.LOLB));
            }
            //Create MLBs
            for (int i = 0; i < 3; i++)
            {
                Roster.Add(new Player(Position.MLB));
            }
            //Create CBs
            for (int i = 0; i < 5; i++)
            {
                Roster.Add(new Player(Position.CB));
            }
            //Create FSs
            for (int i = 0; i < 2; i++)
            {
                Roster.Add(new Player(Position.FS));
            }
            //Create SSs
            for (int i = 0; i < 2; i++)
            {
                Roster.Add(new Player(Position.SS));
            }
            //Create Ks
            for (int i = 0; i < 1; i++)
            {
                Roster.Add(new Player(Position.K));
            }
            //Create Ps
            for (int i = 0; i < 1; i++)
            {
                Roster.Add(new Player(Position.P));
            }
            CollegeName = collegeName;
            NickName = nickName;
            State = state;
            DepthChart = new DepthChart(Roster);
        }
        public void PrintRoster()
        {
            DepthChart.PrintDepthChart();
        }
        public void PrintTeamInfo()
        {
            Console.WriteLine($"{CollegeName} {NickName}");
        }
        public void PrintInfoAndRoster()
        {
            PrintTeamInfo();
            PrintRoster();
        }
    }
}
