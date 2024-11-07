using System;
using System.ComponentModel.Design;
namespace uppgift_3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du?");
            int ålder=int.Parse(Console.ReadLine());
            if (ålder == 16)
            {
                Console.WriteLine("du får gå på gymnasiet");
            }
            else if (ålder == 19)
            {
                Console.WriteLine("du får gå på gymnasiet");
            }
            else if (ålder == 17)
            {
                Console.WriteLine("du får gå på gymnasiet");
            }
            else if (ålder == 18)
            {
                Console.WriteLine("du får gå på gymnasiet");
            }
            else if (ålder > 20)
            {
                Console.WriteLine("Du får inte gå på gymnasiet");
            }
            else if (ålder < 15)
            {
                Console.WriteLine("Du får inte gå på gymnasiet");
            }
            else if(ålder ==15)
            {
                Console.WriteLine("Du får inte gå på gymnasiet");
            }
            else if (ålder ==20)
            {
                Console.WriteLine("Du får inte gå på gymnasiet");
            }
        }
    }
}
