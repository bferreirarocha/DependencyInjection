namespace Translator
{
    internal class TranslatorService
    {
        private readonly ITranslation _translator;

        public TranslatorService(ITranslation translator)
        {
            _translator = translator;
        }

        public void translate(string text)
        {
            _translator.Translate(text);
        }
    }
}
