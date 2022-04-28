namespace Translation.IoC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LawyerOffice lawyerOfficeMILANO = new LawyerOffice();
            string translationENG = lawyerOfficeMILANO.startTanslation(LANGUAGE.ENGLISH, "HEllo World");

            LawyerOffice lawyerOfficePARIGI = new LawyerOffice();
            string translationCHINESE = lawyerOfficePARIGI.startTanslation(LANGUAGE.CHINESE, "早上好");
        }
    }
    public class LawyerOffice
    {

        public readonly TranslationService _tranlationOffice;
        public string startTanslation(LANGUAGE lang, string text)
        {
            return _tranlationOffice.Translate(Factory.getTranslator(lang), text);
        }
        public LawyerOffice()
        {
            _tranlationOffice = new TranslationService();
        }
    }

    public enum LANGUAGE
    {
        ENGLISH,
        GERMAN,
        SPANISH,
        CHINESE
    }
}
