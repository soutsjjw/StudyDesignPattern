namespace StudyDesignPattern.Src.factory.village;

/// <summary>
/// 鬥士訓練營
/// </summary>
public class WarriorTrainingCamp : TrainingCamp
{
    public Adventurer TrainAdventurer()
    {
        Console.WriteLine("訓練一個鬥士");
        return new Warrior();
    }
}

