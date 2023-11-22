namespace SliceOfFun
{
    abstract class Equipment
    {
        public string Name { get; private set; }

        protected Equipment(string name)
        {
            Name = name;
        }
    }

    class DoughMixer : Equipment
    {
        public DoughMixer() : base("Dough Mixer") { }

    }

}
