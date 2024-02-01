using StudyDesignPattern.Src.abstractfactory.factory;

namespace StudyDesignPattern.Src.abstractfactory.village;

/// <summary>
/// 冒險者
/// </summary>
public abstract class Adventurer
{
    /// <summary>
    /// 武器
    /// </summary>
    public Weapon? Weapon { get; set; }

    /// <summary>
    /// 衣服
    /// </summary>
    public Clothes? Clothes { get; set; }

    /// <summary>
    /// 看冒險者的狀態
    /// </summary>
    public abstract void Display();
}

