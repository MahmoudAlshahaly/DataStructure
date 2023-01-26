using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substring
{
    class Program
    {
       
        public static string SubString(string name ,int start,int length)
        {
            string name_after = "";
            int n = start + length;
            if (name.Length < n) return "";
            
            for (int i = start; i < n;i++ )
            name_after += name[i];
            return name_after;
        }
        static void Main(string[] args)
        {
            string name = "mody ahmed";
            Console.WriteLine(SubString(name, 0, 3));
            Console.WriteLine(SubString(name, 1, 3));
            Console.WriteLine(SubString(name, 2, 3));
            Console.WriteLine(SubString(name, 3, 3));
            Console.ReadKey();
        }
    }
}
