#include <iostream>
#include <iomanip>
#include <vector>
#include <string>

using namespace std;

int main()
{
    int Number1, Number2;
    cout << "Descubra se dois números inteiros são múltiplos!" << endl;
    cout << "Insira o primeiro número:" << endl;
    cin >> Number1;
    cout << "Insira o segundo número:" << endl;
    cin >> Number2;
    if(Number1 % Number2 == 0 || Number2 % Number1 == 0)
    {
        cout << "Os números " << Number1 << " e " << Number2 << " são múltiplos!" << endl;
    }
    else
    {
        cout << "Os números " << Number1 << " e " << Number2 << " não são múltiplos!" << endl;
    }
}