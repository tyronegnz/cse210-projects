using System;

namespace Foundation4
{

    public class Activity
    {
        protected DateTime date;
        protected int lengthMinutes;

        public Activity(DateTime date, int lengthMinutes)
        {
            this.date = date;
            this.lengthMinutes = lengthMinutes;
        }

        public virtual double GetDistance()
        {
            return 0; // Placeholder for base class, overridden in derived classes
        }

        public virtual double GetSpeed()
        {
            return 0; // Placeholder for base class, overridden in derived classes
        }

        public virtual double GetPace()
        {
            return 0; // Placeholder for base class, overridden in derived classes
        }

        public virtual string GetSummary()
        {
            return $"{date.ToShortDateString()} ({lengthMinutes} min)";
        }
    }

}

