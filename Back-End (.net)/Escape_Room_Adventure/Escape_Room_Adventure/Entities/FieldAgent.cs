using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escape_Room_Adventure.Entities
{
    internal class FieldAgent
    {
        public string Name { get; set; }
        public int SecretCode {  get; set; }

        public FieldAgent(string name, int secretCode)
        {
            Name = name;
            SecretCode = secretCode;
        }
    }
}
