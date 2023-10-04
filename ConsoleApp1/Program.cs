class Program
{
    static void Main(string[] args)
    {
        int a;
        int b;
        int c;
        Console.WriteLine("nhap canh a:");
        a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("nhap canh b:");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("nhap canh c:");
        c = Convert.ToInt32(Console.ReadLine());
        if (a < 0 || b < 0 && c < 0)
        {
            Console.WriteLine("ba so da nhap khong tao thanh tam giac");
        }
        else if ((a + b) > c && (a + c) > b && (b + c) > a)
        {
            Console.WriteLine("ba so da nhap tao thanh tam giac");
        }
        if (a == b && b != c)
        {
            Console.WriteLine("ba so tao ra tam giac can");
        }
        else if (a == b && b == c)
        {
            Console.WriteLine("ba so tao ra tam giac deu");
        }
        else if (a*a + b*b == c*c)
        {
            Console.WriteLine("ba so tao ra tam giac vuong");
        }
        else if (a == b && a * a + b * b == c * c)
        {
            Console.WriteLine("ba so tao ra tam giac vuong can");
        }
        else
        {
        }
    }
}
        