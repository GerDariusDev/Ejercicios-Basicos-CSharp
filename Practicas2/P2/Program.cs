using System;
using System.Collections;
namespace P2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            List<string> palabras = new List<string>(); //Array unicamente para strings (System.Collections)
            string ingreso = "x";
            double s = 0, cantpalabras = 0, caracteres = 0, longitud, porcentaje, promedio;

            while (ingreso != "")
            {
                Console.WriteLine("Ingrese palabra: ");
                ingreso = Console.ReadLine();

                if (ingreso == "") { break; }
                
                if (ingreso[0] == 's' || ingreso[0] == 'S') { s++; }

                longitud = 0;
                foreach (char puntero in ingreso)
                {
                    longitud++;
                    caracteres++;
                }
                Console.WriteLine("Longitud de palabra ingresada:{0}", longitud);
                
                palabras.Append(ingreso);
                
                cantpalabras++;
                
            }

            porcentaje = (s / cantpalabras) * 100;
            promedio = caracteres / cantpalabras;
            Console.WriteLine("Porcentaje de palabras que comienzan con S : %{0}", porcentaje);
            Console.WriteLine("Promedio de caracteres por palabras : {0}", promedio);

            Console.ReadKey();
        }
    }
}
