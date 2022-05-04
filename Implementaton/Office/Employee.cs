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
        
        public void GiveFeedBack(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public void AssignTask(string Task)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(Task);
            Console.ResetColor();
        }
        protected internal void OpenTheDoor(string message)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(message);
            Console.ResetColor(); ;     
        }
    }
}
