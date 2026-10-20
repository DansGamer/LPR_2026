#include <iostream>
#include <iomanip>
#include <vector>
#include <algorithm>
#include <string>
#include <random>
#include <ctime>
#include <cstdlib>
#include <list>

using namespace std;

list<string> nomes;
int Size = 0;

int main()
{
    //cout << "Insira quantos nome serao inseridos: " << endl;
    cin >> Size;

    for(int i = 0; i < Size; i++)
    {
        string temp;
        //cout << "Nome " << i + 1 << ": ";
        cin >> temp;
        nomes.push_back(temp);
    }

    int maxLength = 0;

    for(string nome : nomes)
    {
        if(nome.length() > maxLength)
        {
            maxLength = nome.length();
        }
    }

    while(nomes.size() != 0)
    {
        cout << endl;
        for(int j = 1; j <= maxLength; j++)
        {
            for(string nome : nomes)
            {
                auto it = find(nomes.begin(), nomes.end(), nome);
                if(nome.length() == j)
                {
                    cout << nome << " ";
                    nomes.erase(it);
                    break;
                }
            }
        }
    }
}