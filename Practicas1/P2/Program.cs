namespace P2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ingrese primer numero:");
            double pri = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese segundo numero:");
            double seg = double.Parse(Console.ReadLine());

            double suma = (pri + seg);
            Console.WriteLine("La suma es:{0}", suma);

        }
    }
}
