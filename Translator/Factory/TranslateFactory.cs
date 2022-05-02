using OfficeService.Contracts;
using OfficeService.Implementation;

namespace OfficeService.Abstraction
{
    public class TranslatorFactory
    {

        public static ITranslator getTranslator(Languages Laguage)
        {
            switch (Laguage)
            {
                case Languages.ENGLISH:
                    return new EnglishTranslator();                   
                case Languages.SPANISH:
                    return new SpanishTranslator();                   
                case Languages.GERMAN:
                    return new GermanTranslator();                   
                default:
                    return null;
            }
        }        
    }
}
