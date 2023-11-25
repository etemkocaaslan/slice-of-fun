using static SliceOfFun.PizzaStore;

namespace SliceOfFun
{
    abstract class PizzaStore
    {
        internal enum PizzaStoreType
        {
            SNAPizza,
            PizzaGarden,
            LocalStore
        }

        internal enum Location
        {
            Downtown,
            Gastown,
            Yaletown,
            Kitsilano,
            WestEnd
        }

        public virtual bool IsFranchiseStore { get; private set; }
        public virtual string? FranchiseName { get; init; }
        public virtual string? CompanyName { get; init; }
        public virtual string? LocationName { get; init; }
        public virtual Owner? Owner { get; set; }

        public PizzaStore(bool isFranchiseStore) => IsFranchiseStore = isFranchiseStore;
    }

    class FranchisePizzaStore : PizzaStore
    {

        public FranchisePizzaStore(string? companyName, string? franchiseName, string? locationName, Owner? owner) : base(true)
        {
            LocationName = locationName;
            CompanyName = companyName;
            FranchiseName = franchiseName;
            Owner = owner;
        }
    }

    class LocalPizzaStore : PizzaStore
    {
        public override bool IsFranchiseStore => false;

        public LocalPizzaStore(string? locationName, Owner owner) : base(false)
        {
            LocationName = locationName;
            Owner = owner;
        }
    }

    class PizzaStoreFactory
    {
        private static PizzaStoreFactory? _instance;

        private static readonly object _lock = new object();

        private PizzaStoreFactory() { }

        public static PizzaStoreFactory Instance
        {
            get
            {
                lock (_lock)
                    return _instance ??= new PizzaStoreFactory();
            }
        }

        public static PizzaStore CreatePizzaStore(PizzaStoreType storeType, Location location, Owner owner)
        {
            return storeType switch
            {
                PizzaStoreType.SNAPizza => new FranchisePizzaStore("Uncle Fatih Pizza", storeType.ToString(), location.ToString(), owner),
                PizzaStoreType.PizzaGarden => new FranchisePizzaStore("Pizza Garden", storeType.ToString(), location.ToString(), owner),
                PizzaStoreType.LocalStore => new LocalPizzaStore(location.ToString(), owner),
                _ => throw new ArgumentException("Invalid pizza store type"),
            };
        }
    }
}