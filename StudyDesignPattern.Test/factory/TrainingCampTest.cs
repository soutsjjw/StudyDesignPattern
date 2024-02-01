using StudyDesignPattern.Src.factory.village;

namespace StudyDesignPattern.Test.factory;

public class TrainingCampTest
{
    [Test]
    [Category("工廠模式")]
    public void Test()
    {
        Console.WriteLine("==========工廠模式測試==========");

        //訓練營訓練冒險者
        //先用弓箭手訓練營訓練弓箭手
        TrainingCamp trainingCamp = new ArcherTrainingCamp();
        Adventurer memberA = trainingCamp.TrainAdventurer();

        //用鬥士訓練營訓練鬥士
        trainingCamp = new WarriorTrainingCamp();
        Adventurer memberB = trainingCamp.TrainAdventurer();

        //看看是不是真的訓練出我們想要的冒險者
        Assert.That(memberA.GetType(), Is.EqualTo("Archer"));
        Assert.That(memberB.GetType(), Is.EqualTo("Warrior"));
    }
}

