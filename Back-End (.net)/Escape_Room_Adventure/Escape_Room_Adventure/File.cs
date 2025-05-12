using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escape_Room_Adventure
{
    internal class File
    {
        public string FileName { get; set; }
        public int FileSize {  get; set; }

        public File(string fileName, int fileSize)
        {
            FileName = fileName;
            FileSize = fileSize;
        }
    }
}
