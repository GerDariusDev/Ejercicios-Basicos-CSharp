namespace P4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ingrese una palabra:");
            string pal = Console.ReadLine();
            string palabra = pal.ToLower();

            char[] vocalespalabra = RetornoFuncion(palabra);

            foreach(char puntero in vocalespalabra)
            {
                if (puntero != '\0') // Evitar imprimir espacios vacios del vector
                {
                    Console.WriteLine("Las vocales dentro de la palabra son:{0}", puntero);
                }
            }


        }

        static char[] RetornoFuncion (string pal)
        {
            int sector = 0;
            char[] vocales = new char[pal.Length];
            foreach (char puntero in pal)
            {
                if (puntero == 'a' || puntero == 'e' || puntero == 'i' || puntero == 'o' || puntero == 'u')
                {
                    vocales[sector] = puntero;
                    sector++;
                }
            }

            return vocales;
        }
    }
}
