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
    public class Produto
    {
        string nome {get;}
        double preco {get;}

        public Produto(string n, double p)
        {
            this.nome = n;
            this.preco = p;
        }

        public string Nome()
        {
            return nome;
        }

        public double Preco()
        {
            return preco;
        }
    }

    public class Pedido
    {
        List<Produto> produtos {get; set;} = new List<Produto>();
        int quantidades {get; set;}

        void QuantidadeCalc()
        {
            quantidades = produtos.Count();
        }

        public void AddProduto(Produto p)
        {
            produtos.Add(p);
        }

        public void Show()
        {
            double total = 0;
            Console.WriteLine($"O pedido consiste em: ");
            foreach(Produto p in produtos)
            {
                Console.WriteLine(p.Nome());
                total += p.Preco();
            }
            Console.WriteLine($"O valor total é R${total}");
            Console.WriteLine($"Há {produtos.Count} produtos no carrinho");
        }

        public Pedido(){}
    }
    public class Load()
    {
        static void Main()
        {
            Pedido p = new Pedido();
            Console.WriteLine("Pedido gerado!");
            Console.WriteLine("Bem-vindo ao sistema, insira as informações do produto que você deseja comprar!");
            string Resposta = "y";
            while(Resposta == "y")
            {
                Console.WriteLine("Insira o nome:");
                string Nome = Console.ReadLine();

                double Preco = 0;
                Console.WriteLine("Nome Cadastrado!");
                Console.WriteLine("Insira o preço:");
                string PrecoString = Console.ReadLine();

                if(double.TryParse(PrecoString, out Preco))
                {
                    Console.WriteLine("Preço processado!");
                    Console.WriteLine("Deseja criar mais produtos?");
                    Produto newProduct = new Produto(Nome, Preco);
                    p.AddProduto(newProduct);
                    Console.WriteLine("Responda 'y' se sim, ou qualquer coisa para não.");
                    Resposta = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("O preço não pode ser convertido em número...");
                    break;
                }  
            }
            Console.WriteLine("Exibindo informações...");
            p.Show();
            Console.WriteLine("Encerrando programa, obrigado por nos escolher!");
        }
    }
}