#include<stdio.h>
#include<conio.h>
int main (){
	int x[10];
	int i=0;
	int cont=0;
	int num;



	for(i=0;i<10;i++) {
		printf("\n digite o vetor da posicao %d",i);
		scanf("%d",&x[i]);
	}
printf("\nb digite o valor procurado");
scanf("%d",& num);
for(i=0;i<10;i++) {
	if(x[i]==num) {
		cont++;
printf("o numero %d aparece %d vezes no vetor",num,cont);
}
}

}
