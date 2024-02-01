using StudyDesignPattern.Src.simpleFactory.village;

namespace StudyDesignPattern.Test.simpleFactory;

public class TrainingCampTest
{
    [Test]
    [Category("簡單工廠模式")]
    public void Test()
    {
        Console.WriteLine("==========簡單工廠模式測試==========");

        //訓練營訓練冒險者
        Adventurer memberA = TrainingCamp.TrainAdventurer("archer");
        Adventurer memberB = TrainingCamp.TrainAdventurer("warrior");

        //看看是不是真的訓練出我們想要的冒險者
        Assert.That(memberA.GetType(), Is.EqualTo("Archer"));
        Assert.That(memberB.GetType(), Is.EqualTo("Warrior"));
    }
}