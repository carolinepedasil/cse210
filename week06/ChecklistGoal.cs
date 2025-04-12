public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        Console.WriteLine($"Progress! You earned {_points} points!");

        if (_amountCompleted == _target)
        {
            Console.WriteLine($"Bonus! You completed the checklist and earned {_bonus} bonus points!");
        }
    }

    public override bool IsComplete() => _amountCompleted >= _target;

    public int GetBonus() => _bonus;
    public int GetAmountCompleted() => _amountCompleted;
    public void SetAmountCompleted(int amount) => _amountCompleted = amount;

    public override string GetDetailsString() =>
        $"[{(_amountCompleted >= _target ? "X" : " ")}] {_shortName} ({_description}) -- Completed {_amountCompleted}/{_target}";

    public override string GetStringRepresentation() =>
        $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
}
