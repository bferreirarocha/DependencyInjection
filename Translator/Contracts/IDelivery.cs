using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OfficeService.Contracts
{
    public interface IDelivery
    {      
        DateTime ReturnOrder();
        Task<bool> Deliver(object delivery);
        Task<List<string>> GetMenu();
    }
    public interface ICoffeShopDelivery: IDelivery
    {
        Task<bool> OrderCoffe(string MenuChoice,Action<string> action);
    }
    public interface IDinnerDelivery : IDelivery
    {   
        Task<bool> OrderDinner(Action<string> action);
    }
    public interface ILunchDelivery : IDelivery
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
