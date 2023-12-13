using System;
using System.Collections.Generic;

namespace Foundation4
{
    class Program
    {
        static void Main()
        {
            List<Activity> activities = new List<Activity>();

            activities.Add(new Running(new DateTime(2023, 11, 3), 30, 3.0));
            activities.Add(new Running(new DateTime(2023, 11, 3), 30, 4.8));
            activities.Add(new Cycling(new DateTime(2023, 11, 5), 45, 15.0));
            activities.Add(new Swimming(new DateTime(2023, 11, 6), 40, 20));

            foreach (var activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}
