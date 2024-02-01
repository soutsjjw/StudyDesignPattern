namespace StudyDesignPattern.Src.strategy.flight;

/// <summary>
/// 冒險者(Context)
/// </summary>
public class Adventurer
{
    FlightStrategy? flightStrategy;

    /// <summary>
    /// 攻擊
    /// </summary>
    public void Attack()
    {
        // 預設為普通攻擊
        if (flightStrategy == null)
        {
            flightStrategy = new NormalAttack();
        }
        flightStrategy.Execute();
    }

    /// <summary>
    /// 選擇不同的武器(策略)
    /// </summary>
    /// <param name="strategy"></param>
    public void ChoiceStrategy(FlightStrategy strategy)
    {
        this.flightStrategy = strategy;
    }
}
