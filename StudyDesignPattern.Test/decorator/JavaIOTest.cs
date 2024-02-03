using StudyDesignPattern.Src.decorator.javaIO;

namespace StudyDesignPattern.Test.decorator;

/// <summary>
/// 裝飾模式實例javaIO-測試
/// </summary>
public class JavaIOTest
{
    [Test]
    [Category("裝飾者模式")]
    public void Test()
    {
        Console.WriteLine("=========FileReader讀取檔案==========");
        using (StreamReader reader = new StreamReader("decorator/test.txt"))
        {
            int c = reader.Read();
            while (c >= 0)
            {
                Console.Write((char)c);
                c = reader.Read();
            }
        }

        Console.WriteLine("=========BufferedReader讀取檔案==========");
        using (StreamReader bufferedReader = new StreamReader("decorator/test.txt"))
        {
            string line = bufferedReader.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                line = bufferedReader.ReadLine();
            }
        }

        Console.WriteLine("=========Reverse Reader反轉讀入的內容==========");
        // 測試反轉讀入的句子
        using (ReverseReader reverseReader = new ReverseReader(new StreamReader("decorator/test.txt")))
        {
            string rLine = reverseReader.ReverseLine();
            while (rLine != null)
            {
                Console.WriteLine(rLine);
                rLine = reverseReader.ReverseLine();
            }
        }
    }
}

