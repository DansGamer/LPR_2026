#include <iostream>
#include <iomanip>
#include <vector>
#include <string>
#include <random>
#include <ctime>
#include <cstdlib>

using namespace std;

void Invert(int n)
{
    int a = 0;
    while(n > 0)
    {
        a *= 10;
        a += n % 10;
        n = n/10;
    }
    cout << "O numero quando invertido e: " << a << endl;
}

int main()
{
    int num = 0;
    cout << "Insira o numero que voce quer que seja invertido: ";
    cin >> num;
    Invert(num);
}