namespace StudyDesignPattern.Src.abstractfactory.factory;

/// <summary>
/// 武器介面(Product)
/// </summary>
public abstract class Weapon
{
    /// <summary>
    /// 攻擊力
    /// </summary>
    public int Atk { get; set; }

    /// <summary>
    /// 攻擊範圍
    /// </summary>
    public int Range { get; set; }

    /// <summary>
    /// 展示武器
    /// </summary>
    public void Display()
    {
        Console.WriteLine($"{GetType().Name} atk: {Atk} range: {Range}");
    }
}

