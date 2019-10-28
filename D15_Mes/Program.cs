using System;

namespace D15_Mes
{
    class Program
    {
        static void Main(string[] args)
        {
            string mes;

            Console.WriteLine("Digite um número entre 1 e 12: ");
            mes = Console.ReadLine();

            switch(mes){
                case "1":
                System.Console.WriteLine("Janeiro\n");
                break;

                case "2":
                System.Console.WriteLine("Fevereiro\n");
                break;

                case "3":
                System.Console.WriteLine("Mraço\n");
                break;

                case "4":
                System.Console.WriteLine("Abril\n");
                break;

                case "5":
                System.Console.WriteLine("Maio\n");
                break;

                case "6":
                System.Console.WriteLine("Junho\n");
                break;

                case "7":
                System.Console.WriteLine("Julho\n");
                break;

                case "8":
                System.Console.WriteLine("Agosto\n");
                break;

                case "9":
                System.Console.WriteLine("Setembro\n");
                break;

                case "10":
                System.Console.WriteLine("Outubro\n");
                break;

                case "11":
                System.Console.WriteLine("Novembro\n");
                break;

                case "12":
                System.Console.WriteLine("Dezembro\n");
                break;

                default:
                Console.WriteLine("Operação Invalida!");
                break;
            }
        }
    }
}
