using OfficeService.Contracts;
using OfficeService.Implementaton;
using System;

namespace OfficeService
{
    public interface ILawyerOffice
    {       
        void BringACoffee(FoodDeliveryType order, Lawyer lawyer);       
        void TranslateThis(Languages lang, Lawyer lawyer, string text);
    }
   

}   