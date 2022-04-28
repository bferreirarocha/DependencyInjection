namespace Translation.IoC
{
    public class EnglishTranslator : ITranslator
    {
        public string Translate(string ext)
        {
            return ("EnglishTranslator");
        }
    }
    public class GermanTranslator : ITranslator
    {
        public string Translate(string ext)
        {
            return ("GermanTranslator");
        }
    }
    public class SpanishTranslator : ITranslator
    {
        public string Translate(string ext)
        {
            return ("SpanishTranslator");
        }
    }
    public class ChineseTranslator : ITranslator
    {
        public string Translate(string ext)
        {
            return ("ChinesehTranslator");
        }
    }
}