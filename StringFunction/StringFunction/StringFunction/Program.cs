using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class sFunctions
    {
       
        //Upper
        public static string Upper(string s)
        {
            string s1 = "";
            foreach (char c in s)
                switch (c)
                {
                    case 'a': s1 += "A"; break;
                    default: s1 += c; break;
                }
            return s1;
        }
        //Initcaps
        public static string InitCaps(string s)
        {
            string s1 = "";
            bool flag = true;
            foreach (char c in s)
            {
                if (flag)
                {
                    flag = false;
                    s1 += c.ToString().ToUpper();
                }
                else
                    s1 += c.ToString().ToLower();
                flag = c == ' ';
            }
            return s1;
        }
        //Reverse
        public static string Reverse(string s)
        {
            string s1 = "";
            for (int i = Length(s) - 1; i >= 0; i--)
                s1 += s[i];
            return s1;
        }
        //Substring
        public static string SubString(string s, int start, int length)
        {
            int n = start + length;
            if (Length(s) < n) return "";
            string s1 = "";
            for (int i = start; i < n; i++)
                s1 += s[i];
            return s1;
        }
        //Contians
        public static bool Conatins(string s, string Searchstr)
        {
            if (s.Length < Searchstr.Length) return false;
            for (int i = 0; i < s.Length - Searchstr.Length + 1; i++)
                if (SubString(s, i, Searchstr.Length) == Searchstr)
                    return true;
            return false;
        }
        //Replace
        public static string Replace(string s, string Searchstr, string ReplaceStr)
        {

            if (s.Length < Searchstr.Length) return "";
            string s1 = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (SubString(s, i, Searchstr.Length) == Searchstr)
                    return s1 + ReplaceStr + Replace(SubString(s, s1.Length + Searchstr.Length, s.Length - s1.Length - Searchstr.Length) , Searchstr, ReplaceStr);
                s1 += s[i];
            }
            return s1;
        }
    }
}




namespace StringFunctions
{

    class Program
    {
        static void Main(string[] args)
        {
            #region Code
            string s1 = "this sentense is supposed to be initcapted";
            Console.WriteLine(sFunctions.Upper("ahmad"));
            string s2 = sFunctions.InitCaps(s1);
            Console.WriteLine(s2);
            Console.WriteLine(sFunctions.Reverse(s1));
            #region SubString
            Console.WriteLine(sFunctions.SubString(s1, 0, 3));
            Console.WriteLine(sFunctions.SubString(s1, 1, 3));
            Console.WriteLine(sFunctions.SubString(s1, 2, 3));
            Console.WriteLine(sFunctions.SubString(s1, 3, 3));
            #endregion Contains
            #region Contains
            Console.WriteLine(sFunctions.Conatins(s1, "sentense"));
            Console.WriteLine(sFunctions.Conatins(s1, "sentense1"));
            Console.WriteLine(sFunctions.Conatins(s1, "initcapted"));
            #endregion
            Console.WriteLine(sFunctions.Replace(s1, "sentense", "sentense1"));
            Console.WriteLine(sFunctions.Replace(s1 + "s", "s", "$"));
            #region Replace

            #endregion

            Console.ReadLine();

            #endregion
        }
    }
}
