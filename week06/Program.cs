using System;
using System.Collections.Generic;

// EXTRA CREDIT: Added a LEVEL UP system!
// The player levels up every 1000 points and gets a celebration message.
// Level is saved/loaded with the score.

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}
