using System.Collections.Immutable;

namespace SliceOfFun
{
    public class Provider
    {
        internal Dictionary<Product, decimal> Products { get; } = new Dictionary<Product, decimal>();
        public List<Product> Catalog { get => catalog; protected set => catalog = value; }

        List<Product> catalog = new() { };

        public Provider()
        {
            Catalog = new List<Product>(new Product[] {
                new Product(Product.RawMaterial.GroundBeef, Product.RawMaterialType.Meat),
                new Product(Product.RawMaterial.Pepperoni, Product.RawMaterialType.Meat),
                new Product(Product.RawMaterial.Chorizo, Product.RawMaterialType.Meat),
                new Product(Product.RawMaterial.ItalianSuasage, Product.RawMaterialType.Meat),
                new Product(Product.RawMaterial.Ham, Product.RawMaterialType.Meat),
                new Product(Product.RawMaterial.Capocollo, Product.RawMaterialType.Meat),
                new Product(Product.RawMaterial.PulledPork, Product.RawMaterialType.Meat),
                new Product(Product.RawMaterial.Steak, Product.RawMaterialType.Meat),
                new Product(Product.RawMaterial.Chicken, Product.RawMaterialType.Meat),
                new Product(Product.RawMaterial.Bacon, Product.RawMaterialType.Meat),
                new Product(Product.RawMaterial.GreenOlive, Product.RawMaterialType.Vegetable),
                new Product(Product.RawMaterial.BlackOlive, Product.RawMaterialType.Vegetable),
                new Product(Product.RawMaterial.Eggplant, Product.RawMaterialType.Vegetable),
                new Product(Product.RawMaterial.Artichoke, Product.RawMaterialType.Vegetable),
                new Product(Product.RawMaterial.Pineapple, Product.RawMaterialType.Vegetable),
                new Product(Product.RawMaterial.RedPepper, Product.RawMaterialType.Vegetable),
                new Product(Product.RawMaterial.GreenPepper, Product.RawMaterialType.Vegetable),
                new Product(Product.RawMaterial.Tomato, Product.RawMaterialType.Vegetable),
                new Product(Product.RawMaterial.Spinach, Product.RawMaterialType.Vegetable),
                new Product(Product.RawMaterial.Mushroom, Product.RawMaterialType.Vegetable)
            });
        }

        void Refill()
        {
            foreach (Product product in Catalog)
                Products.Add(product, 200);
        }

        public void Refill(string request)
        {
            if (!string.IsNullOrEmpty(request))
                Refill();
            else
                throw new ArgumentException($"'{nameof(request)}' cannot be null or empty.", nameof(request));
        }

        public string IsProductAvailable(Product product, decimal quantity)
        {
            return (Products.ContainsKey(product) && Products[product] >= quantity) ? $"Provider has enough of {product.RM}" : $"Not Enough {product.RM}";
        }

    }

}
