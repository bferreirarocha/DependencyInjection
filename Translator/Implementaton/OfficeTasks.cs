using OfficeService.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeService.Implementaton
{
    public class LegalTrainee : IOfficeTasks
    {
        public void TakeDocs(DocType doc, string address ) { }
        public void BringDocs() { }
    }
    public class OfficeBoy: IOfficeTasks
    {
        public void TakeDocs(DocType doc, string address) { }
        public void BringDocs() { }
    }
}
