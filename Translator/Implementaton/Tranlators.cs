using System;
using Translator.Contracts;

namespace Translator
{

    public class EnglishTranslator : ITranslator
    {

        public string Translate(string text)
        {
            Console.WriteLine("ENGLISH TRANSLATION");
            return "Traslation of the text";
        }

    }
    public class GermanTranslator : ITranslator
    {
        public string Translate(string text)
        {
            Console.WriteLine("GERMAN TRANSLATION");
            return "Traslation of the text";

        }
    }
    public class SpanishTranslator : ITranslator
    {
        public string Translate(string text)
        {
            Console.WriteLine("SPANISH TRANSLATION");
            return "Traslation of the text";

        }
    }

}
