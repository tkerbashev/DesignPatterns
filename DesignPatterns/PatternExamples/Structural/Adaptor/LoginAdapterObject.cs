namespace DesignPatterns.PatternExamples.Structural.Adaptor;

public class LoginAdaptorObject : ILogin
{
    private LegacyClass _legacyClass;

    public LoginAdaptorObject(LegacyClass legacyClass)
    {
        _legacyClass = legacyClass;
    }

    public string UserName { get => _legacyClass.Text1; set => _legacyClass.Text1 = value; }
    public string Password { get => _legacyClass.Text2; set => _legacyClass.Text2 = value; }
    public string Message => _legacyClass.Text3;

    public void Submit( )
    {
        _legacyClass.Submit();
        Console.WriteLine("Submitting using the object Adaptor version. Username: " + UserName + ", Password: " + Password);
    }
}
