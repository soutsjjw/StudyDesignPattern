namespace StudyDesignPattern.Src.strategy.flight;

/// <summary>
/// 使用技能(ConcreteStrategy)
/// </summary>
public class UseSkill : FlightStrategy
{
    public void Execute()
    {
        Console.WriteLine("使用超級痛的技能攻擊");
    }
}
