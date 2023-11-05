using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int gradeNumber = int.Parse(grade);
        
        string letter = "";

        if (gradeNumber >= 90)
        {
            letter = "A";
        }

        else if (gradeNumber >= 80)
        {
            letter = "B";
        }

        else if (gradeNumber >= 70)
        {
            letter = "C";
        }

        else if (gradeNumber >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your graded is: {letter}");

        if (gradeNumber >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class.");
        }

        else
        {
            Console.WriteLine("Sorry, you did not pass the class. Better luck next time.");
        }
    }
}