using System;
using System.Collections.Generic;
using System.Text;

namespace CollegeFootballGame
{
    public class CoachInfo : Info
    {
        public CoachInfo(string firstName, string lastName, double height, double weight, State homeState, string currentTeam, CoachType coachType, string offensiveTendency, string defensiveTendency) : base(firstName, lastName, height, weight, homeState, currentTeam)
        {
            CoachType = coachType;
            OffensiveTendency = offensiveTendency;
            DefensiveTendency = defensiveTendency;
        }

        public CoachType CoachType { get; set; }
        public string OffensiveTendency { get; set; }
        public string DefensiveTendency { get; set; }

    }

    public enum CoachType
    {
        HeadCoach,
        OffensiveCoordinator,
        DefensiveCoordinator
    }
    
}
