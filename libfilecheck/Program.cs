using System;
using libfc;

namespace libfilecheck
{

    //this is test class that will work as a testclass to test changes you made in the libfs
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine(Hash.getMd5("test"));

            Console.ReadKey();
        }
    }
}
