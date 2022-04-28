namespace Translator
{
    internal class LawyerOffice
    {
        static void Main(string[] args)
        {
            // TranslatorService translation = new TranslatorService(new EnglishTranslator());
            OfficeService translation = new OfficeService();

            ///  lacnia i due metodi in asyccrono 
            translation.translate(SUPPOREDLANGUAGES.ENGLISH, "Hello!");
            translation.BringMeCoffee(DELIVERYSERVICES.COFFEE);

        }
    }
    public enum SUPPOREDLANGUAGES
    {
        ENGLISH,
        GERMAN,
        SPANISH
    }
    public enum DELIVERYSERVICES
    {
        COFFEE,
        LUNCH,
        DINNER
    }
}
