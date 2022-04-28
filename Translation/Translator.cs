namespace Translation
{
    public class EnglishTranslator : ITranslator
    {
        public string Translate(string text)
        {
            return "GermanTranslator";
        }

    }
    public class SpanishTranslator : ITranslator
    {
        public string Translate(string text)
        {
            return "GermanTranslator";
        }
    }
    public class GermanTranslator : ITranslator
    {
        public string Translate(string text)
        {
            return "GermanTranslator";
        }
    }
}
