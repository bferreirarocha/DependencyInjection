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
        public string Name { get;  }
        public EmployeeType _EmployeeType;
        public EmployeeType _Boss; // -> Meglio Oggetto di tipo Employee
        public LawyerOffice _Office;
        //public OfficeManager _OManager;
        public Employee(string Name, LawyerOffice Office, EmployeeType EmployeeType, EmployeeType Boss)
        {
            if (Office is null) { throw new ArgumentNullException("Non hai fornito un LawyerOffice come paramentro"); }
            _Office = Office;  

            if (!string.IsNullOrEmpty(this.Name)) { throw new ArgumentNullException("Non hai fornito uno Nome per come paramentro"); }
            this.Name = Name;

            if (!Enum.IsDefined(typeof(EmployeeType), Boss)) { throw new  InvalidEnumArgumentException("Non hai fornito uno Type Employee come paramentro"); }
            _Boss = Boss;

            if (!Enum.IsDefined(typeof(EmployeeType), EmployeeType)) { throw new InvalidEnumArgumentException("Non hai fornito uno Boss come paramentro"); }
            _EmployeeType = EmployeeType;

            this.Name = Name;
            _EmployeeType = EmployeeType;
            _Boss = EmployeeType;
            _Office = Office;
           
        }
        public void AssignTask(string Task)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Task assinged to {Name}: ");
            Console.WriteLine($"Task to Do: {Task}: ");
            Console.ResetColor();
        }
        public void DoTask(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"I'm doing this Jobs: {message}: ");            
            Console.WriteLine($"I'm this Jobs: {message}: ");
            Console.ResetColor();
        }
        public void GiveFeedBack(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(message);
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
