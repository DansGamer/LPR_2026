#include <iostream>
#include <iomanip>
#include <vector>
#include <string>
#include <random>
#include <ctime>
#include <cstdlib>

using namespace std;

int soma = 0, input = 0;

void Ex1()
{
    int actuallyCounted = 0;
    double media = 0;
    
    cout << "Insira quantos numeros existirao no conjunto: " << endl;
    cin >> input;
    for(int i = 0; i != input; i++)
    {
        cout << endl << "Insira um numero: " << endl;
        cin >> input;

        if(input % 2 == 0)
        {
            actuallyCounted++;
            soma += input;
        }
    }

    media = (double)soma/(double)actuallyCounted;
    cout << "A media entre os numeros pares e de: " << media << endl;
}

void Ex3()
{
    for(int i = 51; i < 500; i += 3)
    {
        if(i % 2 != 0)
            soma += i;
    }
    cout << "A soma de todos os numeros impares e multiplos de 3, entre 50 e 500 e igual a: " << soma;
}

void Ex4()
{
    cout << "Insira o numero que você quer descobir a soma dos digitos de seu quadrado: " << endl;
    cin >> input;
    int Num = input * input;
    while(Num > 0)
    {
        int a = Num % 10;
        Num = Num/10;
        soma += a;
    }
            
    cout << "A soma dos digitos do quadrado desse numero e igual a " << soma << endl;
}

int main()
{
    bool Exit = false;

    while(!Exit)
    {
        cout << endl << "Bem-vindo! Escolha qual dos exercicios voce deseja utilizar!" << endl << "Exercicio 1 : Opção 0" << endl << "Exercicio 3 : Opção 1" << endl << "Exercicio 4 : Opção 2"<< endl << "Sair : Opção 3"<< endl;
        cin >> input;
        if(input == 0)
            Ex1();
        else if(input == 1)
            Ex3();
        else if(input == 2)
            Ex4();
        else if(input == 3)
            Exit = true;
        else
            cout << "Digite um numero valido!";
    }
    cout << endl << "Adeus!";
}