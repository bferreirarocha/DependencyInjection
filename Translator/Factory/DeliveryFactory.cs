using Deliveries;
using OfficeService.Contracts;
using OfficeService.Implementaton;

namespace OfficeService
{
    public class DeliveryFactory
    {
        public static IDelivery GetDelivery(DeliveryType order)
        {
            switch (order)
            {
                case DeliveryType.COFFEE:
                    return new Starbucks();               
                default:
                    return null;
            }
        }
        public static IOfficeTasks GetTasksDelivery(DocType doc)
        {
            switch (doc)
            {
                case DocType.LEGAL:
                    return (IOfficeTasks)new LegalTrainee();
                default:
                    return null;
            }
        }

    }
    
}
