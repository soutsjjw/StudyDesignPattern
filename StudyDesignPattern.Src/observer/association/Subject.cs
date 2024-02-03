namespace StudyDesignPattern.Src.observer.association;

/// <summary>
/// 被觀察者介面
/// </summary>
public abstract class Subject
{
    protected List<Adventurer> list = new List<Adventurer>();

    /// <summary>
    /// 觀察者想被通知
    /// </summary>
    /// <param name="observer"></param>
    public void Add(Adventurer observer)
    {
        list.Add(observer);
    }

    /// <summary>
    /// 觀察者不想接到通知
    /// </summary>
    /// <param name="observer"></param>
    public void Remove(Adventurer observer)
    {
        list.Remove(observer);
    }

    /// <summary>
    /// 貼出任務公告
    /// </summary>
    /// <param name="questions"></param>
    public abstract void SendQuestions(string questions);
}

