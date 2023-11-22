using System;

namespace SliceOfFun
{
    abstract class Store
    {
        public virtual bool IsFranchiseStore { get; private set; }
        public virtual string? FranchiseName { get; init; }
        public virtual string? CompanyName { get; init; }
        public virtual string? LocationName { get; init; }
        public virtual Owner? Owner { get; set; }
        public virtual Person? FranchiseOwner { get; set; }


        public Store(bool isfranchisestore) => IsFranchiseStore = isfranchisestore;
    }

    abstract class FranchisePizzaStore : Store
    {
        protected FranchisePizzaStore(string? FranchiseName, Person? FranchiseOwner) : base(true)
        {
            CompanyName = GetType().Name;
        }
    }

    class UncleEtemPizza : FranchisePizzaStore
    {
        public UncleEtemPizza(Owner owner) : base(FranchiseName: "SNA Pizza", null)
        {
            Owner = owner;
        }
    }

    class PizzaBalcony : FranchisePizzaStore
    {
        public override string? LocationName { get => base.LocationName; init => base.LocationName = value; }

        public PizzaBalcony() : base(FranchiseName: "SNA Pizza", null)
        {
        }
    }
    class LocalPizzaStore : Store
    {
        public override bool IsFranchiseStore => false;

        public LocalPizzaStore(string? locationName, Person owner) : base(false)
        {
        }
    }
}


