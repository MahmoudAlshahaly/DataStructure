using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inticaps
{
    class Program
    {
        public static string InitCaps(string s)
        {
            string s1 = "";
            bool flag = true;
            foreach (char c in s)
            {
                if (flag)
                {
                   //وظيفتها بتخلى اول حرف كابتل من كل اول كلمه  
                    flag = false;
                    s1 += c.ToString().ToUpper();
                }
                else
      //بعد ما اعمل اول حرف كابتل با ايف الا فوقى دى هنزل تحت افضل مخلى الحروب الباقيه الا بعد الاحرف الاول صغيره لحد ما اوصل للمسافه كدا اعرف انى فيه كلمه جديده هتبدء بحرف اقوم طالع على ال ايف الا فوقى ومخلى اول حرف كابتل وبعدين انزل على ال الالس تانى افضل مخلى الحروف  صغيره لحد ما اوصل لمسافه اعرف انى فيه كلمه جديده هتبدء اقوم طالع على الايف اكبر اول حرف فيه وبعدين انزل على الالس وهاكذا لحد ما الجمله الا اليوزر مدخلها تخلصه
                    s1 += c.ToString().ToLower();
                    flag = c == ' ';
            }
            return s1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(InitCaps("mahmoud ahmed abd elftah elshhaly"));
            Console.ReadKey();
        }
    }
}
