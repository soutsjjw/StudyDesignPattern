namespace StudyDesignPattern.Src.observer.association;

/// <summary>
/// 冒險者(Observer)
/// </summary>
public abstract class Adventurer
{
    protected string Name;

    public Adventurer(string name)
    {
        Name = name;
    }

    /// <summary>
    /// 冒險者接受任務
    /// </summary>
    /// <param name="questions"></param>
    public abstract void GetQuestions(string questions);
}

