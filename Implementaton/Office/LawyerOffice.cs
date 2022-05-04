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
        public string Name { get; set; }      

        public OfficeManager _OfficeManager { get; set; }

        public  async Task OrderCoffee(FoodDeliveryType order, Lawyer lawyer)
        {
           await Task.Run(()=>  _OfficeManager.OrderCoffee(order, lawyer));
        }
        public  LawyerOffice(string name)
        {
            Name = name;
        }
        //public async Task Translate(Languages language, string text, Lawyer lawyer)
        //{
        //   await Task.Run(()=> _OfficeManager.Translate(language, text, lawyer));
        //}
        public async Task Translate(Languages language, string text, Lawyer lawyer)
        {
           await Task.Run(() => _OfficeManager.Translate(language, text, lawyer));
        }

    }
    
}
