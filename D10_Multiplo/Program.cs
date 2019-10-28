using System;

namespace D10_Multiplo
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            scanf("%d",&numero);
            if (((numero % 3)==0)){
            printf("O NUMERO E DIVISIVEL\n");
            }
            else{
            printf("O NUMERO NAO E DIVISIVEL\n");
            }
            return 0;
        }
    }
}
