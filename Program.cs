using OfficeService.Contracts;
using OfficeService.Implementaton;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OfficeService
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
             Lawyer lawyer = new Lawyer("Miranda");
             LawyerOffice lawyerOfficeNY = new LawyerOffice("NY");
             lawyerOfficeNY.BringACoffee(FoodDeliveryType.COFFEE, lawyer);
             #region async
            //Lawyer lawyer = lawyerOfficeNY.Lawyers.Find(x => x.Name == "Miranda"); 
            //await Task.Run(() => lawyerOfficeNY.BringACoffee(DeliveryType.COFFEE));
            //await Task.Run(() =>lawyerOfficeNY.TranslateThis(Languages.SPANISH, " Hola!"));            ;
            #endregion

            Console.ReadKey();  
                
        }
    }
   
   
   
}
