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
    string Titulo, Diretor;
    int AnoLancamento;
    float Duracao;
};

vector<produto> produtos(3);

int main()
{
    cout << "Registre as informacoes de tres filmes: \n \nFilme 1:" << endl;
    cout << "Titulo: ";                     cin >> produtos[0].Titulo;
    cout << "Diretor: ";                    cin >> produtos[0].Diretor;
    cout << "Ano Lancamento: ";             cin >> produtos[0].AnoLancamento;
    cout << "Duracao: ";                    cin >> produtos[0].Duracao;

    cout << "\n \nFilme 2:" << endl;
    cout << "Titulo: ";                     cin >> produtos[1].Titulo;
    cout << "Diretor: ";                    cin >> produtos[1].Diretor;
    cout << "Ano Lancamento: ";             cin >> produtos[1].AnoLancamento;
    cout << "Duracao: ";                    cin >> produtos[1].Duracao;

    cout << "\n \nFilme 3:" << endl;
    cout << "Titulo: ";                     cin >> produtos[2].Titulo;
    cout << "Diretor: ";                    cin >> produtos[2].Diretor;
    cout << "Ano Lancamento: ";             cin >> produtos[2].AnoLancamento;
    cout << "Duracao: ";                    cin >> produtos[2].Duracao;

    cout << "Os filmes inseridos sao: " << produtos[0].Titulo << ", " << produtos[1].Titulo << " e " << produtos[2].Titulo << endl;
    /*if(produtos[0].AnoLancamento < produtos[1].AnoLancamento && produtos[0].AnoLancamento < produtos[2].AnoLancamento)
    cout << "O filme mais antigo e: " << produtos[0].Titulo;
    else if(produtos[0].AnoLancamento <= produtos[1].AnoLancamento && produtos[0].AnoLancamento < produtos[2].AnoLancamento)
    cout << "Os filmes mais antigos sao: " << produtos[0].Titulo << " e " << produtos[1].Titulo;
    else if(produtos[0].AnoLancamento < produtos[1].AnoLancamento && produtos[0].AnoLancamento <= produtos[2].AnoLancamento)
    cout << "Os filmes mais antigos sao: " << produtos[0].Titulo << " e " << produtos[2].Titulo;
    else if(produtos[0].AnoLancamento <= produtos[1].AnoLancamento && produtos[0].AnoLancamento <= produtos[2].AnoLancamento)
    cout << "Todos filmes foram lancados no mesmo ano";
    else if(produtos[1].AnoLancamento < produtos[0].AnoLancamento && produtos[1].AnoLancamento < produtos[2].AnoLancamento)
    cout << "O filme mais antigo e: " << produtos[1].Titulo;
    else if(produtos[1].AnoLancamento <= produtos[0].AnoLancamento && produtos[1].AnoLancamento < produtos[2].AnoLancamento)
    cout << "Os filmes mais antigos sao: " << produtos[0].Titulo << " e " << produtos[1].Titulo;
    else if(produtos[1].AnoLancamento < produtos[0].AnoLancamento && produtos[1].AnoLancamento <= produtos[2].AnoLancamento)
    cout << "Os filmes mais antigos sao: " << produtos[0].Titulo << " e " << produtos[2].Titulo;*/
}   