using System.Collections.Generic;

namespace Translation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LawyerOffice lawyerOfficeMilano = new LawyerOffice();
            lawyerOfficeMilano.startTanslation(LANGUAGE.SPANISH,"HOLA!");         
        }
    }
    public class LawyerOffice
    {    
        public TranslationOffice _translationOffice { get; set; }   
        public TranslationDelivery _deliveryOffice { get; set; }
        public void startTanslation(LANGUAGE lang, string text)
        {
            _translationOffice.Translate(lang,text);
        }
        public LawyerOffice()
        {

        }
    } 
    public class TranslationOffice
    {

        OfficeService _onlineStore = new OfficeService();
        public string Translate(LANGUAGE lang, string text)
        {
            return _onlineStore.Translate(lang, text);
        }
    }
    public enum LANGUAGE
    {
        ENG,
        GERMAN,
        SPANISH      

    }
}
