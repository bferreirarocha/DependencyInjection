using Deliveries;
using Translator.Contracts;

namespace Translator
{
    public class DeliveryFactory
    {
        public static IDelivery getDelivery(DELIVERYSERVICES order)
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
