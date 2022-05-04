using OfficeService.Contracts;
using OfficeService.Implementaton;
using System;
using System.Threading.Tasks;

namespace OfficeService
{
    public interface IOfficeServices
    {
        Task OrderCoffee(FoodDeliveryType order , Lawyer lawyer);
        Task Translate(Languages language, string text, Lawyer lawyer);
    }
   

}   