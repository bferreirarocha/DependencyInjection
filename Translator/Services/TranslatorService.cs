using System.Threading;

namespace Translator
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
    internal class OfficeService
    {
        //private readonly TranslatorFactory _translatorFactory;
        //private readonly DeliveryFactory _deliveryFactory;


        //public OfficeService(SUPPOREDLANGUAGES language)
        //{
        //    _translatorFactory = new TranslatorFactory();
        //}
        //public OfficeService(DELIVERYSERVICES order)
        //{
        //    _deliveryFactory = new DeliveryFactory();
        //}

        public string translate(SUPPOREDLANGUAGES language, string text)
        {
            string Translation = TranslatorFactory.getTranslator(language).Translate(text);

            Thread.Sleep(10000);
            System.Console.WriteLine("Il tuo testo è pronto");
            return Translation;


        }
        public void BringMeCoffee(DELIVERYSERVICES order)
        {
            /// Quando la consegna è effetta  esegui  il metodo per avviare che il caffe è qui! 
            var DeliveryTime = DeliveryFactory.getDelivery(order)
                .OrderCoffe(AvvisaCapo);

            System.Console.WriteLine("Il caffè è arrivato! te lo porto subito! ");
        }
        void AvvisaCapo(string message)
        {
            System.Console.WriteLine(message);
        }
    }
}
