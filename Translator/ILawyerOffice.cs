using OfficeService.Contracts;
using System;

namespace OfficeService
{
    public interface ILawyerOffice
    {
        public string _name { get;  set; }
        public OfficeService _myService { get; set; }
        void BringACoffee(DeliveryType order);
        void GiveMeAFeedBack(string message);
        void TranslateTHIS(Languages lang, string text);
    }
      public abstract class LawyerOffice: ILawyerOffice
        {
        public string _name { get; set; }
        public OfficeService _myService { get; set; }

        public void BringACoffee(DeliveryType order)
        {
            _ = _myService.OrderCoffee(order);
        }
        public LawyerOffice(string Name)
        {
            _myService = new OfficeService(this);
            _myService._serviceName = _name;
        }
        public void TranslateTHIS(Languages lang, string text)
        {
            _ = _myService.Translate(lang, text);
        }

        public void GiveMeAFeedBack(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(message);
            Console.ResetColor();

        }
    }
    internal class LawyerOfficeParis : LawyerOffice
    {
        public LawyerOfficeParis(string Name):base(Name)
        {
            _myService = new OfficeService(this);
            _myService._serviceName = _name;
        }
    }
    internal class LawyerOfficeNY: LawyerOffice
    {
        public LawyerOfficeNY(string Name) : base(Name)
        {
            _myService = new OfficeService(this);
            _myService._serviceName = _name;
        }
    }

}