using System.Runtime.Serialization;
namespace SliceOfFun
{
    public abstract class RawMaterial
    {
        public RawMaterial(Product.RawMaterialType rawMaterialType)
        {
            RawMaterialType = rawMaterialType;
        }

        protected Product.RawMaterialType? RawMaterialType { get; private set; }
        public virtual decimal Quantity { get; set; }
        public virtual string? UOM { get; }
    }

    partial class Vegetable : RawMaterial
    {
        protected Product.RawMaterial? RawMaterial { get; private set; }

        public Vegetable(Product.RawMaterial rawMaterial) : base(Product.RawMaterialType.Vegetable)
        {
            RawMaterial = rawMaterial;
        }
    }

    partial class Meat : RawMaterial
    {
        protected Product.RawMaterial? RawMaterial { get; private set; }

        public Meat(Product.RawMaterial rawMaterial) : base(Product.RawMaterialType.Meat)
        {
            RawMaterial = rawMaterial;
        }
    }

}
