namespace StudyDesignPattern.Src.decorator.title;

/// <summary>
/// 稱號-敏捷 (ConcreteDecorator)
/// </summary>
public class TitleAgile : Title
{
    public TitleAgile(Adventurer adventurer) : base(adventurer)
    {
    }

    /// <summary>
    /// 稱號讓攻擊變快
    /// </summary>
    public override void Attack()
    {
        Console.WriteLine("快速");
        base.Attack();
    }

    /// <summary>
    /// 取得稱號後獲得新的技能
    /// </summary>
    public void UseFlash()
    {
        Console.WriteLine("使用瞬間移動");
    }
}