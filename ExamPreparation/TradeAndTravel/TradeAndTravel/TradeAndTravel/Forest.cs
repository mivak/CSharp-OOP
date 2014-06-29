namespace TradeAndTravel
{
    using System;
    using System.Linq;
    
    public class Forest : GatheringLocation
    {
        public Forest(string name)
            : base(name, ItemType.Wood, ItemType.Weapon, LocationType.Forest)
        {
        }
    }
}