using System;

namespace RecursividadeCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Recursividade(0);
        }

        static void Recursividade(int x)
        {
            if (x <= 100)
            {
                Console.WriteLine(x);
                Recursividade(++x);
            }

            return;
        }
    }
}
