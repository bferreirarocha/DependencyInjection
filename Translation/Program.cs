using System.Collections.Generic;

namespace Translation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LawyerOffice lawyerOfficeMilano = new LawyerOffice();
            lawyerOfficeMilano.startTanslation("Hello world");


            LawyerOffice lawyerOfficeParigi = new LawyerOffice();
            lawyerOfficeParigi.startTanslation("早上好");
        }
    }
    public class LawyerOffice
    {
        ITranslator[] _translator = new ITranslator[3];
        Dictionary<string, ITranslator> _translatorList = new Dictionary<string, ITranslator>();

        string _DailyTanslation;

        public void startTanslation(string text)
        {
            //TranslationService translator = new TranslationService(new EnglishTranslator());             
            _DailyTanslation = _translator[0].Translate(text);

        }
        public LawyerOffice()
        {
            _translatorList.Add("English", new EnglishTranslator());
            _translatorList.Add("spanish", new SpanishTranslator());
            _translatorList.Add("German", new GermanTranslator());

            /// Se non è piu disponibile la traduzione io posso cambiare la  
            /// class cosicchè chi la userà avrà il suo cambiamento ma,
            /// chi prima del cambiamento non saprà nulla del suo cambiamento 

        }
    }
}
