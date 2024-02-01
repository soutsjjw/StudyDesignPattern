namespace StudyDesignPattern.Src.abstractfactory.village;

/// <summary>
/// 鬥士
/// </summary>
public class Warrior : Adventurer
{
    public override void Display()
    {
        Console.WriteLine("我是鬥士，裝備:");
        Weapon?.Display();
        Clothes?.Display();
        Console.WriteLine();
    }
}

