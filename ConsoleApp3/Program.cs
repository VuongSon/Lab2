
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\na)");
        int i, j;
        for (i = 1; i <= 6; i++)
        {
            Console.WriteLine();
            for (j = 1; j <= i; j++)
            {
                Console.Write("*");
            }         
        }
        Console.WriteLine("\nb)");
        for (i = 6; i >= 1; i--)
        {
            Console.WriteLine();
            for(j = 1; j <= i; j++)
            {
                Console.Write("$");
            }
        }
        Console.WriteLine("\nc)");
        for( i = 0; i <=5; i++)
        {
            Console.WriteLine();
            for(j = 1; j <= 11; j++)
            {
                if( j >= 6 - i && j <= 6 + i)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
        }
    }
}