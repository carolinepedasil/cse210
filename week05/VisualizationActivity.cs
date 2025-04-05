using System;
using System.Collections.Generic;

public class VisualizationActivity : Activity
{
    private List<string> _visuals = new List<string>
    {
        "You see a gentle stream flowing...",
        "You hear birds chirping calmly...",
        "A warm breeze touches your face...",
        "The sun gently warms your skin...",
        "You feel totally relaxed..."
    };

    public VisualizationActivity() : base(
        "Visualization Activity",
        "This activity will help you mentally visualize a peaceful place and feel calm.")
    {
    }

    public override void Run()
    {
        StartMessage();
        Console.WriteLine("\nPicture a peaceful place... maybe a forest, beach, or temple.");
        ShowSpinner(3);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        int index = 0;

        while (DateTime.Now < endTime)
        {
            Console.WriteLine(_visuals[index % _visuals.Count]);
            ShowSpinner(5);
            index++;
        }

        EndMessage();
    }
}
