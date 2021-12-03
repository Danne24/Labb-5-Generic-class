using System;

namespace Labb_5___Generic_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Check2<double> object1 = new Check2<double>();
            object1.ToCheck(81.39, 81.39);

            Console.WriteLine(" ");

            Check2<ulong> object2 = new Check2<ulong>();
            object2.ToCheck(13989318913983198, 19198181818818);

            Console.WriteLine(" ");

            Check3<string> object3 = new Check3<string>();
            object3.ToCheck("Cogito, ergo sum", "Cogito, ergo sum");

            Console.WriteLine(" ");

            Check3<char> object4 = new Check3<char>();
            object4.ToCheck((char)181, '4');

            Console.ReadKey();
        }
    }
}
