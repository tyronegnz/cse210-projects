using System;

namespace Foundation4
{
    public class Running : Activity
    {
        private double distance;

        public Running(DateTime date, int lengthMinutes, double distance) : base(date, lengthMinutes)
        {
            this.distance = distance;
        }

        public override double GetDistance()
        {
            return distance;
        }

        public override double GetSpeed()
        {
            return distance / (base.lengthMinutes / 60.0);
        }

        public override double GetPace()
        {
            return base.lengthMinutes / distance;
        }

        public override string GetSummary()
        {
            return $"{base.GetSummary()} - Distance: {distance} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
        }
    }

}
