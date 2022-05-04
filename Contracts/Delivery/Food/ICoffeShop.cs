using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeService.Contracts.Delivery
{
    public interface ICoffeShop 
    { 
        Task<bool> MakeCoffee(string MenuChoice,Action<string> action);
    }
}
