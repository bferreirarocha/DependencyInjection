using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeService.Contracts
{
    internal interface IDelivery
    { 
        DateTime ReturnDeliveryTime();
        Task<bool> Deliver(object delivery);
        void GetOrder();
    }
}
