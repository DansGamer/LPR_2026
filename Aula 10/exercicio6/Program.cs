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
    public class Reserva
    {
        string cliente {get;}
        int numReserva {get;}

        public Reserva(string n, int r)
        {
            this.cliente = n;
            this.numReserva = r;
        }

        public string Nome()
        {
            return cliente;
        }

        public int NumReserva()
        {
            return numReserva;
        }
    }

    public class Cliente
    {
        string Nome {get; set;} = "Daniel";
        List<Reserva> reservas {get; set;} = new List<Reserva>();

        public void GerarReserva()
        {
            reservas.Add(new Reserva(Nome, reservas.Count));
            Console.WriteLine($"Reserva {reservas.Count} Cadastrado!");
        }

        public void Show()
        {
            int i = 1;
            Console.WriteLine($"As reservas do cliente {Nome} são: ");
            foreach(Reserva r in reservas)
            {
                Console.WriteLine($"Reserva {i} - {r.Nome()}");
                i++;
            }
        }
    }
    public class Load()
    {
        static void Main()
        {
            Cliente c = new Cliente();
            Console.WriteLine("Cliente gerado!");
            Console.WriteLine("Bem-vindo ao sistema, primeira reserva é feita automaticamente!");

            string Resposta = "y";
            while(Resposta == "y")
            {
                c.GerarReserva();
                Console.WriteLine("Deseja criar mais reservas?");
                Console.WriteLine("Responda 'y' se sim, ou qualquer coisa para não.");
                Resposta = Console.ReadLine(); 
            }

            Console.WriteLine("Exibindo informações...");
            c.Show();
            Console.WriteLine("Encerrando programa, obrigado por nos escolher!");
        }
    }
}