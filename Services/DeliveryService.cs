using Deliveries;
using OfficeService.Contracts;
using OfficeService.Implementaton;

namespace OfficeService
{
    public class DeliveryService
    {
        public static IFoodDelivery GetFoodDelivery(FoodDeliveryType order)
        {
            switch (order)
            {
                case FoodDeliveryType.COFFEE:
                    return new Starbucks();               
                default:
                    return null;    
            }
        }
        public static IOfficeTasks GetTasksDelivery(TaskType doc)
        {
            switch (doc)
            {
                case TaskType.LEGAL:
                    return (IOfficeTasks)new LegalTrainee();
                default:
                    return null;
            }
        }  
    }
    
}
