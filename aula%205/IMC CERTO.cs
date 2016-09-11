using System;
using System.Collections.Generic;
using System.Linq;
			
public class Program
{
  public static void Main()
  {
  
   double altura=0;
			 double peso=0;
			 double IMC=0;
			 string resposta="";
			
			Console.WriteLine("*** programa para calcular o imc");
			Console.Write("digite sua altura (m)"); 
			
       altura = float.Parse(Console.ReadLine());
    Console.Write("digite seu peso (kg)"); 
 peso = float.Parse(Console.ReadLine());			
       
  //    Console.WriteLine();
       IMC=	peso/(altura*altura);
    
    
       if(IMC<18.5)
       Console.Write("voce esta abaixo do peso ideal");
       else if ((IMC>=18.5) && (IMC<25))
		   Console.WriteLine("voce esta no peso ideal");
	   else if ((IMC>=25)  && (IMC<30))
		   Console.WriteLine("voce esta com sobrepeso");
	   else if (IMC>30)
		   Console.WriteLine("voce esta obeso");
         }
}
