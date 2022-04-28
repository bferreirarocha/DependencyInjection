namespace Translation.IoC
{
    public class Factory
    {

        public static ITranslator getTranslator(LANGUAGE lang)
        {
            switch (lang)
            {
                case LANGUAGE.ENGLISH:
                    return new EnglishTranslator();
                    break;
                case LANGUAGE.SPANISH:
                    return new SpanishTranslator();
                    break;
                case LANGUAGE.GERMAN:
                    return new GermanTranslator();
                    break;
                case LANGUAGE.CHINESE:
                    return new ChineseTranslator();
                    break;
                default:
                    return null;
            }
        }
    }
}
