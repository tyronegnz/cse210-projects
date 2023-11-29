using System;

class ReflectionActivity : Activity
{
    private string[] prompts = {
        // Reflection prompts
    };

    private string[] reflectionQuestions = {
        // Reflection questions
    };

    public ReflectionActivity(int duration) : base(duration) { }

    public override void Start()
    {
        DisplayMessageWithDelay("Reflection Activity - This activity will help you reflect on times when you've shown strength and resilience.", 2);
        DisplayMessageWithDelay($"Get ready to reflect for {durationInSeconds} seconds.", 2);

        Random random = new Random();
        int index = random.Next(prompts.Length);
        DisplayMessageWithDelay(prompts[index], 2);

        int questionIndex = 0;
        while (durationInSeconds > 0)
        {
            DisplayMessageWithDelay(reflectionQuestions[questionIndex % reflectionQuestions.Length], 2);
            Thread.Sleep(3 * 1000); // Pause for reflection

            durationInSeconds -= 5; // Time for each question
            questionIndex++;
        }

        DisplayMessageWithDelay($"You've completed the Reflection Activity for {durationInSeconds} seconds. Good job!", 2);
    }
}
