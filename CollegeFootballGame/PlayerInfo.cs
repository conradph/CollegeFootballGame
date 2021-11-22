using System;
using System.Collections.Generic;
using System.Text;

namespace CollegeFootballGame
{
    public class PlayerInfo : Info
    {
        public PlayerInfo(string firstName, string lastName, double height, double weight, State homeState, string currentTeam, int uniformNumber, Position position, SideOfField sideOfField, AcademicYear academicYear) : base(firstName, lastName, height, weight, homeState, currentTeam)
        {
            UniformNumber = uniformNumber;
            Position = position;
            SideOfField = sideOfField;
            AcademicYear = academicYear;
        }
        public PlayerInfo()
        {
            Random rand = new Random();
            RandomName names = new RandomName(rand);
            FirstName = names.GenerateFirst(Sex.Male);
            LastName = names.GenerateLast();
            Height = rand.Next(160, 210);
            Weight = rand.Next(150, 400);
            HomeState = States.los[rand.Next(States.los.Count)];
            CurrentTeam = "Team";
            UniformNumber = rand.Next(100);
            Position = (Position)rand.Next(Position.GetValues(typeof(Position)).Length);
            SideOfField = (SideOfField)rand.Next(SideOfField.GetValues(typeof(SideOfField)).Length);
            AcademicYear = (AcademicYear)rand.Next(AcademicYear.GetValues(typeof(AcademicYear)).Length);
        }
        public PlayerInfo(Position position)
        {
            Random rand = new Random();
            RandomName names = new RandomName(rand);
            FirstName = names.GenerateFirst(Sex.Male);
            LastName = names.GenerateLast();
            switch (position)
            {
                case Position.QB:
                    Height = Program.RandomUniform(rand, 75.5, 1);
                    Weight = Height* Program.RandomUniform(rand, 3, .1);
                    break;
                case Position.HB:
                    Height = Program.RandomUniform(rand, 70.7, 1);
                    Weight = Height * Program.RandomUniform(rand, 3, .1);
                    break;
                case Position.FB:
                    Height = Program.RandomUniform(rand, 70.7, 1);
                    Weight = Height * Program.RandomUniform(rand, 3.2, .1);
                    break;
                case Position.TE:
                    Height = Program.RandomUniform(rand, 76.5, 1);
                    Weight = Height * Program.RandomUniform(rand, 3.1, .1);
                    break;
                case Position.WR:
                    Height = Program.RandomUniform(rand, 73, 1);
                    Weight = Height * Program.RandomUniform(rand, 3, .1);
                    break;
                case Position.LT:
                case Position.LG:
                case Position.C:
                case Position.RG:
                case Position.RT:
                    Height = Program.RandomUniform(rand, 76.5, 1);
                    Weight = Height * Program.RandomUniform(rand, 3.3, .1);
                    break;
                case Position.CB: 
                case Position.FS:
                case Position.SS:
                    Height = Program.RandomUniform(rand, 71.5, 1);
                    Weight = Height * Program.RandomUniform(rand, 3, .1);
                    break;
                case Position.ROLB:
                case Position.LOLB:
                case Position.MLB:
                    Height = Program.RandomUniform(rand, 74, 1);
                    Weight = Height * Program.RandomUniform(rand, 3.2, .1);
                    break;
                case Position.LE:
                case Position.RE:
                case Position.DT:
                    Height = Program.RandomUniform(rand, 75.5, 1);
                    Weight = Height * Program.RandomUniform(rand, 3.3, .1);
                    break;
                case Position.K:
                case Position.P:
                    Height = Program.RandomUniform(rand, 72.5, 1.2);
                    Weight = Height * Program.RandomUniform(rand, 3, .1);
                    break;
            }
            Height = Math.Round(Height, 2);
            Weight = Math.Round(Weight);
            HomeState = States.los[rand.Next(States.los.Count)];
            CurrentTeam = "Team";
            UniformNumber = rand.Next(100);
            Position = position;
            SideOfField = (SideOfField)rand.Next(SideOfField.GetValues(typeof(SideOfField)).Length);
            AcademicYear = (AcademicYear)rand.Next(AcademicYear.GetValues(typeof(AcademicYear)).Length);
        }

        public int UniformNumber { get; set; }
        public Position Position { get; set; }
        public SideOfField SideOfField { get; set; }
        public int OverallRating => CalculateOverall();
        public AcademicYear AcademicYear { get; set; }
        public virtual int CalculateOverall()
        {
            return 0;
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Height}, {Weight}, {Position}: {HomeState}";
        }

    }
    public enum Position
    {
        QB,
        HB,
        FB,
        WR,
        TE,
        LT,
        LG,
        C,
        RG,
        RT,
        LE,
        DT,
        RE,
        ROLB,
        MLB,
        LOLB,
        CB,
        FS,
        SS,
        K,
        P
    }
    public enum SideOfField
    {
        Offense,
        Defense,
        SpecialTeams
    }
    public enum AcademicYear
    {
        Freshman,
        Sophomore,
        Junior,
        Senior
    }
}
