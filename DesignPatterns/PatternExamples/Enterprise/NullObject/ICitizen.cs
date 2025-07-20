namespace DesignPatterns.PatternExamples.Enterprise.NullObject;

internal interface ICitizen
{
    string Name { get; }
    IParty PreferredParty { get; }
    void Declare();
}
