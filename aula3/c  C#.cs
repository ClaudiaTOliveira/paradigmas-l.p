#include<stdio.h>
#include<conio.h>

float multiplica(float x, float y)
{
 float calc;
 
 calc= x * y;
 return(calc);
}
float soma(float num1, float num2)
{
  float resp;
  resp= num1+num2;
  return(resp);      
}

main()
{
int  op;
float num1, num2, resp;

do{
   
    printf("\nEscolha uma opcao de calculo: ");  
    printf("\n1 - Multiplicacao \n2 - Soma\n3 - Divisao\n4 - Subtracao \n5 - Sair\n");
    do{ 
       scanf("%d", &op);
       if ((op < 1) || (op>5))
            printf("\nOpcao invalida!!");
      }while ((op < 1) || (op>5));
    if (op != 5)
    {
       printf("\nDigite um numero: ");
       scanf("%f", &num1);      
       printf("\nDigite outro numero: ");
       scanf("%f", &num2); 
     }          
    switch (op)
        {
         case 1: resp= multiplica(num1, num2);
              break;
         case 2: resp= soma(num1, num2); 
              break;      
    }
    if (op==5)
       printf("\nPrograma encerrado.....");
    else   
       printf("\nResultado da operacao escolhida: %.2f", resp);
  }while (op !=5);
  getche();
}