using System;
using AreaTask;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Area.AreaCircle(3).ToString());
            Console.WriteLine(Area.AreaTriangle(2, 3, 2));
        }
    }
}
