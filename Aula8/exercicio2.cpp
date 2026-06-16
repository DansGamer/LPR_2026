#include <iostream>
#include <iomanip>
#include <vector>
#include <algorithm>
#include <string>
#include <random>
#include <ctime>
#include <cstdlib>

using namespace std;

struct produto
{
    string Codigo, Nome;
    int Quantidade;
    float Preco;
};

vector<produto> produtos(3);

int main()
{
    cout << "Registre as informacoes de tres produtos: \n \nProduto 1:" << endl;
    cout << "Nome: ";                   cin >> produtos[0].Nome;
    cout << "Codigo: ";                 cin >> produtos[0].Codigo;
    cout << "Preco: ";                  cin >> produtos[0].Preco;
    cout << "Quantidade: ";             cin >> produtos[0].Quantidade;

    cout << "\n \nProduto 2:" << endl;
    cout << "Nome: ";                   cin >> produtos[1].Nome;
    cout << "Codigo: ";                 cin >> produtos[1].Codigo;
    cout << "Preco: ";                  cin >> produtos[1].Preco;
    cout << "Quantidade: ";             cin >> produtos[1].Quantidade;

    cout << "\n \nProduto 3:" << endl;
    cout << "Nome: ";                   cin >> produtos[2].Nome;
    cout << "Codigo: ";                 cin >> produtos[2].Codigo;
    cout << "Preco: ";                  cin >> produtos[2].Preco;
    cout << "Quantidade: ";             cin >> produtos[2].Quantidade;

    float valorTotal = produtos[0].Preco * produtos[0].Quantidade + produtos[1].Preco * produtos[1].Quantidade + produtos[2].Preco * produtos[2].Quantidade;
    cout << "\n \nO valor total da mercadoria no estoque e de: R$" << valorTotal << endl;
}