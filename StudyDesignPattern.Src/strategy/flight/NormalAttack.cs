namespace StudyDesignPattern.Src.strategy.flight;

/// <summary>
/// 一般攻擊(ConcreteStrategy)
/// </summary>
public class NormalAttack : FlightStrategy
{
    public void Execute()
    {
        Console.WriteLine("使用一般攻擊");
    }
}
