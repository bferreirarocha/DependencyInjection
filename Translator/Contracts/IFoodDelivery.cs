using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OfficeService.Contracts
{
    public interface IFoodDelivery
    {       
        Task<List<string>> GetMenu();
    }
    public interface ICoffeShopDelivery: IFoodDelivery
    {
        Task<bool> OrderCoffe(string MenuChoice,Action<string> action);
    }
    public interface IDinnerDelivery : IFoodDelivery
    {   
        Task<bool> OrderDinner(Action<string> action);
    }
    public interface ILunchDelivery : IFoodDelivery
    {
        Task<bool> OrderLunch(Action<string> action);
    }
    public enum DeliveryType
    {
        COFFEE,
        LUNCH,
        DINNER
    }
}
