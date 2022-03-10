using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in Addnumtoarray(arr))
            {
            Console.WriteLine(item);

            }
           
        }

        static int[] Addnumtoarray(int[] arr,int num)
        {           
                       
            int max = arr.Length - 1;//bu arrayin en sonuncu elementidir
            for (int i = 0; i < arr.Length; i++)
            {
                
                num = arr[max+1];
            }
            return arr;
        }
    }
}
