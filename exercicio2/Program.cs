using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio = 0;
            Console.WriteLine("digite o valor do raio:");
            raio = double.Parse(Console.ReadLine());
            Console.WriteLine("a área do circulo é:{0}", Math.PI * Math.Pow(2, raio));
            Console.ReadKey();
        }
    }
}
