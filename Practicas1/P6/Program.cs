namespace P6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double entrada = 1, acumulador = 0;
            int totalnumeros = 0;

            while(entrada != 0)
            {
                Console.WriteLine("Ingrese valor:");
                entrada = double.Parse(Console.ReadLine());
                if (entrada == 0) { break; }
                acumulador += entrada;
                totalnumeros ++;
                Console.WriteLine("Suma de los numeros ingresados hasta el momento:{0}", acumulador);

            }

            Console.WriteLine("Total numeros ingresados:{0}, suma total de sus valores:{1}", totalnumeros, acumulador);
            Console.ReadKey();

        }
    }
}
