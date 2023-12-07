using static SliceOfFun.PizzaStore;

namespace SliceOfFun
{
    public enum FranchiseType
    {
        SNAPizza,
        PizzaGarden,
        LocalStore
    }

    public enum Location
    {
        Downtown,
        Gastown,
        Yaletown,
        Kitsilano,
        WestEnd
    }

    public abstract class PizzaStore
    {
        public virtual bool IsFranchiseStore { get; private set; }
        public virtual FranchiseType? Franchise { get; init; }
        public virtual string? CompanyName { get; init; }
        public virtual Location? Location { get; init; }
        public virtual Owner? Owner { get; set; }

        public PizzaStore(bool isFranchiseStore)
        {
            IsFranchiseStore = isFranchiseStore;
        }
        public override string ToString()
        {
            return Franchise + "-" + CompanyName;
        }
    }

    class FranchisePizzaStore : PizzaStore
    {
        public Dictionary<RawMaterial, decimal> Storage { get; private set; } = new Dictionary<RawMaterial, decimal>();
        public FranchisePizzaStore(string? companyName, FranchiseType? franchise, Location? location, Owner? owner) : base(true)
        {
            Location = location;
            CompanyName = companyName;
            Franchise = franchise;
            Owner = owner;
        }
    }

    class LocalPizzaStore : PizzaStore
    {
        public LocalPizzaStore(Location? locationName, Owner owner) : base(false)
        {
            Location = locationName;
            Owner = owner;
        }
    }

    public class PizzaStoreFactory
    {
        private static PizzaStoreFactory? _instance;

        private static readonly object _lock = new();

        public static PizzaStoreFactory Instance
        {
            get
            {
                lock (_lock)
                    return _instance ??= new PizzaStoreFactory();
            }
        }

        public static PizzaStore CreatePizzaStore(FranchiseType franchise, Location location, Owner owner)
        {
            return franchise switch
            {
                FranchiseType.SNAPizza => new FranchisePizzaStore("Uncle Fatih Pizza", franchise, location, owner),
                FranchiseType.PizzaGarden => new FranchisePizzaStore("Pizza Garden", franchise, location, owner),
                FranchiseType.LocalStore => new LocalPizzaStore(location, owner),
                _ => throw new ArgumentException("Invalid pizza store type"),
            };
        }
    }
}