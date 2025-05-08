using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliographical_Inheritance
{
    internal class Video : Resource
    {
        public string Director { get; set; }
        public int RunTime { get; set; }
        public string MediaType { get; set; }

        public Video(string director, int runtime, string mediatype, string title, string category) : base(title, category)
        {
            Director = director;
            RunTime = runtime;
            MediaType = mediatype;
        }

        public override void GetInfo()
        {
            Console.WriteLine($"Video Title: {Title}\nVideo Category: {Category}\nVideo Director: {Director}\nVideo runtime: {RunTime}\nVideo type: {MediaType}");
        }

    }
}
