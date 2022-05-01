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
              var delivery = DeliveryFactory.getDelivery(order);    
              Task<List<string>> menu = delivery.GetMenu();
              List<string> list = await menu;
              Console.WriteLine("Ecco il Menu:");
              list?.ForEach(x => Console.WriteLine("     "+x));
              var choose = list.FirstOrDefault();
              await Task.Delay(1000);
              var result = await delivery.OrderCoffe(choose,Avvisami);

            if (result)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                lawyer.GiveMeAFeedBack($"Ciao {lawyer.Name}. Il tuo caffe è arrviato!");
                Console.ResetColor();
            }           
           
        }
        void Avvisami(string message)
        {
            Console.ResetColor();   
            Console.WriteLine(message);
           
        }
    }
}
