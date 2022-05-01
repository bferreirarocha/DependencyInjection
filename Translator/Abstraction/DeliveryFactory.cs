using Deliveries;
using OfficeService.Contracts;


namespace OfficeService
{
    public class DeliveryFactory
    {
        public static ICoffeShopDelivery getDelivery(DELIVERYSERVICES order)
        {
            switch (order)
            {
                case DELIVERYSERVICES.COFFEE:
                    return new Starbucks();
                // Laccio ordine su multilpli fornitori in paralello
                default:
                    return null;
            }
        }

    }
}
