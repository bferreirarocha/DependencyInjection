using Translator.Contracts;

namespace Translator.Abstraction
{
    public abstract class OfficeService
    {
        public IDelivery delivery;
        public ITranslator translator;
    }
}
