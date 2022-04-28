namespace Translator
{
    internal class LawyerTranslation
    {
        static void Main(string[] args)
        {
            TranslatorService translation = new TranslatorService(new EnglishTranslator());
        }
    }
}
