using System;
using System.Threading.Tasks;

namespace OfficeService.Contracts
{
    public interface IDelivery
    {        
        DateTime ReturnOrder();
        Task<bool> Deliver(object delivery);
      

    }
    public interface ICoffeShopDelivery: IDelivery
    {
        Task<bool> OrderCoffe(Action<string> action);
    }
}
