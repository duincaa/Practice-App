using System;

namespace Practice_App
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(maths(input,10, 5));
        }
        static int maths(string op, int numberone, int numbertwo)
        {
            if (op == "add")
            {
                return numberone + numbertwo;
            }
            else if (op == "subtract")
            {
                return numberone - numbertwo;
            }
            else if (op == "multiply")
            {
                return numberone * numbertwo;
            }
            return 1;
        }
    }
}
