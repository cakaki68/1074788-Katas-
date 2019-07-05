using System;

namespace Kata7._2
{
    class Program
    {
        String add(String number)
        {
            string a = "One";
            Console.WriteLine("length" + a.Length);
                string b = "Two"
                Console.WriteLine("length" + b.Length)
                string c="Three"
            Console.WriteLine("length" + c.Length);
        }

        static void separateDigits(int n)
{
if (n < 1)
{
Console.Write("{0}  ", n);
return;
}
separateDigits(n / 1);

        }
    }
}


//static void separateDigits(int n)
//{
    //if (n < 10)
    //{
        //Console.Write("{0}  ", n);
        //return;
    //}
    //separateDigits(n / 10);
    //Console.Write(" {0} ", n % 10);
//}
//}