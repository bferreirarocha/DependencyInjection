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

        public OfficeManager OfficeManager { get; set; }

        public void OrderCoffee(FoodDeliveryType order, Lawyer lawyer )
        {
            Task t = OfficeManager.OrderCoffee(order, lawyer);
        }
        public  LawyerOffice(
           // List<Lawyer> lawyers,
            string Name)
        {
            //Lawyers = lawyers;
            OfficeManager = new OfficeManager(this);
            OfficeManager._officeName = _name;  
        }
        public void Translate(Languages lang, Lawyer Lawyer, string text)
        {
            OfficeManager.Translate(lang, text, Lawyer);
        }

        
    }
    
}
