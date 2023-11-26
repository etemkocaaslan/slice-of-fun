namespace SliceOfFun
{
    abstract class RawMaterial
    {
        protected RawMaterial(string? type)
        {
            Type = type ?? throw new ArgumentNullException(nameof(type));
        }

        protected string? Type { get; private set; }
        public virtual decimal Quantity { get; set; }
        public virtual string? UOM { get; }
    }

    abstract class Vegetable : RawMaterial
    {
        protected Vegetable() : base("Vegetable")
        {
        }
    }

    class Carrot : Vegetable 
    {
        public override decimal Quantity { get => base.Quantity; set => base.Quantity = value; }
        public Carrot()
        {

        }
    }
    class Tomato : Vegetable { }
}
