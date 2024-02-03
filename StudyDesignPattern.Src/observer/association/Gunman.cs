namespace StudyDesignPattern.Src.observer.association;

/// <summary>
/// 槍手(Concrete Observer)-繼承冒險者
/// </summary>
public class Gunman : Adventurer
{
    public Gunman(string name) : base(name)
    {
    }

    public override void GetQuestions(string questions)
    {
        if (questions.Length < 10)
        {
            Console.WriteLine($"{base.Name}:任務太簡單了，我不想理他");
        }
        else
        {
            Console.WriteLine($"{base.Name}:只要我的手上有槍，誰都殺不死我，出發執行任務賺獎金拉!!!");
        }
    }
}

