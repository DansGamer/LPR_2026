#include <iostream>
#include <iomanip>
#include <vector>
#include <string>

using namespace std;

int main()
{
    int a = 0;
    int b = 0;
    int c = 0;
    int d = 0;

    cout << "Bem vindo" << endl << "Insira o primeiro valor inteiro: " << endl;
    cin >> a;
    cout << "Insira o segundo valor inteiro: " << endl;
    cin >> b;
    cout << "Insira o terceiro valor inteiro: " << endl;
    cin >> c;
    cout << "Insira o quarto valor inteiro: " << endl;
    cin >> d;

    int resultado = a * b - c * d;

    cout << "A diferenca do produto de A e B pelo produto de C e D e de: " << resultado << endl;
}