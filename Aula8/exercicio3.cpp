#include <iostream>
#include <iomanip>
#include <vector>
#include <algorithm>
#include <string>
#include <random>
#include <ctime>
#include <cstdlib>

using namespace std;

struct livro
{
    string Autor, Titulo;
    int NumeroPaginas, AnoPublicacao;
    float Preco;
};

vector<livro> livros(3);
int main()
{
    cout << "Registre as informacoes de tres livros: \n \nLivro 1:" << endl;
    cout << "Autor: ";                  cin >> livros[0].Autor;
    cout << "Titulo: ";                 cin >> livros[0].Titulo;
    cout << "Preco: ";                  cin >> livros[0].Preco;
    cout << "Ano Publicado: ";          cin >> livros[0].AnoPublicacao;
    cout << "Quantidade de Paginas: ";  cin >> livros[0].NumeroPaginas;

    cout << "\n \nLivro 2:" << endl;
    cout << "Autor: ";                  cin >> livros[1].Autor;
    cout << "Titulo: ";                 cin >> livros[1].Titulo;
    cout << "Preco: ";                  cin >> livros[1].Preco;
    cout << "Ano Publicado: ";          cin >> livros[1].AnoPublicacao;
    cout << "Quantidade de Paginas: ";  cin >> livros[1].NumeroPaginas;

    cout << "\n \nLivro 3:" << endl;
    cout << "Autor: ";                  cin >> livros[2].Autor;
    cout << "Titulo: ";                 cin >> livros[2].Titulo;
    cout << "Preco: ";                  cin >> livros[2].Preco;
    cout << "Ano Publicado: ";          cin >> livros[2].AnoPublicacao;
    cout << "Quantidade de Paginas: ";  cin >> livros[2].NumeroPaginas;

    int media = (livros[0].NumeroPaginas + livros[1].NumeroPaginas + livros[2].NumeroPaginas)/3;
    float precoTotal = livros[0].Preco + livros[1].Preco + livros[2].Preco;

    cout << "Preco total dos tres livros: " << precoTotal << endl;
    cout << "Media de paginas dos tres livros: " << media << endl;
}