using System;
using System.Collections.Generic;
using System.Text;

namespace CollegeFootballGame
{
    public class PlayerRatings : Ratings
    {
        protected int _speed;
        public int Speed {get { return _speed; } set { 
                if(value < 40)
                { 
                    _speed = 40;
                }
                else if (value > 99)
                {
                    _speed = 99;
                }
                    } }
        protected int _acceleration;
        public int Acceleration
        {
            get { return _acceleration; }
            set
            {
                if (value < 40)
                {
                    _acceleration = 40;
                }
                else if (value > 99)
                {
                    _acceleration = 99;
                }
            }
        }
        protected int _strength;
        public int Strength
        {
            get { return _strength; }
            set
            {
                if (value < 40)
                {
                    _strength = 40;
                }
                else if (value > 99)
                {
                    _strength = 99;
                }
            }
        }
        protected int _agility;
        public int Agility
        {
            get { return _agility; }
            set
            {
                if (value < 40)
                {
                    _agility = 40;
                }
                else if (value > 99)
                {
                    _agility = 99;
                }
            }
        }
        protected int _Jumping;
        public int Jumping
        {
            get { return _Jumping; }
            set
            {
                if (value < 40)
                {
                    _Jumping = 40;
                }
                else if (value > 99)
                {
                    _Jumping = 99;
                }
            }
        }
        protected int _stamina;
        public int Stamina
        {
            get { return _stamina; }
            set
            {
                if (value < 40)
                {
                    _stamina = 40;
                }
                else if (value > 99)
                {
                    _stamina = 99;
                }
            }
        }
        public int Injury { get; set; }
        public int Tackle { get; set; }
        public int HitPower { get; set; }
        public int Pursuit { get; set; }
        public int PlayRecognition { get; set; }
        public int ManCoverage { get; set; }
        public int ZoneCoverage { get; set; }
        public int Press { get; set; }
        public int Catching { get; set; }
        public int CatchInTraffic { get; set; }
        public int RouteRunning { get; set; }
        public int Release { get; set; }
        public int Return { get; set; }
        public int PowerMoves { get; set; }
        public int FinesseMoves { get; set; }
        public int BlockShedding { get; set; }
        public int BreakTackle { get; set; }
        public int Trucking { get; set; }
        public int Elusiveness { get; set; }
        public int StiffArm { get; set; }
        public int SpinMove { get; set; }
        public int JukeMove { get; set; }
        public int Carrying { get; set; }
        public int BCVision { get; set; }
        public int ThrowPower { get; set; }
        public int ThrowAccuracy { get; set; }

        public PlayerRatings(int speed, int acceleration, int strength, int agility, int jumping, int stamina, int injury, int tackle, int hitPower, int pursuit, int playRecognition, int manCoverage, int zoneCoverage, int press, int catching, int catchInTraffic, int routeRunning, int release, int @return, int powerMoves, int finesseMoves, int blockShedding, int breakTackle, int trucking, int elusiveness, int stiffArm, int spinMove, int jukeMove, int carrying, int bCVision, int throwPower, int throwAccuracy)
        {
            Speed = speed;
            Acceleration = acceleration;
            Strength = strength;
            Agility = agility;
            Jumping = jumping;
            Stamina = stamina;
            Injury = injury;
            Tackle = tackle;
            HitPower = hitPower;
            Pursuit = pursuit;
            PlayRecognition = playRecognition;
            ManCoverage = manCoverage;
            ZoneCoverage = zoneCoverage;
            Press = press;
            Catching = catching;
            CatchInTraffic = catchInTraffic;
            RouteRunning = routeRunning;
            Release = release;
            Return = @return;
            PowerMoves = powerMoves;
            FinesseMoves = finesseMoves;
            BlockShedding = blockShedding;
            BreakTackle = breakTackle;
            Trucking = trucking;
            Elusiveness = elusiveness;
            StiffArm = stiffArm;
            SpinMove = spinMove;
            JukeMove = jukeMove;
            Carrying = carrying;
            BCVision = bCVision;
            ThrowPower = throwPower;
            ThrowAccuracy = throwAccuracy;
        }
        public PlayerRatings()
        {
            Random rand = new Random();
            Speed = rand.Next(99);
            Acceleration = rand.Next(99);
            Strength = rand.Next(99);
            Agility = rand.Next(99);
            Jumping = rand.Next(99);
            Stamina = rand.Next(99);
            Injury = rand.Next(99);
            Tackle = rand.Next(99);
            HitPower = rand.Next(99);
            Pursuit = rand.Next(99);
            PlayRecognition = rand.Next(99);
            ManCoverage = rand.Next(99);
            ZoneCoverage = rand.Next(99);
            Press = rand.Next(99);
            Catching = rand.Next(99);
            CatchInTraffic = rand.Next(99);
            RouteRunning = rand.Next(99);
            Release = rand.Next(99);
            Return = rand.Next(99);
            PowerMoves = rand.Next(99);
            FinesseMoves = rand.Next(99);
            BlockShedding = rand.Next(99);
            BreakTackle = rand.Next(99);
            Trucking = rand.Next(99);
            Elusiveness = rand.Next(99);
            StiffArm = rand.Next(99);
            SpinMove = rand.Next(99);
            JukeMove = rand.Next(99);
            Carrying = rand.Next(99);
            BCVision = rand.Next(99);
            ThrowPower = rand.Next(99);
            ThrowAccuracy = rand.Next(99);
        }
        public PlayerRatings(Position position)
        {
            switch(position)
            {
                case Position.QB:
                    CreateQB();
                    break;
                case Position.HB:
                    //hb creation method
                    break;
                case Position.FB:
                    //fb creation method
                    break;
                case Position.TE:
                    //te creation method
                    break;
                case Position.WR:
                    //wr creation method 
                    break;
                case Position.LT:
                case Position.LG:
                case Position.C:
                case Position.RG:
                case Position.RT:
                    //ol creation method
                    break;
                case Position.LE:
                case Position.RE:
                    //de creation method
                    break;
                case Position.DT:
                    break;
                case Position.ROLB:
                case Position.LOLB:
                    break;
                case Position.MLB:
                    break;
                case Position.CB:
                    break;
                case Position.FS: case Position.SS:
                    break;
                case Position.K:
                    break;
                case Position.P:
                    break;
                    
            }
        }
        public void CreateQB()
        {
            Random rand = new Random();
            Speed = 1;
            Acceleration = 1;
            Strength = rand.Next(99);
            Agility = rand.Next(99);
            Jumping = rand.Next(99);
            Stamina = rand.Next(99);
            Injury = rand.Next(99);
            Tackle = rand.Next(99);
            HitPower = rand.Next(99);
            Pursuit = rand.Next(99);
            PlayRecognition = rand.Next(99);
            ManCoverage = rand.Next(99);
            ZoneCoverage = rand.Next(99);
            Press = rand.Next(99);
            Catching = rand.Next(99);
            CatchInTraffic = rand.Next(99);
            RouteRunning = rand.Next(99);
            Release = rand.Next(99);
            Return = rand.Next(99);
            PowerMoves = rand.Next(99);
            FinesseMoves = rand.Next(99);
            BlockShedding = rand.Next(99);
            BreakTackle = rand.Next(99);
            Trucking = rand.Next(99);
            Elusiveness = rand.Next(99);
            StiffArm = rand.Next(99);
            SpinMove = rand.Next(99);
            JukeMove = rand.Next(99);
            Carrying = rand.Next(99);
            BCVision = rand.Next(99);
            ThrowPower = rand.Next(99);
            ThrowAccuracy = rand.Next(99);
        }
    }
}
