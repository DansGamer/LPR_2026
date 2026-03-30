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
    random_device numAleatorio;
    uniform_int_distribution<> distribuicao(1,100);
    int valorInteiro = distribuicao(numAleatorio);
    bool correct = false;
    int tentativas = 0;

    do 
    {
        int Guess;
        cout << "Insira seu chute: ";
        cin >> Guess;

        if(Guess > valorInteiro)
        cout << endl << "Chutou alto!" << endl;
        else if(Guess < valorInteiro)
        cout << endl << "Chutou baixo!" << endl;
        else
        {
            cout << endl << "Acertou!" << endl;
            correct = true;
        }

        tentativas++;
    }   while(!correct);

    cout << "Voce usou " << tentativas << " tentativas para acertar o numero!";
}