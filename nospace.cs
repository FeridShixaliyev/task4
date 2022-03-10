using System;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Nospace("salam dunya"));
        }
        static string Nospace( string str)
        {
            char a =  ' ';
            char b = '';//bu hissesini duzelde bilmedim
            for(int i = 0; i < str.Length; i++)
            {
                if(str[i]==a )
                {
                    a = b;
                }
            }
            return str;
        }
    }
}
