using System;
using System.Collections.Generic;
using System.Text;

namespace CollegeFootballGame
{
    public class Player : Character
    {
        
        public Player(Info info, Ratings ratings) : base(info, ratings)
        {
        }
        public Player()
        {
            Info = new PlayerInfo();
            Ratings = new Ratings();
        }
        public Player(Position position)
        {
            Info = new PlayerInfo(position);
            Ratings = new Ratings();
        }
        public override string ToString()
        {
            return Info.ToString();
        }
    }


}
