namespace StudyDesignPattern.Src.abstractfactory.village;

/// <summary>
/// 弓箭手
/// </summary>
public class Archer : Adventurer
{
    public override void Display()
    {
        Console.WriteLine("我是弓箭手，裝備:");
        Weapon?.Display();
        Clothes?.Display();
        Console.WriteLine();
    }
}

