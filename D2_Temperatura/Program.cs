using System;

namespace D2_Temperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            int temperaturac, temperaturaf;

            Console.WriteLine("Digite uma temperatura em graus centígrados:");
            temperaturac = int.Parse(Console.ReadLine());

            temperaturaf = (9 * temperaturac + 160) / 5;
            System.Console.WriteLine("Essa temperatura é " + temperaturaf + " graus Fahrenheit");
        }
    }
}
