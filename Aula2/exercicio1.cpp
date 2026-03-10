#include <iostream>
#include <iomanip>
#include <vector>
#include <string>

using namespace std;

int main()
{
    const double pi = 3.14159;
    float raio;

    cout << "Bem vindo a calculadora de area" << endl << "Insira o valor de um raio de um circulo em metros" << endl;
    cin >> raio;

    double area = 2 * raio * pi;

    cout << "A area desse circulo e de: " << fixed << setprecision(4) << area << "m" << endl;
}