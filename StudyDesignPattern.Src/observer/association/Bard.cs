namespace StudyDesignPattern.Src.observer.association;

/// <summary>
/// 吟遊詩人(Concrete Observer)-繼承冒險者
/// </summary>
public class Bard : Adventurer
{
    public Bard(string name) : base(name)
    {
    }

    public override void GetQuestions(string questions)
    {
        if (questions.Length > 10)
        {
            Console.WriteLine($"{base.Name}:任務太難了，我只會唱歌跳舞，不接不接");
        }
        else
        {
            Console.WriteLine($"{base.Name}:當街頭藝人太難賺了，偶爾也是要解任務賺點錢的");
        }
    }
}
