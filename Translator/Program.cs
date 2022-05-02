using OfficeService.Contracts;
using OfficeService.Implementaton;
using System;
using System.Threading.Tasks;

namespace OfficeService
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            ILawyerOffice lawyerOfficeNY = new LawyerOffice("NY");
            await Task.Run(() => lawyerOfficeNY.BringACoffee(DeliveryType.COFFEE));
            await Task.Run(() =>lawyerOfficeNY.TranslateThis(Languages.SPANISH, " Hola!"));            ;

            Console.ReadKey(); 
         
            
                
        }
    }
   
   
   
}
