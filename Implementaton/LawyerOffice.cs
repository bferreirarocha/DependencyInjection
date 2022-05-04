using OfficeService.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeService.Implementaton
{
   
    public  class LawyerOffice : IOfficeServices
    {
        public string _name { get; set; }
        public Lawyer Lawyer { get; set; } 

        public OfficeManager OfficeManager { get; set; }

        public  async Task OrderCoffee(FoodDeliveryType order, ILawyer lawyer)
        {
            Task t =  OfficeManager.OrderCoffee(order, lawyer);
        }
        public  LawyerOffice(string Name)
        {
            OfficeManager = new OfficeManager(this);
            OfficeManager._officeName = _name;  
        }
        public void Translate(Languages language, string text, ILawyer lawyer)
        {
            OfficeManager.Translate(language, text, Lawyer);
        }

        
    }
    
}
