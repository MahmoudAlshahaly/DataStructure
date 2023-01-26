using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contians
{
    class Program
    {
        public static string SubString(string s, int start, int length)
        {
            int n = start + length;
            if (s.Length < n) return "";
            string s1 = "";
            for (int i = start; i < n; i++)
                s1 += s[i];
            return s1;
        }
        public static bool Conatians(string s, string Search)
        {
            if (s.Length < Search.Length) return false;
            for (int i = 0; i < s.Length - Search.Length + 1; i++)
                if (SubString(s, i, Search.Length) == Search)
                    return true;
            return false;
        }
        static void Main(string[] args)
        {
            string s1 = "this sentense is supposed to be initcapted";
            Console.WriteLine(Conatians(s1, "sentense"));
            Console.WriteLine(Conatians(s1, "sentense1"));
            Console.WriteLine(Conatians(s1, "initcapted"));
            Console.ReadKey();
        }
    }
}
