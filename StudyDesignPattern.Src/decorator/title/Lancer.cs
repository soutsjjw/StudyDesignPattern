namespace StudyDesignPattern.Src.decorator.title;

/// <summary>
/// 長槍兵(ConcreteComponent)
/// </summary>
public class Lancer : Adventurer
{
    /// <summary>
    /// 冒險者的姓名
    /// </summary>
    private string Name { get; set; }

    /// <summary>
    /// 冒險者被創立的時候要有姓名
    /// </summary>
    /// <param name="name"></param>
    public Lancer(string name)
    {
        Name = name;
    }

    /// <summary>
    /// 攻擊
    /// </summary>
    public void Attack()
    {
        Console.WriteLine($"長槍攻擊 by {Name}");
    }
}

