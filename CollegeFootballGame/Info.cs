
namespace CollegeFootballGame
{
    public class Info
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public State HomeState { get; set; }
        public string CurrentTeam { get; set; }

        public Info(string firstName, string lastName, double height, double weight, State homeState,  string currentTeam)
        {
            FirstName = firstName;
            LastName = lastName;
            Height = height;
            Weight = weight;
            HomeState = homeState;
            CurrentTeam = currentTeam;
        }
        public Info()
        {

        }
        public override string ToString()
        {
            return $"";
        }
    }
}