using System;
using OfficeService.Contracts;

namespace OfficeService.Implementation
{

    public class EnglishTranslator : ITranslator
    {

        public string Translate(string text)
        {
            Console.WriteLine("ENGLISH TRANSLATION");
            return "Traslation of the text in English";
        }

    }
    public class GermanTranslator : ITranslator
    {
        public string Translate(string text)
        {
            Console.WriteLine("GERMAN TRANSLATION");
            return "Traslation of the text in German";

        }
    }
    public class SpanishTranslator : ITranslator
    {
        public string Translate(string text)
        {
            Console.WriteLine("Traslatin from -> SPANISH....");
            return "Traslation of the text in Spanish";

        }
    }

}
