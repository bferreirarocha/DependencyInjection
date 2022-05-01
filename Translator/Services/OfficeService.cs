using OfficeService.Abstraction;
using System;
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
        public string _serviceName;
        public ILawyerOffice _bossOffice;
        public async Task Translate(SUPPOREDLANGUAGES language, string text)
        {    
            string Translation = TranslatorFactory.getTranslator(language).Translate(text);
            await Task.Delay(3000);            
            _bossOffice.GiveMeAFeedBack("Il tuo testo è pronto: "+ Translation); // ->> accopiamento del nome della fuzione
        }
        public OfficeService(ILawyerOffice office)  
        {
            _bossOffice = office;
            _serviceName = _bossOffice._name;
        }
        public async Task OrderCoffee(DELIVERYSERVICES order)
        {
            /// Quando la consegna è effetta  esegui  il metodo per avviare che il caffe è qui! 
             var result = await  DeliveryFactory.getDelivery(order)
                 .OrderCoffe(Avvisami);
            if (result)
            {
                 Console.ForegroundColor = ConsoleColor.Blue;
                _bossOffice.GiveMeAFeedBack("Il tuo caffe è arrviato!");
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
