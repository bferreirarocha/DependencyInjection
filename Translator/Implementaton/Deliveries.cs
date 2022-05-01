using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OfficeService.Contracts;

namespace Deliveries
{
    public abstract class Delivery: IDelivery
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
        public async Task<bool> Deliver(object delivery)
        {
            Console.ForegroundColor = ConsoleColor.Red;         
              
            await Task.Delay(2000);
            Console.WriteLine("Ordine spedito....");
            await Task.Delay(20000);
            Console.ResetColor();
            Console.WriteLine( $"Consegna efettuta! Grazie per avver scelto {delivery}");
            await Task.Delay(5000);

            return true;    

        }
        
        public DateTime OrderLunch()
        {
            Console.WriteLine($"Ordine del caffe efettuato con  {this.GetType().Name}..");
            return ReturnOrder();
        }
        public DateTime OrderDinner()
        {
            Console.WriteLine($"Ordine del caffe efettuato con  {this.GetType().Name}..");
            return ReturnOrder();
        }
    }
    public class Starbucks : Delivery, ICoffeShopDelivery
    {

        public Starbucks():base()
        {

        }
        //public async Task OrderCoffe(Action<string> alert)
        //{
        //    StringBuilder message = new StringBuilder();
        //    message.AppendLine($"Ordine del caffe efettuato con  {this.GetType().Name}..");
        //    message.AppendLine($"Arriva alle ore {base.ReturnOrder()}");
        //    alert(message.ToString());
        //    Task<string> ts=  Deliver(this.GetType().Name);
        //    string s = await ts;
        //    alert(s);
        //}
        public async Task<bool> OrderCoffe(Action<string> action)
        {
            string message;
             Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Ordine del caffe efettuato con  {this.GetType().Name}..");
            Console.WriteLine($"Arriva alle ore {base.ReturnOrder()}");
            Task<bool> t = Deliver(this.GetType().Name); 
            var result = await t;

            if (result)
            {
                message = " CITOFONO -> Il tuo ordine è stato consegnto";
                action(message);
                await Task.Delay(5000);
                return true;
            }
            else
            {
                return false;
            }

        }

    }

}
