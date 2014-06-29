namespace TradeAndTravel
{
    public class Iron : Item
    {
        public const int GeneralIronValue = 3;

        public Iron(string name, Location location = null)
            : base(name, Iron.GeneralIronValue, ItemType.Iron, location)
        {
        }
    }
}