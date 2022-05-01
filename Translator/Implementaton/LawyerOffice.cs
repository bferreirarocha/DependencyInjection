using OfficeService.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeService.Implementaton
{
   
    public  class LawyerOffice : ILawyerOffice
    {
        public string _name { get; set; }
        Lawyer _lawyer { get; set; }
        public OfficeService _Service { get; set; }

        public void BringACoffee(DeliveryType order)
        {
            Task t = _Service.OrderCoffee(order,_lawyer);
        }
        public  LawyerOffice(string Name)
        {
            _lawyer = new Lawyer() { Name ="Miranda"}; 
            _Service = new OfficeService(this);
            _Service._officeName = _name;
        }
        public void TranslateThis(Languages lang, string text)
        {
            _Service.Translate(lang, text, _lawyer);
        }

        
    }
    
}
