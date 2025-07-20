namespace DesignPatterns.PatternExamples.Structural.Adaptor;

public interface ILogin
{
    string UserName { get; set; }
    string Password { get; set; }
    string Message { get; }
    public void Submit( );
}
