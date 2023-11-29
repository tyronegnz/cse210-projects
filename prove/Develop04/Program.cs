using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice: ");
            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            if (choice == 4)
            {
                break;
            }

            Console.Write("Enter duration in seconds: ");
            int duration;
            if (!int.TryParse(Console.ReadLine(), out duration))
            {
                Console.WriteLine("Invalid duration. Please enter a number.");
                continue;
            }

            Activity activity;
            switch (choice)
            {
                case 1:
                    activity = new BreathingActivity(duration);
                    break;
                case 2:
                    activity = new ReflectionActivity(duration);
                    break;
                case 3:
                    activity = new ListingActivity(duration);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    continue;
            }

            activity.Start();
        }
    }
}
