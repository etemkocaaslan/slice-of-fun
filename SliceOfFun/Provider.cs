namespace SliceOfFun
{

    public class Product
    {
        public RawMaterial RM { get; set; }
        public RawMaterialType RMType { get; set; }

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
    }
    public class Provider
    {
        internal Dictionary<Product, decimal> Products { get; } = new Dictionary<Product, decimal>();

        internal readonly List<Product> Catalog = new() {
            new Product { RM = Product.RawMaterial.GroundBeef,      RMType = Product.RawMaterialType.Meat },
            new Product { RM = Product.RawMaterial.Pepperoni,       RMType = Product.RawMaterialType.Meat },
            new Product { RM = Product.RawMaterial.Chorizo,         RMType = Product.RawMaterialType.Meat },
            new Product { RM = Product.RawMaterial.ItalianSuasage,  RMType = Product.RawMaterialType.Meat },
            new Product { RM = Product.RawMaterial.Ham,             RMType = Product.RawMaterialType.Meat },
            new Product { RM = Product.RawMaterial.Capocollo,       RMType = Product.RawMaterialType.Meat },
            new Product { RM = Product.RawMaterial.PulledPork,      RMType = Product.RawMaterialType.Meat },
            new Product { RM = Product.RawMaterial.Steak,           RMType = Product.RawMaterialType.Meat },
            new Product { RM = Product.RawMaterial.Chicken,         RMType = Product.RawMaterialType.Meat },
            new Product { RM = Product.RawMaterial.Bacon,           RMType = Product.RawMaterialType.Meat },
            new Product { RM = Product.RawMaterial.GreenOlive,      RMType = Product.RawMaterialType.Vegetable },
            new Product { RM = Product.RawMaterial.BlackOlive,      RMType = Product.RawMaterialType.Vegetable },
            new Product { RM = Product.RawMaterial.Eggplant,        RMType = Product.RawMaterialType.Vegetable },
            new Product { RM = Product.RawMaterial.Artichoke,       RMType = Product.RawMaterialType.Vegetable },
            new Product { RM = Product.RawMaterial.Pineapple,       RMType = Product.RawMaterialType.Vegetable },
            new Product { RM = Product.RawMaterial.RedPepper,       RMType = Product.RawMaterialType.Vegetable },
            new Product { RM = Product.RawMaterial.GreenPepper,     RMType = Product.RawMaterialType.Vegetable },
            new Product { RM = Product.RawMaterial.Tomato,          RMType = Product.RawMaterialType.Vegetable },
            new Product { RM = Product.RawMaterial.Spinach,         RMType = Product.RawMaterialType.Vegetable },
            new Product { RM = Product.RawMaterial.Mushroom,        RMType = Product.RawMaterialType.Vegetable },
        };

        void Refill()
        {
            foreach (Product product in Catalog)
                Products?.Add(product, 200);
        }
        public void Refill(string request)
        {
            if (!string.IsNullOrEmpty(request))
                Refill();
            else
                throw new ArgumentException($"'{nameof(request)}' cannot be null or empty.", nameof(request));
        }

        void AddOrUpdateProduct(Product product, decimal quantity)
        {

        }

        public string IsProductAvailable(Product product, decimal quantity)
        {
            return (Products.ContainsKey(product) && Products[product] >= quantity) ? $"Provider has enough of {product.RM}" : $"Not Enough {product.RM}";
        }
    }

}
