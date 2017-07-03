namespace FlameFramework
{
    public abstract class FlameDictionaryBase : IFlameDictionary
    {
        protected FlameDictionaryBase(string[] killText, string[] dieText)
        {
            this.KillText = killText;
            this.DieText = dieText;
        }

        public string[] DieText { get; }

        public string[] KillText { get; }
    }
}