using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs.OOPs.Interface
{
    class FileInfo:IFile,IFile1
    {
        public void ReadFile()
        {
            Console.WriteLine("Reading File");
        }

        public void WriteFile(string text)
        {
            Console.WriteLine("Writing to file");
        }
        public void Read()
        {
            Console.WriteLine("Reading from IFile1 Interface");
        }
        public void Write1()
        {
            Console.WriteLine("Implementing from IFile1 Interface");
        }
    }
}
