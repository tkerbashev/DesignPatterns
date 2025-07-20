namespace DesignPatterns.PatternExamples.Creational.Singleton
{
    internal class Scene
    {
        public Scene(int nBadGuys)
        {
            BadGuys = new IFighter[nBadGuys];
            var rnd = new Random();
            for (int iFighter = 0; iFighter < nBadGuys; iFighter++) 
            {
                BadGuys[iFighter] = new BadGuy(rnd);
            }
        }

        public IFighter[] BadGuys { get; }
        public IFighter Chuck { get; } = ChuckNorris.Instance;
    }
}
