namespace OfficeService.Contracts
{
    public interface ITranslator
    {
        string Translate(string text);
    }
    public enum Languages
    {
        ENGLISH,
        GERMAN,
        SPANISH
    }
}
