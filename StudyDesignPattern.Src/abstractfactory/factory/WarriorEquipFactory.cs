namespace StudyDesignPattern.Src.abstractfactory.factory;

/// <summary>
/// 專門生產鬥士裝備的工廠(ConcreteFactory)
/// </summary>
public class WarriorEquipFactory : EquipFactory
{
    public Weapon ProductWeapon()
    {
        LongSword product = new LongSword();
        product.Atk = 10;
        product.Range = 1;
        return product;
    }

    public Clothes ProductArmor()
    {
        Armor product = new Armor();
        product.Def = 10;
        return product;
    }
}
