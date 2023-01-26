using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upper
{
    class Program
    {
        public static string Upper(string s)
        {
            string name_after = "";
            foreach(char c in s)
            {
                switch (c)
                {
                    case ',': name_after += '\n';
                        break;
                    default: name_after += c;
                        break;

                }

            }
            return name_after;
        
        }

        static void Main(string[] args)
        {
            string name_before = Console.ReadLine();
            Console.WriteLine(Upper(name_before));
            Console.ReadKey();
        }
    }
}
