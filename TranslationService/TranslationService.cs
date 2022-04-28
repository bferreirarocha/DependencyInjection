namespace Translation.IoC
{
    public class TranslationService
    {

        public string Translate(ITranslator translator, string text)
        {
            return translator.Translate(text);
        }
    }
}
