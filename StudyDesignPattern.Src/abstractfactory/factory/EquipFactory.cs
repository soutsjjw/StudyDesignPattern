namespace StudyDesignPattern.Src.abstractfactory.factory;

/// <summary>
/// 裝備工廠介面(Factory)-定義每一間工廠應該生產哪些東西
/// </summary>
public interface EquipFactory
{
    /// <summary>
    /// 製造武器
    /// </summary>
    /// <returns></returns>
    Weapon ProductWeapon();

    /// <summary>
    /// 製造衣服
    /// </summary>
    /// <returns></returns>
    Clothes ProductArmor();
}
