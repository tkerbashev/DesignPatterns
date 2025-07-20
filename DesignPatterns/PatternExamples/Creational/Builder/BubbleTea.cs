namespace DesignPatterns.PatternExamples.Creational.Builder
{
    public class BubbleTea
    {
        private readonly List<string> _features = new();

        public void Describe()
        {
            foreach (var iFeature in _features) 
            {
                Console.WriteLine("   " + iFeature);
            }
        }

        public void AddFeature(string feature)
        {
            _features.Add(feature);
        }
    }
}
