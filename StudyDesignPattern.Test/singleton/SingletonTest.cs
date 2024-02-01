using StudyDesignPattern.Src.singleton;

namespace StudyDesignPattern.Test.singleton;

public class SingletonTest
{
    [Test]
    [Category("單例模式")]
    public void Test()
    {
        /*
        // In a single thread, s1 and s2 are indeed the same object
        Singleton s1 = Singleton.GetInstance();
        Singleton s2 = Singleton.GetInstance();
        Console.WriteLine($"s1: {s1.GetHashCode()} s2: {s2.GetHashCode()}");
        Console.WriteLine();
        */

        SingletonThread test1 = new SingletonThread("執行序T1");
        SingletonThread test2 = new SingletonThread("執行序T2");

        Thread t1 = new Thread(new ThreadStart(test1.Run));
        Thread t2 = new Thread(new ThreadStart(test2.Run));

        t1.Start();
        t2.Start();

        Assert.Pass();
    }
}

public class SingletonThread
{
    private string myId;

    public SingletonThread(string id)
    {
        myId = id;
    }

    public void Run()
    {
        Singleton singleton = Singleton.GetInstance;
        if (singleton != null)
        {
            Console.WriteLine($"{myId}產生 Singleton: {singleton.GetHashCode()}");
        }
    }
}