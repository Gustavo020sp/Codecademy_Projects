using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escape_Room_Adventure
{
    internal interface ISystem
    {
        string Status { get; set; }
        void Operate();
    }
}
