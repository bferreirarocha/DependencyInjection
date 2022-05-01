using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OfficeService.Contracts;

namespace Deliveries
{
    public abstract class Delivery : IDelivery
    {
        public enum MENU{ }
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
            Console.WriteLine($"Consegna efettuta! Grazie per avver scelto {delivery}");
            await Task.Delay(5000);
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
    
    public class Starbucks : Delivery, ICoffeShopDelivery
    {
        public new enum MENU
        {
           ESPRESSO, AMERICANO, CAPUCCINO
        }
        public Starbucks():base(){ }       
        public async Task<bool> OrderCoffe(string MenuChoice, Action<string> action)
        {
            string message;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Ordine del caffe {MenuChoice} efettuato con  {this.GetType().Name}..");
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
        public override async Task<List<string>> GetMenu()
        {
            List<string> menu = new List<string>();
            await Task.Delay(5000);
            foreach (string name in Enum.GetNames(typeof(MENU)))
            {
                menu.Add(name);
            }
            return menu;
            // return Enum.GetValues(typeof(MENU));
        }


    }
    public class McDonalds : Delivery, ILunchDelivery
    {
        public new enum MENU
        {
            BIGMAC, CHEASEBURGER, HOTDOG
        }
        public McDonalds() : base() { }
        public async Task<bool> OrderLunch(Action<string> action)
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
        public override async Task<List<string>> GetMenu()
        {
            List<string> menu = new List<string>();
            await Task.Delay(5000);
            foreach (string name in Enum.GetNames(typeof(MENU)))
            {
                menu.Add(name);
            }
            return menu;
            // return Enum.GetValues(typeof(MENU));
        }
    }

}
