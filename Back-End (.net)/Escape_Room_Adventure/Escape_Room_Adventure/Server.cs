using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escape_Room_Adventure
{
    internal class Server : ISystem
    {
        public string Status { get; set; }
        public void Operate()
        {
            Console.WriteLine($"Server is {Status}");
        }

        public Server(string status) 
        {
            Status = status;
        }
    }
}
