#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <conio.h>

/*
Escreva um programa que imprima todos os n�meros de -0 a X, por�m, para m�ltiplos de 3 imprima �Jovens� 
e para m�ltiplos de 5 imprima �G�nios� no lugar dos n�meros. Para n�meros m�ltiplos de ambos(3 e 5), 
imprima �Jovens G�nios�.
*/


void Algoritimo (int quantidade)
{
	int i;
	for ( i = 0; i <= quantidade; i++ ) 
	{
		if (i%3==0&&i%5==0)
		{
			printf("Jovens Genios \n");
			
		} else if(i%5==0)
		{ 	  	  
			printf("Genios \n");
		} else if(i%3==0)
		{
   	  	    printf("Jovens \n");
		}else
		{
			printf("%d \n", i);
		}
	}
}


int main(int argc, char** argv)
{
	int x;
	printf("Digite um numero inteiro:");
	scanf("%d", &x);
	Algoritimo(x);
	return 0;
}