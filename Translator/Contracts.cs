using System;

namespace Translator
{
    internal interface ITranslation
    {
        void Translate(string text);
    }
    public class EnglishTranslator : ITranslation
    {
        public void Translate(string text)
        {
            Console.WriteLine("ENGLISH TRANSLATION");
        }
    }
    public enum Laguages
    {
        ENGLISH,
        GERMAN,
        SPANISH
    }
}
