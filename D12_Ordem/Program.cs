using System;

namespace D12_Ordem
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador, contador2 = 0;
            int[] vetor = new int[3];

            for (contador = 0; contador < 3; contador++)
            {
                Console.Write("Informe o numero: ");
                vetor[contador] = int.Parse(Console.ReadLine());
            }            

            Array.Sort(vetor);

            for (contador = 2; contador >= 0; contador--) 
            {
                Console.Write("\nO " + (contador + 1) + "º número é: ");                
                Console.Write(vetor[contador2]);
                contador2++;
            }            
            Console.ReadKey();
        }
    }
}
