using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs.OOPs.Interface
{
    class TestInterface
    {
        static void Main(String[] args)
        {
            IFile file1 = new FileInfo();
            FileInfo file2 = new FileInfo();
            IFile1 file3 = new FileInfo();

            file1.ReadFile();
            file1.WriteFile("content");

            file2.ReadFile();
            file2.WriteFile("content");

            file3.Read();
            file3.Write1();

            file2.Read();
            file2.Write1();
        }
    }
}
