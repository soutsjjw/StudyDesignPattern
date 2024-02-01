using StudyDesignPattern.Src.abstractfactory.factory;
using StudyDesignPattern.Src.abstractfactory.village;

namespace StudyDesignPattern.Test.abstractfactory;

/// <summary>
/// 測試工廠是否能正確生產裝備
/// </summary>
public class EquipFactoryTest
{
    [Test]
    [Category("抽象工廠模式")]
    public void Test()
    {
        Console.WriteLine("==========抽象工廠模式測試==========");

        // 幫弓箭手生產裝備
        EquipFactory equipFactory = new ArcherEquipFactory();
        Clothes archerLeather = equipFactory.ProductArmor();
        Weapon archerBow = equipFactory.ProductWeapon();

        // 皮甲的防禦應該是5，弓的攻擊為10，範圍為10
        Assert.That(archerLeather.Def, Is.EqualTo(5));
        Assert.That(archerBow.Atk, Is.EqualTo(10));
        Assert.That(archerBow.Range, Is.EqualTo(10));

        // 幫鬥士生產裝備
        equipFactory = new WarriorEquipFactory();
        Clothes armor = equipFactory.ProductArmor();
        Weapon longSword = equipFactory.ProductWeapon();

        // 盔甲的防禦應該是10，弓的攻擊為10，範圍為1
        Assert.That(armor.Def, Is.EqualTo(10));
        Assert.That(longSword.Atk, Is.EqualTo(10));
        Assert.That(longSword.Range, Is.EqualTo(1));


        // 弓箭手訓練營
        TrainingCamp camp = new ArcherTrainingCamp();
        // 訓練弓箭手
        Adventurer archer = camp.TrainAdventurer();

        // 鬥士訓練營
        camp = new WarriorTrainingCamp();
        // 訓練鬥士
        Adventurer warrior = camp.TrainAdventurer();

        archer.Display();
        warrior.Display();
    }
}

