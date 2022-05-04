using Deliveries;

using OfficeService.Contracts;
using OfficeService.Contracts.Delivery;
using OfficeService.Implementaton;
using OfficeService.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace OfficeService
{

    public class OfficeManager: Employee , ILawyerOffice
    {
        public string _officeName;
        public LawyerOffice _office;
        public OfficeManager(LawyerOffice office)
        {
            _office = office;
            _officeName = _office._name;
        }
        public void Translate(Languages language, string text, ILawyer lawyer)
        {    
            string Translation = TranslatorService.getTranslator(language).Translate(text);
            Thread.Sleep(2000);
            lawyer.GiveFeedBack("Il tuo testo è pronto: "+ Translation); // ->> accopiamento del nome della fuzione
        }       
        public async Task OrderCoffee(FoodDeliveryType order, ILawyer lawyer)
        {
            bool result = false;
            string resutMessage;
            try
            {
                var delivery = (FoodService) DeliveryService.GetFoodDelivery(order);
                Task<List<string>> menu = delivery.GetMenu();
                List<string> list = await menu;
                Console.WriteLine("Ecco il Menu:");

                list?.ForEach(x => Console.WriteLine("  -   " + x));
                var choose = list.FirstOrDefault();
                await Task.Delay(1000);

                result = await ((ICoffeShop) delivery).MakeCoffee(choose, Avvisami);
                resutMessage = $"Ciao {lawyer.Name}. Il tuo caffe è arrviato!";
            }
            catch (InvalidCastException)
            {
                resutMessage = "Impossibile trovare un Delivery che porta il caffe!";
            }
            catch (NullReferenceException)
            {
                resutMessage = "Non sono riscito a trovare la list del menu!";
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            lawyer.GiveFeedBack(resutMessage);
            Console.ResetColor();
                   
           
        }
        void Avvisami(string message)
        {
            Console.ResetColor();   
            Console.WriteLine(message);           
        }
      
    }
}
