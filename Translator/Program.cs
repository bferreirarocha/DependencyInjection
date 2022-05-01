using OfficeService.Contracts;
using System;
using System.Threading.Tasks;

namespace OfficeService
{
    internal class Program
    {
        static void  Main(string[] args)
        {

             ILawyerOffice lawyerOfficeNY = new LawyerOfficeNY("NY");
             lawyerOfficeNY.TranslateTHIS(Languages.SPANISH, " Hola!");
             lawyerOfficeNY.BringACoffee(DeliveryType.COFFEE);
             Console.ReadKey();
            
        }
    }
   
   
   
}
