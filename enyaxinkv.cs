using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Enyaxinkv(22));
        }
       static int Enyaxinkv(int num)
        {
            int i = 0;           
            while (i*i <= num)
            {
                i++;
            }
            return i-1;
        }
    }
}
