using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OfficeService.Contracts;

namespace Deliveries
{
    public abstract class FoodService : IFoodDelivery
    {   enum Menu { }
        protected  string Name { get; set; }    
        protected private DateTime ReturnDeliveryTime()
        {
            var orderTime = DateTime.Now;
            return new DateTime(
                orderTime.Year,
                orderTime.Month,
                orderTime.Day,
                orderTime.Hour,
                orderTime.Minute, 0
                ).AddHours(1);
        }
        public async Task<bool> Deliver(object delivery)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            await Task.Delay(2000);
            Console.WriteLine("Ordine spedito....");
            await Task.Delay(10000);
            Console.ResetColor();
            Console.WriteLine($"Consegna efettuta! Grazie per avver scelto {delivery}");
            await Task.Delay(3000);
            return true;
        }
        //public List<T> GetMenu<T>()
        //{
        //    T[] array = (T[])Enum.GetValues(typeof(T));
        //    List<T> list = new List<T>(array);
        //    return list;
        //}
        public abstract Task<List<string>> GetMenu();  

    }

}
