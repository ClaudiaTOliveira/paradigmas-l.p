#include <iostream>
#define MAX 5

using namespace std;
int numero;

void MaiorNumero(int nu1, int nu2);

int main()
{
    int numero1 = 0,
      numero2 = 0;
	int cont=0;
do {
	
	 for (int i=0; i<MAX; i++)
    {
        cout << "Informe 2 numeros" << endl;
        cin >> numero1;
        cin >> numero2;

        MaiorNumero(numero1, numero2);
    }
    cont++;
} while(cont==10);
    return 0;
}

void MaiorNumero(int nu1, int nu2)
{
    if(nu1 > nu2)
        cout << "Maior numero digitado " << nu1 << endl;
    else
        if(nu2 > nu1)
            cout << "Maior numero digitado " << nu2 << endl;
        else
            cout << "Numeros sao iguais"<<endl;
}


   
