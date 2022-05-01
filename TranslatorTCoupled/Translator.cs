using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OfficeService.Implementation
{
    
    public class SpanishTranslator : ITranslator
    {
        public string Translate(string text)
        {
            return "GermanTranslator";
        }
    }
    public class GermanTranslator : ITranslator
    {
        public string Translate(string text)
        {
            return "GermanTranslator";
        }
    }
}
}
