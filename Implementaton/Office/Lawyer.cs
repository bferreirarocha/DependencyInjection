﻿using OfficeService.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeService.Implementaton
{
    public class Lawyer : Employee, ILawyer
    {   
        public string Name { get; set; }
        public void Judget() { }
        public void BringMeACoffee(OfficeManager oManger) { }
        public void TranslateThis(OfficeManager oManger) { }
        public Lawyer(string name)
        {
            Name=name;  
        }
        
    }

}
 