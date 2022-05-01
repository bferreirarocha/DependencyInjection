using Deliveries;
using OfficeService.Contracts;


namespace OfficeService
{
    public class DeliveryFactory
    {
        public static ICoffeShopDelivery getDelivery(DeliveryType order)
        {
            switch (order)
            {
                case DeliveryType.COFFEE:
                    return new Starbucks();               
                default:
                    return null;
            }
        }

    }
}
