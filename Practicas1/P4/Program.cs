namespace P4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int acumulador, numero, menor, mayor, vueltas;
            Console.WriteLine("Ingrese un valor inicial distinto de 0: ");
            numero = menor = mayor = int.Parse(Console.ReadLine());
            acumulador = numero;
            vueltas = 0;

            while (numero != 0)
            {
                if (numero < menor) menor = numero;
                if (numero > mayor) mayor = numero;
                Console.WriteLine("Ingrese un numero ó 0 para finalizar:");
                numero = int.Parse(Console.ReadLine());
                acumulador = acumulador + numero;
                vueltas++;
            }

            Console.WriteLine("Menor:" + menor + " Mayor:" + mayor);
            Console.WriteLine("Valor promedio de numeros ingresados: " + (acumulador / vueltas));
            Console.ReadKey(true);
        }
    }
}
