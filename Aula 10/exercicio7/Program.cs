using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.IO.Pipelines;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Daniel
{
    public class Livro
    {
        string nome {get;}
        string autor {get;}
        int ano {get;}

        public Livro(string n, string a, int y)
        {
            this.nome = n;
            this.autor = a;
            this.ano = y;
        }

        public string Nome(){return nome;}
        public string Autor(){return autor;}
        public int Ano(){return ano;}
            
    }

    public class Biblioteca
    {
        List<Livro> livros {get; set;} = new List<Livro>();

        public void AdicionarLivro(string n, string a, int y)
        {
            livros.Add(new Livro(n,a,y));
        }

        public void ListarLivros()
        {
            double total = 0;
            Console.WriteLine($"Os livros presentes na biblioteca são: ");
            foreach(Livro l in livros)
            {
                Console.WriteLine($"Título: {l.Nome()} - Autor: {l.Autor()} - Ano Publicado: {l.Ano}");
            }
        }

        public Biblioteca(){}
    }
    public class Load()
    {
        static void Main()
        {
            Biblioteca b = new Biblioteca();
            Console.WriteLine("Biblioteca Criada!");
            Console.WriteLine("Bem-vindo ao sistema, insira as informações do livro que você deseja adicionar!");
            string Resposta = "y";
            while(Resposta == "y")
            {
                Console.WriteLine("Insira o nome:");
                string Nome = Console.ReadLine();
                Console.WriteLine("Nome Cadastrado!");
                Console.WriteLine("Insira o autor:");
                string Autor = Console.ReadLine();
                Console.WriteLine("Autor Cadastrado!");

                int Ano = 0;
                Console.WriteLine("Insira o ano:");
                string AnoString = Console.ReadLine();

                if(int.TryParse(AnoString, out Ano))
                {
                    Console.WriteLine("Ano processado!");
                    Console.WriteLine("Deseja criar mais produtos?");
                    b.AdicionarLivro(Nome,Autor,Ano);
                    Console.WriteLine("Responda 'y' se sim, ou qualquer coisa para não.");
                    Resposta = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("O ano não pode ser convertido em número...");
                    break;
                }  
            }
            Console.WriteLine("Exibindo informações...");
            b.ListarLivros();
            Console.WriteLine("Encerrando programa, obrigado por nos escolher!");
        }
    }
}