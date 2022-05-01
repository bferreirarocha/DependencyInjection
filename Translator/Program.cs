using System;
using System.Threading.Tasks;

namespace OfficeService
{
    internal class Program
    {
        static void  Main(string[] args)
        {

             ILawyerOffice lawyerOfficeNY = new LawyerOfficeNY("NY");
             lawyerOfficeNY.TranslateTHIS(SUPPOREDLANGUAGES.SPANISH, " Hola!");
             lawyerOfficeNY.BringACoffee(DELIVERYSERVICES.COFFEE);
             Console.ReadKey();
            
        }
    }
   
    public enum SUPPOREDLANGUAGES
    {
        ENGLISH,
        GERMAN,
        SPANISH
    }
    public enum DELIVERYSERVICES
    {
        COFFEE,
        LUNCH,
        DINNER
    }
}
