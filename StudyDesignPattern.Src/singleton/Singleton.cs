namespace StudyDesignPattern.Src.singleton;

public class Singleton
{
    private static readonly Lazy<Singleton> lazyInstance = new Lazy<Singleton>(() => new Singleton());

    private Singleton() { }

    public static Singleton GetInstance
    {
        get { return lazyInstance.Value; }
    }
}

