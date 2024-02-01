namespace StudyDesignPattern.Src.factory.village;

/// <summary>
/// 弓箭手訓練營
/// </summary>
public class ArcherTrainingCamp : TrainingCamp
{
    public Adventurer TrainAdventurer()
    {
        Console.WriteLine("訓練一個弓箭手");
        return new Archer();
    }
}

