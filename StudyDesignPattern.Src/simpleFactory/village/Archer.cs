namespace StudyDesignPattern.Src.simpleFactory.village;

/// <summary>
/// 弓箭手
/// </summary>
public class Archer : Adventurer
{
    string Adventurer.GetType()
    {
        Console.WriteLine("我是弓箭手");
        return nameof(Archer);
    }
}

