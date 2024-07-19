namespace P5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            for (int x = 40; x >= 40 & x <= 352; x++)
            {
                if (x % 5 == 0 & x % 2 != 0)
                {
                    Console.WriteLine(x);
                }
            }
            Console.ReadKey(true);

        }
    }
}
