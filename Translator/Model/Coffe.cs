namespace OfficeService.Model
{
    public struct Coffe
    {
        public CoffeeType order { get; set; }

    }
    public enum CoffeeType
    {
        ESPRESSO,
        AMERICANO
    }
}
