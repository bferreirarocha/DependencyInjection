using System;

namespace TranslatorTCoupled
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LawyerOffice lawyerOfficePARIGI = new LawyerOffice();
            lawyerOfficePARIGI.startTanslation(new SpanishTranslator(), "HOLA!");
        }
    }
    public class LawyerOffice
    {  

        ITranslator _DailyTanslation;

        public void startTanslation(ITranslator translator, string text)
        {
            translator.Translate(text);
        }
        public LawyerOffice()
        { 
        }
    }
}
