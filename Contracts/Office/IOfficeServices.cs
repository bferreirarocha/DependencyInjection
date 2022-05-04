using OfficeService.Contracts;
using OfficeService.Implementaton;
using System;
using System.Threading.Tasks;

namespace OfficeService
{
    public interface IOfficeServices
    {
        Task OrderCoffee(FoodDeliveryType order, ILawyer lawyer);
        void Translate(Languages language, string text, ILawyer lawyer);
    }
   

}   