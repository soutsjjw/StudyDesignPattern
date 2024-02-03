namespace StudyDesignPattern.Src.decorator.title;

/// <summary>
/// 稱號-強壯(ConcreteDecorator)
/// </summary>
public class TitleStrong : Title
{
    public TitleStrong(Adventurer adventurer) : base(adventurer)
    {
    }

    /// <summary>
    /// 稱號讓攻擊力增加
    /// </summary>
    public override void Attack()
    {
        Console.WriteLine("猛力");
        base.Attack();
    }
}
