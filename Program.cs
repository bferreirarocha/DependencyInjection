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
             LawyerOffice lawyerOfficeNY = new LawyerOffice("NY");  
             
          
            OfficeManager OManager = new OfficeManager(
                 "Emily", 
                 lawyerOfficeNY, 
                 EmployeeType.OFFICEMANAGER, 
                 EmployeeType.LAWYER
                 );
            

            Lawyer Miranda = new Lawyer(
                "Miranda",
                lawyerOfficeNY,                 
                EmployeeType.LAWYER,
                EmployeeType.LAWYER
                );

               Miranda.TranslateThis(Languages.GERMAN, "HALO");
            // Miranda.TranslateThis(Languages.GERMAN, "HALO");
            await  Task.Run(() => Miranda.BringMeACoffee(FoodDeliveryType.COFFEE));


            #region async
            //Lawyer lawyer = lawyerOfficeNY.Lawyers.Find(x => x.Name == "Miranda"); 
            //await Task.Run(() => lawyerOfficeNY.BringACoffee(DeliveryType.COFFEE));
            //await Task.Run(() =>lawyerOfficeNY.TranslateThis(Languages.SPANISH, " Hola!"));            ;
            #endregion

            Console.ReadKey();                  
            
        }
        
    }
   
   
   
}
