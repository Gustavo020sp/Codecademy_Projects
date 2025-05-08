using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliographical_Inheritance
{
    //super/base class
    internal class Resource
    {
        public string Title { get; private set; }
        public string Category { get; private set; }
        public string Status { get; protected set; }

        public Resource(string title, string category)
        {
            Title = title;
            Category = category;
            Status = "Available";
        }

        //method for updating a status of an item
        public virtual void UpdateStatus(string status)
        {
            if (status == "Out")
            {
                Status = "Available";
            }
        }
        public virtual void GetInfo()
        {
            Console.WriteLine($"Title: {Title}\nCategory: {Category}\nStatus: {Status}");
        }

    }
}
