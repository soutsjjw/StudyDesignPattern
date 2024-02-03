namespace StudyDesignPattern.Src.observer.association;

/// <summary>
/// 槍兵(Concrete Observer)-繼承冒險者
/// </summary>
public class Lancer : Adventurer
{
    public Lancer(string name) : base(name)
    {
    }

    public override void GetQuestions(string questions)
    {
        Console.WriteLine($"{base.Name}:單來就改，任務來就接，沒在怕的");
    }
}

