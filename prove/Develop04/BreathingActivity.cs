using System;

class BreathingActivity : Activity
{
    public BreathingActivity(int duration) : base(duration) { }

    public override void Start()
    {
        DisplayMessageWithDelay("Breathing Activity - This activity will help you relax by guiding you through deep breathing. Clear your mind and focus on your breath.", 2);
        DisplayMessageWithDelay($"Get ready to breathe deeply for {durationInSeconds} seconds.", 2);

        int halfDuration = durationInSeconds / 2;
        for (int i = 0; i < halfDuration; i++)
        {
            DisplayMessageWithDelay("Breathe in...", 1);
            ShowCountdown(3);

            DisplayMessageWithDelay("Breathe out...", 1);
            ShowCountdown(3);
        }

        DisplayMessageWithDelay($"You've completed the Breathing Activity for {durationInSeconds} seconds. Good job!", 2);
    }
}
