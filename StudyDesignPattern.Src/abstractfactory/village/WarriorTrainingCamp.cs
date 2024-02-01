using StudyDesignPattern.Src.abstractfactory.factory;

namespace StudyDesignPattern.Src.abstractfactory.village;

/// <summary>
/// 實體工廠-鬥士訓練營
/// </summary>
public class WarriorTrainingCamp : TrainingCamp
{
    private EquipFactory factory = new WarriorEquipFactory();

    public Adventurer TrainAdventurer()
    {
        Warrior warrior = new Warrior();
        // ...進行基本訓練
        // ...鬥士訓練課程
        // 訓練完成配發裝備
        warrior.Weapon = factory.ProductWeapon();
        warrior.Clothes = factory.ProductArmor();
        return warrior;
    }
}

