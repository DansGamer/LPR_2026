#include <iostream>
#include <iomanip>
#include <vector>
#include <string>

using namespace std;

int main()
{
    int i = 0;
    int cycles = 0;
    int acumulador = 0;
    int actuallyCounted = 0;
    double media = 0;
    
    cout << "Insira quantos numeros existirao no conjunto: " << endl;
    cin >> cycles;
    while(i != cycles)
    {
        int insert = 0;
        cout << endl << "Insira um numero: " << endl;
        cin >> insert;

        if(insert % 2 == 0)
        {
            actuallyCounted++;
            acumulador += insert;
        }

        i++;
    }

    media = (double)acumulador/(double)actuallyCounted;
    cout << "A media entre os numeros pares e de: " << media << endl;
}