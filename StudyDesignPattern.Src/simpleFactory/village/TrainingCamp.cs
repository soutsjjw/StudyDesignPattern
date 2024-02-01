namespace StudyDesignPattern.Src.simpleFactory.village;

/// <summary>
/// 冒險者訓練營
/// </summary>
public class TrainingCamp
{
    public static Adventurer TrainAdventurer(string type)
    {
        switch (type)
        {
            case "archer":
                Console.WriteLine("訓練一個弓箭手");
                return new Archer();
            case "warrior":
                Console.WriteLine("訓練一個鬥士");
                return new Warrior();
            // 假如冒險者種類新增，增加case就可以
            default:
                return null;
        }
    }
}

