using Translator.Contracts;

namespace Translator
{
    public class TranslatorFactory
    {

        public static ITranslator getTranslator(SUPPOREDLANGUAGES Laguage)
        {
            switch (Laguage)
            {
                case SUPPOREDLANGUAGES.ENGLISH:
                    return new EnglishTranslator();
                    break;
                case SUPPOREDLANGUAGES.SPANISH:
                    return new SpanishTranslator();
                    break;
                case SUPPOREDLANGUAGES.GERMAN:
                    return new GermanTranslator();
                    break;
                default:
                    return null;
            }
        }
        //public static ITranslator getTranslatorWithDelivery(SUPPOREDLANGUAGES Laguage, DELIVERYSERVICES service)
        //{
        //    switch (Laguage)
        //    {
        //        case SUPPOREDLANGUAGES.ENGLISH:
        //            return new EnglishTranslator();
        //            break;
        //        default:
        //            return null;
        //    }
        //}
    }
}
