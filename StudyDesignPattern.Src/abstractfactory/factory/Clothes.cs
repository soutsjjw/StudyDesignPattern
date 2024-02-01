namespace StudyDesignPattern.Src.abstractfactory.factory;

/// <summary>
/// 上衣介面(Product)
/// </summary>
public abstract class Clothes
{
    /// <summary>
    /// 防禦力
    /// </summary>
    public int Def { get; set; }

    /// <summary>
    /// 展示這件衣服
    /// </summary>
    public void Display()
    {
        Console.WriteLine($"{GetType().Name} def: {Def}");
    }
}

