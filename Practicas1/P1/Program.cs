namespace P1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ingrese su nombre y Apellido:");
            string nomyape = Console.ReadLine();
            Console.WriteLine("Ingrese su edad:");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su DNI:");
            double dni = double.Parse(Console.ReadLine());

            Console.WriteLine("Nombre y Apellido: {0} ({1}), DNI: {2}", nomyape, edad, dni);

        }
    }
}
