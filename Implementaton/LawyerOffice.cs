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
        public Lawyer Lawyer { get; set; } 

        public OfficeManager _Service { get; set; }

        public void BringACoffee(FoodDeliveryType order, Lawyer lawyer )
        {
            Task t = _Service.OrderCoffee(order, lawyer);
        }
        public  LawyerOffice(
           // List<Lawyer> lawyers,
            string Name)
        {
            //Lawyers = lawyers;
            _Service = new OfficeManager(this);
            _Service._officeName = _name;
        }
        public void TranslateThis(Languages lang, Lawyer Lawyer, string text)
        {
            _Service.Translate(lang, text, Lawyer);
        }

        
    }
    
}
