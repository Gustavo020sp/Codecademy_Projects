﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Interfaces.Entities
{
    internal interface IDisplayable
    {
        string HeaderSymbol { get; }
        public void Display();
    }
}
