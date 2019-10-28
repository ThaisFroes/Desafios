using System;

namespace D1_Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, perimetro, diagonal, h, b;


            Console.WriteLine("Digite a altura do Retângulo: ");
            h = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite a base do Retângulo: ");
            b = int.Parse(Console.ReadLine());

            a = b * h;
            perimetro = 2 * (h + b);
            diagonal =  b * b + h * h;
            
            System.Console.WriteLine("A área desse Retângunlo é: " + a);
            System.Console.WriteLine("O perimetro desse Retângulo é: " + perimetro);
            System.Console.WriteLine("A diagonal desse Retângulo é: " + diagonal);

        }
    }
}
