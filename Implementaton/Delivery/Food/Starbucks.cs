using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using OfficeService.Contracts.Delivery;

namespace Deliveries
{
    public class Starbucks : FoodService, ICoffeShop
    {
        enum MENU
        {
           ESPRESSO, AMERICANO, CAPUCCINO
        }
       // public Starbucks():base(){ }       
        public async Task<bool> MakeCoffee(string MenuChoice, Action<string> action)
        {
            string message;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Ordine del caffe {MenuChoice} efettuato con  {this.GetType().Name}..");
            Console.WriteLine($"Arriva alle ore {this.ReturnDeliveryTime()}");
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
        }
    }

}
