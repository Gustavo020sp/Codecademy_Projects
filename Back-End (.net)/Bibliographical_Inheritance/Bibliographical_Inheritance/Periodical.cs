using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliographical_Inheritance
{
    internal class Periodical : Resource
    {
        public string Period { get; set; }

        public Periodical(string title, string category, string period) : base(title, category)
        {
            Period = period;
        }

        public override void UpdateStatus(string status)
        {
            if (status == "Out")
            {
                Status = "In-use";
            }
        }
    }
}
