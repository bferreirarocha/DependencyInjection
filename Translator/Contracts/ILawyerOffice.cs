using OfficeService.Contracts;
using System;

namespace OfficeService
{
    public interface ILawyerOffice
    {       
        void BringACoffee(DeliveryType order);       
        void TranslateThis(Languages lang, string text);
    }
   

}   