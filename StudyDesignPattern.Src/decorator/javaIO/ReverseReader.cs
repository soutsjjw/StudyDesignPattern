namespace StudyDesignPattern.Src.decorator.javaIO;


public class ReverseReader : StreamReader
{
    public ReverseReader(StreamReader reader) : base(reader.BaseStream)
    {
    }

    public string ReverseLine()
    {
        string line = base.ReadLine();
        if (line != null)
        {
            char[] charArray = line.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        else
        {
            return null;
        }
    }
}
