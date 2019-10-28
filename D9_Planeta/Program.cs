using Internal;
using System;

namespace D9_Planeta
{
    class Program
    {
        static void Main(string[] args)
        {
            int peso, escolha, num;

            do{
            System.Console.WriteLine("Digite um peso ");
            peso = int.Parse(Console.ReadLine());
            Console.WriteLine("Agora digite uma opção");
            System.Console.WriteLine("1- para Mercúrio" );
            System.Console.WriteLine("2- para Vênus");
            System.Console.WriteLine("3- para Marte");
            System.Console.WriteLine("4- para Júpiter");
            System.Console.WriteLine("5- para Saturno");
            System.Console.WriteLine("6- para Urano");
            escolha = int.Parse(Console.ReadLine());

            num  = (peso / 9,8);


            switch(escolha){
                case "1":
                resultado = peso * 0,37 
                System.Console.WriteLine("Este peso em Mercúrio é: " + );
                

                case "2":
                resultado = peso * 0,88 
                System.Console.WriteLine("Este peso em Vênus é: " + );

                case "3":
                resultado = peso * 0,38 
                System.Console.WriteLine("Este peso em Marte é: " + );

                case "4":
                resultado = peso * 2,64 
                System.Console.WriteLine("Este peso em Júpiter é: " + );

                case "5":
                resultado = peso * 1,15 
                System.Console.WriteLine("Este peso em Saturno é: " + );

                case "6":
                resultado = peso * 1,17 
                System.Console.WriteLine("Este peso em Urano é: " + );

                default:
                Console.WriteLine("Operação Invalida!");
                break;
            }
            

            } 
        }
    }
}
