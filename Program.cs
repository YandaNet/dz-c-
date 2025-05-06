namespace dz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width;
            char symbol;
            Console.WriteLine("Enter dov");
            width = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter symbol");
            symbol = char.Parse(Console.ReadLine());
            Kvadrat(width, symbol);
        }

        static void Kvadrat(int dovzyna, char symbol)
        {
            for (int i = 0; i < dovzyna; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < dovzyna; j++)
                {
                    Console.Write(symbol);
                }
            }
        }
    }
}
