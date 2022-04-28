using System;
using System.Threading.Tasks;
using Translator.Contracts;

namespace Deliveries
{
    public abstract class Delivery
    {
        public DateTime ReturnOrder()
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
        public async Task<bool> Deliver()
        {
            Console.WriteLine("Ordine spedito....");
            await Task.Delay(10000);
            Console.WriteLine("Consegna efettuta! Grazie per avver scelto noi!");
            return true;
        }


    }
    public class Starbucks : Delivery, IDelivery
    {

        public async Task<DateTime> OrderCoffe(Action<string> alert)
        {
            alert.DynamicInvoke($"Ordine del caffe efettuato con  {this.GetType().Name}..");
            // Console.WriteLine($"Ordine del caffe efettuato con  {this.GetType().Name}..");
            await Deliver();
            //consegna il messaggio con l'ora di consegna 
            // Fai la preparazione dle caffe in parallelo 

            return base.ReturnOrder();
        }
        public DateTime OrderLunch()
        {
            Console.WriteLine($"Ordine del caffe efettuato con  {this.GetType().Name}..");
            return base.ReturnOrder();
        }
        public DateTime OrderDinner()
        {
            Console.WriteLine($"Ordine del caffe efettuato con  {this.GetType().Name}..");
            return base.ReturnOrder();
        }
    }

}
