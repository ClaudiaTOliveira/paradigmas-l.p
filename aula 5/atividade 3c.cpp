#include<conio.h>
#include <stdio.h>
#include <stdlib.h>

int somatorio(int valor){
    
    if(valor == 1){
             return (1);
    }else{
          return (valor + somatorio(valor-1));      
    }
}


void LePositivo(){
    
    int numeros[5];    
    int cont=0;
    
    printf("Entre com os 5 valores.\n");
    for (cont = 0; cont < 5; cont++){
        
        do{
                  scanf("%d",&numeros[cont]);
                  
                  if(numeros <= 0){
                     printf("Entre novamente com um valor POSITIVO.\n");
                  }                         
        }while(numeros[cont] <= 0);
    }
    
    for (cont = 0; cont < 5; cont++){
        
            
        printf("SOMATORIO DE %d ate 1 eh %d\n",numeros[cont],somatorio(numeros[cont]));
    } 
}
int main(){
    
    LePositivo();

    system("PAUSE");
    return 0;    
}
