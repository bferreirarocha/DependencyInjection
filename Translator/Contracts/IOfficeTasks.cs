using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeService.Contracts
{
    public interface IOfficeTasks
    {
        void TakeDocs(DocType doc, string address);
        void BringDocs();
    } 
    public enum DocType
    {
        LEGAL,
        INVOICES 
    }
}
