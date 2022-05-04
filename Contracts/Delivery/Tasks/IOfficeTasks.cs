using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeService.Contracts
{
    public interface IOfficeTasks
    {
        void TakeTask(TaskType doc, string address);
        void ReturnTask();
    } 
    public enum TaskType
    {
        LEGAL,
        INVOICES 
    }
}
