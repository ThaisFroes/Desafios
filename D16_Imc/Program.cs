using System;

namespace D16_Imc
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura, peso, imc;

            Console.WriteLine("Digite o seu peso: ");
            peso = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite a sua altura: ");
            altura = double.Parse(Console.ReadLine());

            imc = peso / (altura * altura);
            System.Console.WriteLine("O seu IMC é "+ imc);

            if (imc <20){
                System.Console.WriteLine("Abaixo do peso");
            }else if ((imc >=20) && (imc <26)){
                System.Console.WriteLine("Normal");
            }else if ((imc >=25) && (imc <31)){
                System.Console.WriteLine("Excesso de peso");
            }else if ((imc >=30) && (imc <36)){
                System.Console.WriteLine("Obsidade");
            }else if ((imc > 35)){
                System.Console.WriteLine("Obsidade Mórbita");
            }Console.ReadKey();
        }
    }
}
