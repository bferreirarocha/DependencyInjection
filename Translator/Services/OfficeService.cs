using OfficeService.Abstraction;
using OfficeService.Contracts;
using OfficeService.Implementaton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace OfficeService
{

    #region NO IoC
    //internal class TranslatorService
    //{
    //    private readonly ITranslator _translator;

    //    public TranslatorService(ITranslator translator)
    //    {
    //        _translator = translator;
    //    }

    //    public void translate(string text)
    //    {
    //        _translator.Translate(text);
    //    }
    //}
    #endregion 
    public class OfficeService
    {
        public string _officeName;
        public LawyerOffice _office;
        public void Translate(Languages language, string text, ILawyer lawyer)
        {    
            string Translation = TranslatorFactory.getTranslator(language).Translate(text);
            Thread.Sleep(2000);
            lawyer.GiveMeAFeedBack("Il tuo testo è pronto: "+ Translation); // ->> accopiamento del nome della fuzione
        }
        public OfficeService(LawyerOffice office)  
        {
            _office = office;
            _officeName = _office._name;
        }
        public async Task OrderCoffee(DeliveryType order, ILawyer lawyer)
        {
            bool result = false;
            string resutMessage;
            try
            {
                var delivery = (ICoffeShopDelivery)DeliveryFactory.GetDelivery(order);
                Task<List<string>> menu = delivery.GetMenu();
                List<string> list = await menu;
                Console.WriteLine("Ecco il Menu:");

                list?.ForEach(x => Console.WriteLine("  -   " + x));
                var choose = list.FirstOrDefault();
                await Task.Delay(1000);

                result = await delivery.OrderCoffe(choose, Avvisami);
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
            lawyer.GiveMeAFeedBack(resutMessage);
            Console.ResetColor();
                   
           
        }
        void Avvisami(string message)
        {
            Console.ResetColor();   
            Console.WriteLine(message);
           
        }
    }
}
