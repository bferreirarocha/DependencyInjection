using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeService.Contracts
{
    public interface IDelivery
    { 
        DateTime DeliveryTime();
        Task<bool> Deliver(object delivery);
        void GetOrder();
    }
    public enum DeliveryType
    {
        FOOD,
        TRASLATION,
        TASK
    }
}
