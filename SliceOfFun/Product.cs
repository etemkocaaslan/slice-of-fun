namespace SliceOfFun
{
    public readonly struct Product
    {
        private readonly RawMaterial rM;
        private readonly RawMaterialType rMType;

        public Product(RawMaterial rM, RawMaterialType rMType)
        {
            this.rM = rM;
            this.rMType = rMType;
        }

        public readonly RawMaterial RM => rM;
        public readonly RawMaterialType RMType => rMType;
        public readonly string Name { get => rMType.ToString() + "-" + rM.ToString(); }

        public enum RawMaterialType
        {
            Vegetable,
            Meat,
            Sauce,
            Beverage,
            Oil,
            Cheese,
            Flour,
            Cleaning,
            Service
        }
        public enum RawMaterial
        {
            GroundBeef,
            Pepperoni,
            Chorizo,
            ItalianSuasage,
            Ham,
            Capocollo,
            PulledPork,
            Steak,
            Chicken,
            Bacon,
            GreenOlive,
            BlackOlive,
            Eggplant,
            Artichoke,
            Pineapple,
            RedPepper,
            GreenPepper,
            Tomato,
            Spinach,
            Mushroom
        }

        public override string ToString() => Name ?? "";
    }

}
