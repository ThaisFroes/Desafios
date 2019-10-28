using System;

namespace D4_ImparPar
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Impar ou Par!?");
            System.Console.WriteLine();
            System.Console.WriteLine("Digite um Número: ");
            num =  int.Parse(Console.ReadLine());

            if(num !=0){
                if(num % 2 == 0){
                    System.Console.WriteLine("O número é par: ");
                }else{
                    System.Console.WriteLine("Onúmero é impar");
                }
            }while(num != 0);
        }
    }
}
