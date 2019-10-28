using System;

namespace D11_OrdemAlfa{

class Program
{
        static void Main(string[] args){
        
        int i,j,  nome, temp,


        for(i=0;i<2;i++){
        printf("Digite uma palavra: ");
        gets(nome[i]);
        }


        for(j = 0; j < i; j++){
                if((strcmp(nome[j],nome[j+1 >o]))){
                strcpy(nome[j+1],temp);
                strcpy(nome[j],nome[j+1]);
                strcpy(temp, nome[j]); 
            }
            }
        


        for (i=0;i<5;i++){
            for(j=0;j<2;j++){
                printf("%s",nome[i][j]);
                }    
            } 
        }
    }
}
