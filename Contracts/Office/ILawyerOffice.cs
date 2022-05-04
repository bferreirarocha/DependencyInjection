using OfficeService.Contracts;
using OfficeService.Implementaton;
using System;
using System.Threading.Tasks;

namespace OfficeService
{
    public interface ILawyerOffice
    {
        Task OrderCoffee(FoodDeliveryType order, ILawyer lawyer);
        void Translate(Languages language, string text, ILawyer lawyer);
    }
   

}   