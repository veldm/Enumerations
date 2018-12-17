using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enumerations;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person A = new Person((Languages)1, "kfjdngjbg");
            Person B = new Person((Languages)16, "fgkbnh");
            Person C = new Person((Languages)9, "dwtghig");
            Person[] M = { A, B, C };
            for (int i = 0; i < M.Length; i++) if ((M[i].IsPartialyEqual((Languages)3))) Console.WriteLine(M[i].Name);
            for (; ; ) ;
        }
    }
}
