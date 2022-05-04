using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeService.Contracts
{
    public interface IEmployee
    {
        void GiveFeedBack(string message);       
        void AssignTask(string message);
    }
}
    