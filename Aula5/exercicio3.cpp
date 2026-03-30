#include <iostream>
#include <iomanip>
#include <vector>
#include <string>
#include <random>
#include <ctime>
#include <cstdlib>

using namespace std;

int main()
{
    int a = 50;
    int acumulador = 0;
    for(int i = 50; i < 500; i += 1)
    {
        if(a % 3 == 0 && a % 2 != 0)
            acumulador += a;
        a +=1;
    }
    cout << "A soma de todos os numeros impares e multiplos de 3, entre 50 e 500 e igual a: " << acumulador;
}