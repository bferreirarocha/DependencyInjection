using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeService.Contracts.Delivery
{
    public interface ILunch
    {
        Task<bool> MakeLunch(Action<string> action);
    }
}
