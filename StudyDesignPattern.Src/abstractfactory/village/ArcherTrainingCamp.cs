using StudyDesignPattern.Src.abstractfactory.factory;

namespace StudyDesignPattern.Src.abstractfactory.village;

/// <summary>
/// 實體工廠-弓箭手訓練營
/// </summary>
public class ArcherTrainingCamp : TrainingCamp
{
    private EquipFactory factory = new ArcherEquipFactory();

    public Adventurer TrainAdventurer()
    {
        Archer archer = new Archer();
        // ...進行基本訓練
        // ...弓箭手訓練課程
        // 訓練完成配發裝備
        archer.Weapon = factory.ProductWeapon();
        archer.Clothes = factory.ProductArmor();
        return archer;
    }
}

