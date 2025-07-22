namespace DesignPatterns.PatternExamples.Structural.Adaptor;

public class Client
{
    private ILogin _login;
    public Client(ILogin adaptor)
    {
        _login = adaptor;
    }

    public void PerformLogin()
    {
        _login.UserName = "JamesBond";
        _login.Password = "007";
        _login.Submit();

        Console.WriteLine("Reply: " + _login.Message);
    }
}
