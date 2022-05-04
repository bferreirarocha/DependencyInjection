namespace OfficeService.Contracts
{
    public interface ILawyer: IEmployee
    {
        public string Name { get; set; }
        public void Judget();
    }
}