using System
class calculadora  
  
  public static void main ()
{
	
	
}
int  op=0;
float num1=0;
float num2=0;
float resp=0;

do
{
   
    Console.WriteLine(("\nEscolha uma opcao de calculo: ");  
    Console.WriteLine(("\n1 - Multiplicacao \n2 - Soma\n3 - Divisao\n4 - Subtracao \n5 - Sair\n");
		do
		{ 
			op = int Parsearse(Console.ReadLine());
       
			if ((op < 1) || (op>5))
				Console.WriteLine("\nOpcao invalida!!");
		}while ((op < 1) || (op>5));
		
		if (op != 5)
		{
		   Console.WriteLine(("\nDigite um numero: ");
		   num1 = float.Parse(Console.ReadLine() );		   
		   Console.WriteLine(("\nDigite outro numero: ");
		    num2 = float.Parse(Console.ReadLine() );
		}          
		
		switch (op)
        {
			case 1:
				resp= multiplica(num1, num2);
				break;
			case 2:
				resp= soma(num1, num2); 
				break;      
		}
		if (op==5)
			Console.WriteLine("\nPrograma encerrado.....");
		else   
			Console.WriteLine(("\nResultado da operacao escolhida: %.2f",+ resp);
  }while (op !=5);