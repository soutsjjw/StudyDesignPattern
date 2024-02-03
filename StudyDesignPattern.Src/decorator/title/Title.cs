namespace StudyDesignPattern.Src.decorator.title;

/// <summary>
/// 稱號介面(Decorator)
/// </summary>
public abstract class Title : Adventurer
{
    // 被裝飾的冒險者(Component)
    protected Adventurer adventurer;

    public Title(Adventurer adventurer)
    {
        this.adventurer = adventurer;
    }

    public virtual void Attack()
    {
        adventurer.Attack();
    }
}
