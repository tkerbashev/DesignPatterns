namespace DesignPatterns.PatternExamples.Behavioural.Mediator;

public interface IBank
{
    void Register(BankClient client);
    void Pay(BankClient payer, BankClient receiver, decimal amount);
}
