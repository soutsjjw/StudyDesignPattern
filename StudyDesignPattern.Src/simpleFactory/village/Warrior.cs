namespace StudyDesignPattern.Src.simpleFactory.village;

/// <summary>
/// 鬥士
/// </summary>
public class Warrior : Adventurer
{
    string Adventurer.GetType()
    {
        Console.WriteLine("我是鬥士");
        return nameof(Warrior);
    }
}

