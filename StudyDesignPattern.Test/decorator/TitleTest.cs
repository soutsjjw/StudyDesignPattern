using StudyDesignPattern.Src.decorator.title;

namespace StudyDesignPattern.Test.decorator;

/// <summary>
/// 裝飾者模式-測試
/// </summary>
public class TitleTest
{
    [Test]
    [Category("裝飾者模式")]
    public void Test()
    {
        Console.WriteLine("============裝飾者模式測試============");

        // 一開始沒有任何稱號的冒險者
        Adventurer lancer = new Lancer("Jacky");
        Console.WriteLine("---長槍兵Jacky---");
        lancer.Attack();

        Console.WriteLine();
        Console.WriteLine("---取得強壯稱號的jacky---");
        TitleStrong sJacky = new TitleStrong(lancer);
        sJacky.Attack();


        Console.WriteLine();
        Console.WriteLine("---取得敏捷稱號的jacky---");
        TitleAgile aJacky = new TitleAgile(sJacky);
        aJacky.Attack();
        aJacky.UseFlash();

        Console.WriteLine();
        Console.WriteLine("---取得燃燒稱號的jacky---");
        TitleInFire fJacky = new TitleInFire(sJacky);
        fJacky.Attack();
        fJacky.Fireball();

        Console.WriteLine("---jacky決定成為一個非常強壯的槍兵---");
        TitleStrong ssJacky = new TitleStrong(fJacky);
        ssJacky.Attack();

        Assert.Pass();
    }
}

