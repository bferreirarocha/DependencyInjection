using OfficeService.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeService.Implementaton
{
    public class Lawyer : Employee, ILawyer
    {   
        public void Judge() { }
        public void BringMeACoffee(FoodDeliveryType food) 
        {
            _ = _Office.OrderCoffee(food, this);
        }
        //public async Task TranslateThis(Languages language, String text) {
        //     await Task.Run(()=> _Office.Translate(language, text, this));
        //}
        public void  TranslateThis(Languages language, String text)
        {
             _Office.Translate(language, text, this);
        }

        public Lawyer(string name, LawyerOffice Office, EmployeeType EmployeeType, EmployeeType Boss)
            :base(name, Office, EmployeeType, Boss)
        {             
            
        }
        
    }

}
 