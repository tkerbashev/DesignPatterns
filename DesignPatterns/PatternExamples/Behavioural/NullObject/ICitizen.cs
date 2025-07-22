namespace DesignPatterns.PatternExamples.Behavioural.NullObject;

internal interface ICitizen
{
    string Name { get; }
    IParty PreferredParty { get; }
    void Declare();
}
