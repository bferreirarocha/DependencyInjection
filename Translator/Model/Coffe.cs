namespace OfficeService.Model
{
    public struct Coffe
    {
        public CoffeeType type { get; set; }
    }
    public enum CoffeeType
    {
        ESPRESSO,
        AMERICANO
    }
}
