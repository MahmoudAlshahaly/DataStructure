using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Replace
{
    class Program
    {
         public static string Replace(string s, string Searchstr, string ReplaceStr)
        {

            if (s.Length < Searchstr.Length) return "";
            string s1 = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (SubString(s, i, Searchstr.Length) == Searchstr)
                return s1 + ReplaceStr + Replace(SubString(s, s1.Length + Searchstr.Length, s.Length - s1.Length - Searchstr.Length), Searchstr, ReplaceStr);
                s1 += s[i];
            }
            return s1;
        }
        public static string SubString(string s, int start, int length)
        {
            int n = start + length;
            if (s.Length < n) return "";
            string s1 = "";
            for (int i = start; i < n; i++)
                s1 += s[i];
            return s1;
        }

        static void Main(string[] args)
        {
            string s1 = "this sentense is supposed to be initcapted";
            Console.WriteLine(Replace(s1, "sentense", "sentense1"));
            Console.WriteLine(Replace(s1 + "\t" + "s", "s", "$"));
            Console.ReadKey();
        }
    }
}
