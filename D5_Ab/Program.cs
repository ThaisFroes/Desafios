using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace D5_Ab
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;


            System.Console.WriteLine("Digite uma variavel para o valor A: ");
            a= int.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite uma variavel para o valor B: ");
            b= int.Parse(Console.ReadLine());
            
            System.Console.WriteLine("Novo valor de A é: " + b);
            System.Console.WriteLine("Novo valor de B é: "+ a);
        }
    }
}
