namespace StudyDesignPattern.Src.abstractfactory.village;

/// <summary>
/// 工廠介面-冒險者訓練營(這只是一個概念或規範，要訓練什麼，怎麼訓練留給子類別實作)
/// </summary>
public interface TrainingCamp
{
    /// <summary>
    /// 訓練冒險者的過程，訓練後請給我一個冒險者
    /// </summary>
    /// <returns></returns>
    public Adventurer TrainAdventurer();
}

