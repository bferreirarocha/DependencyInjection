using OfficeService.;


namespace OfficeService.Services
{
    public class TranslationOnlineStore
    {
        
        public TranslationOnlineStore()
        {
          
        }
        public string Translate(Translation.LANGUAGE lang, string text)
        {
            var translator = TranslatorFactory.getTranlator(lang); 
            return string.Empty;
        }
    }
}
