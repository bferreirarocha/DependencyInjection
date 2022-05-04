using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeService.Contracts.Delivery
{
    public interface IDinner
    {
        Task<bool> MakeDinner(Action<string> action);
    }
}
