using StudyDesignPattern.Src.strategy.flight;

namespace StudyDesignPattern.Test.strategy;

/// <summary>
/// 策略模式-測試
/// </summary>
public class FlightTest
{
    [Test]
    [Category("策略模式")]
    public void Test()
    {
        Adventurer adventurer = new Adventurer();

        // 史萊姆用一般攻擊就可以
        Console.WriteLine("出現史萊姆 >");
        adventurer.ChoiceStrategy(new NormalAttack());
        adventurer.Attack();
        Console.WriteLine();

        // 厲害的敵人要用厲害的招式打他
        Console.WriteLine("非常非常巨大的史萊姆 >");
        adventurer.ChoiceStrategy(new UseSkill());
        adventurer.Attack();
        Console.WriteLine();

        // 出現不怕刀槍只怕火的敵人，丟道具燒他
        Console.WriteLine("出現不怕刀槍的殭屍 >");
        adventurer.ChoiceStrategy(new UseItem());
        adventurer.Attack();

        Assert.Pass();
    }
}
