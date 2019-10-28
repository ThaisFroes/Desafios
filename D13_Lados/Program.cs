using System;

namespace D13_Lados
{
    class Program
    {
        static void Main(string[] args)
        {
            int lado1=0;
            int lado2=0;
            int c3=0;
            

            Console.WriteLine("Digite o 1º número: ");
            lado1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 2º número: ");
            lado2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 3º número: ");
            c3 = int.Parse(Console.ReadLine());

            if(c3 < (lado1 + lado2)){
                Console.WriteLine("Os lados fazem parte de um triangulo!");
            
            }
        }
    }
}
