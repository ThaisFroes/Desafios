using System;

namespace D3_Viagem
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempo, distancia, litros, velocidade;

            Console.WriteLine("Informe o tempo gasto na viagem em horas: ");
            tempo = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Informe a velocidade em KM/H: ");
            velocidade = int.Parse(Console.ReadLine());

            distancia = tempo*velocidade;
            litros = distancia / 12;

            System.Console.WriteLine("A distância percorrida foi: " + distancia);
            System.Console.WriteLine("O consumo de combustivel foi de "+ litros + " litros");

        }
    }
}
