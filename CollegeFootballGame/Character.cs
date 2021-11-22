using System;
using System.Collections.Generic;
using System.Text;

namespace CollegeFootballGame
{
    public class Character
    {
        public virtual Info Info { get; set; }
        public Ratings Ratings { get; set; }

        public Character(Info info, Ratings ratings)
        {
            Info = info;
            Ratings = ratings;
        }
        public Character()
        {
            //Empty constructor for the child
        }
    }
}
