namespace Translation
{
    public class TranslationService
    {
        private readonly ITranslator _translator;

        public TranslationService(ITranslator translator)
        {
            this._translator = translator;
        }
        public string Translate(string text)
        {
            return _translator.Translate(text);
        }
    }
}
