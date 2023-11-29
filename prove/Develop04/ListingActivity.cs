using System;

class ListingActivity : Activity
{
    private string[] listingPrompts = {
        // Listing prompts
    };

    public ListingActivity(int duration) : base(duration) { }

    public override void Start()
    {
        DisplayMessageWithDelay("Listing Activity - This activity will help you reflect on the good things in your life.", 2);
        DisplayMessageWithDelay($"Get ready to list items for {durationInSeconds} seconds.", 2);

        Random random = new Random();
        int index = random.Next(listingPrompts.Length);
        DisplayMessageWithDelay(listingPrompts[index], 2);

        Thread.Sleep(durationInSeconds * 1000); // Wait for the specified duration


        DisplayMessageWithDelay($"You've completed the Listing Activity for {durationInSeconds} seconds. Good job!", 2);
    }
}
