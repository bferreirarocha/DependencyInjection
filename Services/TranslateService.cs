using OfficeService.Contracts;
using OfficeService.Implementation;

namespace OfficeService.Services
{
    public class TranslatorService
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