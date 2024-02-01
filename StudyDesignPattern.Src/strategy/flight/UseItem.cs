namespace StudyDesignPattern.Src.strategy.flight;

/// <summary>
/// 使用道具(ConcreteStrategy)
/// </summary>
public class UseItem : FlightStrategy
{
    public void Execute()
    {
        Console.WriteLine("使用道具，丟火把");
    }
}
