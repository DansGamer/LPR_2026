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
    int matriz[4][4] = {{-1, 524, 521, 882}, {524, -1, 434, 586}, {521, 434, -1, 429}, {882, 586, 429, -1}};
    int cidadeA = 0, cidadeB = 0, distancia = 0;
    string nomeA = "", nomeB = "";
    do
    {
        cout << "Escolha a cidade da qual voce saira:" << endl;
        cout << "0 - Vitoria" << endl << "1 - Belo Horizonte" << endl;
        cout << "2 - Rio de Janeiro" << endl << "3 - Sao Paulo" << endl;
        cin >> cidadeA;
        cout << endl << "Escolha a cidade para qual voce ira:" << endl;
        cout << "0 - Vitoria" << endl << "1 - Belo Horizonte" << endl;
        cout << "2 - Rio de Janeiro" << endl << "3 - Sao Paulo" << endl;
        cout << "Obs - Se a mesma cidade for escolhida o programa encerrara!" << endl << endl;
        cin >> cidadeB;
        if(cidadeA >= 0 && cidadeA <= 3 && cidadeB >= 0 && cidadeB <= 3)
        {
            distancia = matriz[cidadeA][cidadeB];
            switch(cidadeA)
            {
                case 0:
                    nomeA = "Vitoria";
                    break;
                case 1:
                    nomeA = "Belo Horizonte";
                    break;
                case 2:
                    nomeA = "Rio de Janeiro";
                    break;
                case 3:
                    nomeA = "Sao Paulo";
                    break;
            }
            switch(cidadeB)
            {
                case 0:
                    nomeB = "Vitoria";
                    break;
                case 1:
                    nomeB = "Belo Horizonte";
                    break;
                case 2:
                    nomeB = "Rio de Janeiro";
                    break;
                case 3:
                    nomeB = "Sao Paulo";
                    break;
            }
            if(distancia != -1)
                cout << "A distancia entre " << nomeA << " e " << nomeB << " e de " << distancia << "km" << endl << endl;
            else
                cout << "Programa encerrado! Adeus!";
        }
        else
            cout << "Entrada invalida, tente novamente!" << endl << endl;
    }while (distancia != -1);
}