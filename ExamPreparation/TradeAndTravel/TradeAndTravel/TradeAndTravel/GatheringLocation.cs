namespace TradeAndTravel
{
    using System;
    using System.Linq;
    
    public abstract class GatheringLocation : Location, IGatheringLocation
    {
        protected GatheringLocation(string name, ItemType gatheredType, ItemType requiredItem, LocationType locationType)
            : base(name, locationType)
        {
            this.GatheredType = gatheredType;
            this.RequiredItem = requiredItem;
        }

        public ItemType GatheredType { get; protected set; }

        public ItemType RequiredItem { get; protected set; }

        public virtual Item ProduceItem(string name)
        {
            if (this.GatheredType == ItemType.Iron)
            {
                return new Iron(name);
            }

            if (this.GatheredType == ItemType.Wood)
            {
                return new Wood(name);
            }

            return null;
        }
    }
}