using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bism allah alrahman alraheem");
            //اللي فوق دي عنوان بداية التكونسول
            //دي أنا باقول للمستخدم من فضلك ادخل اسمك  يبقى لازم اكتب الكونسل .رايت لاين وافتح القوس مع دبل كوتيشن
            // اذن أبدأ بكونسل .رايت لاين وأنفذ بالمتغير أيا كان هو أيه زي اللي موجود بالازرق تحت
            // yes
            Console.WriteLine("please inter your name:");
            //declate avariable تعريف المتغير
            string name = Console.ReadLine();
            //المتغيرات دي زيادة للتجربة فقط أنا مش طالبها من المستخدم أصلا
            string address = "daqahlia";
            char letter = '8';
            int number = 8;

            int firstnumber, socndnumber;
            //أنا دلوقتي عايز المستخدم يدخل الرقمين اللي عرضتهم فوق
            //  العرض لليوسر ده باقوله الكونسل .رايت لاين ممكن نختصرها سي دابليو وبعدين دبل تاب
            Console.WriteLine("pleas enter the first number");
            // واللي يخلي المستخدم يدخل حاجه هي Console.ReadLine();
            firstnumber =int.Parse( Console.ReadLine());
            Console.WriteLine("pleas enter the second number");
            //هيا اللي بتحول سترنج لأي شئ تاني Parse
            socndnumber = int.Parse(Console.ReadLine());
            //أدوس على زرار تاب مرتين بعد مااكتب سي و دابليو علشان يفتحلي رايت لاين
            Console.WriteLine("ahlan {0} , you live in {1} , the sum resurt is {2}",name,address,firstnumber+socndnumber);
        }
    }
}
