using System;
namespace P1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string pal1 = "", pal2 = "", compara="";
            Console.WriteLine("Ingrese primer palabra: ");
            pal1 = Console.ReadLine();
            Console.WriteLine("Ingrese segunda palabra: ");
            pal2 = Console.ReadLine();


            if (pal1.Length == pal2.Length)
            {
                for (int x = (pal1.Length - 1); x >= 0; x--)
                {
                    compara += pal1[x];
                }

                if (compara == pal2)
                {
                    Console.WriteLine("Son palindromos");
                }
                else { Console.WriteLine("No son palindromos"); }

            }
            else { Console.WriteLine("No son palindromos"); }
        }
    }
}
