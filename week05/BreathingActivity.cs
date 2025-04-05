using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base(
        "Breathing Activity",
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public override void Run()
    {
        StartMessage();
        int cycleTime = 6;
        int cycles = _duration / cycleTime;

        for (int i = 0; i < cycles; i++)
        {
            Console.Write("Breathe in... ");
            Countdown(3);
            Console.WriteLine();

            Console.Write("Breathe out... ");
            Countdown(3);
            Console.WriteLine();
        }

        EndMessage();
    }
}
