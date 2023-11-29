using System;
using System.Threading;

abstract class Activity
{
    protected int durationInSeconds;

    protected Activity(int duration)
    {
        durationInSeconds = duration;
    }

    public abstract void Start();

    protected void DisplayMessageWithDelay(string message, int delayInSeconds)
    {
        Console.WriteLine(message);
        Thread.Sleep(delayInSeconds * 1000);
    }

    protected void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
