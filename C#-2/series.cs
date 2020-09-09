using System;

namespace myApp
{
    class Program
    {
        static void Main()
        {
            for (int j = 0; j < 10; ++j) {
                for (int i = 0; i < j; ++i)
                    Console.Write(7);
                Console.WriteLine();
            }
        }
    }
}
