namespace OfficeService.Implementaton
{
    public interface ILawyer
    {
        public string Name { get; set; }

        void GiveMeAFeedBack(string message);
    }
}