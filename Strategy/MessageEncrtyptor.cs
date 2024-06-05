namespace ConsoleApp1.Strategy;

public class MessageEncrtyptor
{
    private readonly DoubleBase64 second;
    private readonly EncryptionType first;

    public MessageEncrtyptor(DoubleBase64 _second, EncryptionType _first)
    {
        second = _second;
        first = _first;
    }

    public void encriptor()
    {
        first.Encrypt();
        second.DoubleEncrypt();
    }

}