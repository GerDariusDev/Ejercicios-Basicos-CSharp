namespace P3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            int opcion = 0;

            while (opcion != 5)
            {
                try
                {
                    Console.WriteLine("(1)Sumar");
                    Console.WriteLine("(2)Restar");
                    Console.WriteLine("(3)Multiplicar");
                    Console.WriteLine("(4)Dividir");
                    Console.WriteLine("(5)Salir");
                    opcion = int.Parse(Console.ReadLine());
                


                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese primer valor:");
                        double val1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese segundo valor:");
                        double val2 = double.Parse(Console.ReadLine());
                        Suma(val1, val2);
                        break;

                    case 2:
                        Console.WriteLine("Ingrese primer valor:");
                        double val3 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese segundo valor:");
                        double val4 = double.Parse(Console.ReadLine());
                        Resta(val3, val4);
                        break;
                    case 3:
                        Console.WriteLine("Ingrese primer valor:");
                        double val5 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese segundo valor:");
                        double val6 = double.Parse(Console.ReadLine());
                        Multiplicar(val5, val6);
                        break;
                    case 4:
                        Console.WriteLine("Ingrese primer valor:");
                        double val7 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese segundo valor:");
                        double val8 = double.Parse(Console.ReadLine());
                        if (val8 == 0) { Console.WriteLine("No se puede dividir por 0"); break; }
                        Dividir(val7, val8);
                        break;
                    

                }
                }
                catch (FormatException) { Console.Clear(); }
            }

            

        }
        
        static void Suma (double v1, double v2)
        {
            Console.WriteLine(v1 + v2);
        }
        static void Resta (double v1, double v2)
        {
            Console.WriteLine(v1 - v2);
        }
        static void Multiplicar (double v1, double v2)
        {
            Console.WriteLine(v1 * v2);
        }
        static void Dividir (double v1, double v2)
        {
            Console.WriteLine(v1 / v2);
        }


        
    }
}
