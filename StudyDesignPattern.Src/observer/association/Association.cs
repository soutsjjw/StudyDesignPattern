namespace StudyDesignPattern.Src.observer.association;

/// <summary>
/// 冒險者協會(ConcreteSubject)
/// </summary>
public class Association : Subject
{
    public override void SendQuestions(string questions)
    {
        foreach(Adventurer adventurer in list)
        {
            adventurer.GetQuestions(questions);
        }
    }
}

