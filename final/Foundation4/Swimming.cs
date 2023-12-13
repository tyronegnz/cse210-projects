using System;

namespace Foundation4
{

    public class Swimming : Activity
    {
        private int laps;

        public Swimming(DateTime date, int lengthMinutes, int laps) : base(date, lengthMinutes)
        {
            this.laps = laps;
        }

        public override double GetDistance()
        {
            return laps * 50 / 1000 * 0.62; // Convert laps to miles
        }

        public override double GetSpeed()
        {
            return GetDistance() / (base.lengthMinutes / 60.0);
        }

        public override double GetPace()
        {
            return base.lengthMinutes / GetDistance();
        }

        public override string GetSummary()
        {
            return $"{base.GetSummary()} - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
        }
    }

}
