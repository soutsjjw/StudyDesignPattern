namespace StudyDesignPattern.Src.decorator.title;

/// <summary>
/// 稱號-敏捷 (ConcreteDecorator)
/// </summary>
public class TitleInFire : Title
{
    public TitleInFire(Adventurer adventurer) : base(adventurer)
    {
    }

    /// <summary>
    /// 稱號讓攻擊增加燃燒
    /// </summary>
    public override void Attack()
    {
        Console.WriteLine("快速");
        base.Attack();
    }

    public void Fireball()
    {
        Console.WriteLine("丟火球");
    }
}
