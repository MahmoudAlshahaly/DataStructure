using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
    class Program
    {
        public static string Reverse(string name)
        {
           string name_after = "";
           for (int i = name.Length - 1; i >= 1; i--)
           {
               name_after += name[i];
           }
           return name_after;
        
        }
        static void Main(string[] args)
        {
            string name_before = "mahmoud ahmed abd elftah elshhaly";
            Console.WriteLine(Reverse(name_before));
            Console.ReadKey();
        }
    }
}
