namespace StudyDesignPattern.Src.decorator.javaIO;

public class UpperCaseStream : Stream
{
    private readonly Stream _innerStream;

    public UpperCaseStream(Stream innerStream)
    {
        _innerStream = innerStream;
    }

    public override int Read(byte[] buffer, int offset, int count)
    {
        int bytesRead = _innerStream.Read(buffer, offset, count);

        for (int i = offset; i < offset + bytesRead; i++)
        {
            buffer[i] = (byte)char.ToUpper((char)buffer[i]);
        }

        return bytesRead;
    }

    public override void Flush()
    {
        throw new NotImplementedException();
    }

    public override long Seek(long offset, SeekOrigin origin)
    {
        throw new NotImplementedException();
    }

    public override void SetLength(long value)
    {
        throw new NotImplementedException();
    }

    public override void Write(byte[] buffer, int offset, int count)
    {
        throw new NotImplementedException();
    }

    // Implement other Stream members as needed...

    public override bool CanRead => _innerStream.CanRead;
    public override bool CanSeek => _innerStream.CanSeek;
    public override bool CanWrite => _innerStream.CanWrite;
    public override long Length => _innerStream.Length;

    public override long Position
    {
        get => _innerStream.Position;
        set => _innerStream.Position = value;
    }

    // Implement other Stream members as needed...
}