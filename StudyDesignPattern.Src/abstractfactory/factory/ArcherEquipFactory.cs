namespace StudyDesignPattern.Src.abstractfactory.factory;

/// <summary>
/// 專門生產弓箭手裝備的工廠(ConcreteFactory)
/// </summary>
public class ArcherEquipFactory : EquipFactory
{
    public Weapon ProductWeapon()
    {
        Bow product = new Bow();
        product.Atk = 10;
        product.Range = 10;
        return product;
    }

    public Clothes ProductArmor()
    {
        Leather product = new Leather();
        product.Def = 5;
        return product;
    }
}
