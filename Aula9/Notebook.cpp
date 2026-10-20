#include <iostream>
#include <list>
#include <algorithm>

using namespace std;
int main() {
    // Criar uma lista de inteiros com 5 números (1, 2, 3, 4, 5)
    list<int> numeros = { 1, 2, 3, 4, 5 };

    // Adicionar o número 4 no final da lista
    numeros.push_back(4);

    // Adicionar o número 7 depois da posição 2 (índice 2 + 1)
    auto it = numeros.begin();
    advance(it, 2);
    numeros.insert(it, 7);

    // Verificar se a lista contém o número 8
    it = find(numeros.begin(), numeros.end(), 8);
    bool contem = (it != numeros.end());
    if (contem) cout << "A lista contém o número 8." << endl;
    else cout << "A lista não contém o número 8." << endl;

    // Verificar quantos números são maiores que 4
    int maior = 0;
    for (int num : numeros) 
    {
        if (num > 4) 
            maior++; 
    }
    cout << "Quantidade de números maiores que 4 na lista: " << maior << endl;

    // Verificar quantas vezes o número 3 aparece
    int repete = 0;
    for (int num : numeros) 
    {
        if (num == 3 ) 
            maior++; 
    }
    cout << "O número 3 aparece " << repete << " vezes na lista." << endl;

    // Remover o número 2
    numeros.remove(2);

    // Remover todos os números 4
    numeros.remove(4);

    // Imprimir a lista atualizada
    cout << "Lista atualizada: ";
    for (auto numero : numeros) 
    {
        cout << numero << " ";
    } 
    cout << endl; 
}