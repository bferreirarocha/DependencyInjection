using OfficeService.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeService.Implementaton
{
    public class Employee : IEmployee
    {
        public void GiveMeAFeedBack(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        protected void OpenTheDoor(string message)
        {
            Console.WriteLine(message);
            Employee  emp = new Employee();
           
        }

    }
}
