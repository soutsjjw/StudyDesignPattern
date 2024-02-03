using StudyDesignPattern.Src.observer.association;

namespace StudyDesignPattern.Test.observer;

public class AssociationTest
{
    [Test]
    [Category("觀察者模式")]
    public void Test()
    {
        Console.WriteLine("============觀察者模式測試============");

        // 冒險者們
        Adventurer lancer = new Lancer("jacky");
        Adventurer lancer2 = new Lancer("seven");
        Adventurer bard = new Bard("lee");
        Adventurer gunman = new Gunman("longWu");

        // 冒險者協會
        Subject association = new Association();
        association.Add(lancer);
        association.Add(lancer2);
        association.Add(bard);
        association.Add(gunman);

        Console.WriteLine("---派送簡單任務---");
        association.SendQuestions("run");

        Console.WriteLine();
        Console.WriteLine("---派送複雜任務---");
        association.SendQuestions("run run run, run for your life");

        // seven表示他不想接到任務通知了
        association.Remove(lancer2);
        Console.WriteLine();
        Console.WriteLine("---派送複雜任務(seven已經不在名單中)---");
        association.SendQuestions("run run run, run for your life");

        Assert.Pass();
    }
}

