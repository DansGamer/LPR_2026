#include <iostream>
#include <iomanip>
#include <vector>
#include <algorithm>
#include <string>
#include <random>
#include <ctime>
#include <cstdlib>

using namespace std;

int main()
{
    vector<int> numeros(10), pares(10), impares(10);

    cout << "Digite 10 numeros que serao separados em pares e impares!" << endl;
    for(int i = 0; i < 10; i++)
    {
        cout << "Numero " << i << ": ";
        cin >> numeros[i];
        if(numeros[i] % 2 == 0)
            pares[i] = numeros[i];
        else
            impares[i] = numeros[i];
    }
    sort(pares.begin(), pares.end());
    sort(impares.begin(), impares.end());

    cout << endl << "Os numeros pares desse conjunto sao:" << endl;
    for (int i = 0; i < 10; i++)
    {
        if(pares[i] != 0)
            cout << pares[i] << "; ";
    }

    cout << endl << endl << "Os numeros impares sao:" << endl;
    for (int i = 0; i < 10; i++)
    {
        if(impares[i] != 0)
            cout << impares[i] << "; ";
    }   
}