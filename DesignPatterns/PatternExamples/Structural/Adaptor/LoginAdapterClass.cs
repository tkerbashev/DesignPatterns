namespace DesignPatterns.PatternExamples.Structural.Adaptor;

public class LoginAdaptorClass : LegacyClass, ILogin
{
    public string UserName { get => Text1; set => Text1 = value; }
    public string Password { get => Text2; set => Text2 = value; }
    public string Message => Text3;

    public new void Submit()
    {
        base.Submit();
        Console.WriteLine( "Submitting using the class Adaptor version. Username: " + UserName + ", Password: " + Password );
    }
}
