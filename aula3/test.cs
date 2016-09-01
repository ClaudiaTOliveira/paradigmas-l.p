using System;//sempre//
class test{
	string mensagem;//variavel global//fora do escopo//
	public static void Main()
	{
		//padrao cameCase
		int numero1 = 0;//tipos primitivos
		int numero2 = 0;
		int total = 0;
		
		
		total = somar(100,200);
		
		/*if (total>500){
			mensagem ="deve refazer";
		}
		else{
			mensagem = "abaixo do esperado";
		}*/
		
		
		
		
		
		//mensagem ="a soma de "+ numero1 "mais" + numero2 "e igual a" + total;
		Console.WriteLine(mensagem);
		Console.ReadLine();
		
		static int somar(int numero1, int numero2){
			return numero1+numero2;
		}
	}
}/*
dir-lista o conteudo da pasta
cd..- volta um nivel acima da pasta
 ex. c:\windows\test\cd
 volta para c:\windows\test\
 cd\vai para a raiz do root
 cd nomeDaPasta-acessa a pasta
 cls - limpa o pronpt comando
 ******************************
 compilar um programa C#
 exc:\plp\aula03\csc.exe nomeDoArquivo.cs
 */