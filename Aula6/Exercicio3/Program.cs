using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Daniel
{
    class SelecaoHerois
    {
        static string Nome1, Nome2, Nome3, Nome4, Nome5;
        static string Pontos1, Pontos2, Pontos3, Pontos4, Pontos5;
        static string Poder1, Poder2, Poder3, Poder4, Poder5;

        static int Equipe= 1;

        static void Main()
        {
            menuPrincipal();
        }
        static void menuPrincipal()
        {
            bool NotExit = true;
            while (NotExit)
            {
                Console.WriteLine("Bem-vindo ao sistema de seleção de heróis");
                Console.WriteLine("Digite o numero da função que você deseja executar:");
                Console.WriteLine("1) Cadastro de Heróis");
                Console.WriteLine("2) Seleção de Equipe");
                Console.WriteLine("3) Exibição de Equipe");
                Console.WriteLine("4) Sair");
                string escolha = Console.ReadLine();
                int number = 0;
                if(int.TryParse(escolha, out number))
                {
                    switch(number)
                    {
                        case 1:
                            cadastrarHeroi();
                            break;
                        case 2:
                            selecionarEquipe();
                            break;
                        case 3:
                            exibirEquipe();
                            break;
                        case 4:
                            NotExit = false;
                            Console.WriteLine("Adeus!");
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Escolha inválida");
                            break;
                    }
                    
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Escolha inválida");
                } 
            }
        }
    
 
        static void cadastrarHeroi()
        {
            Console.Clear();
            Console.WriteLine("Quantos heróis você desejar cadastrar (até 5 são permitidos!):");
            string escolha = Console.ReadLine();
            int number = 0;
            if(int.TryParse(escolha, out number) && number > 0 && number <= 5)
            {
                if(number >= 1)
                {
                    Console.WriteLine("Insira o nome do primeiro herói:");
                    Nome1 = Console.ReadLine();
                    Console.WriteLine("Insira a pontuação do primeiro herói:");
                    Pontos1 = Console.ReadLine();
                    Console.WriteLine("Insira o poder do primeiro herói:");
                    Poder1 = Console.ReadLine();
                }
                if(number >= 2)
                {
                    Console.WriteLine("Insira o nome do segundo herói:");
                    Nome2 = Console.ReadLine();
                    Console.WriteLine("Insira a pontuação do segundo herói:");
                    Pontos2 = Console.ReadLine();
                    Console.WriteLine("Insira o poder do segundo herói:");
                    Poder2 = Console.ReadLine();
                }
                if(number >= 3)
                {
                    Console.WriteLine("Insira o nome do terceiro herói:");
                    Nome3 = Console.ReadLine();
                    Console.WriteLine("Insira a pontuação do terceiro herói:");
                    Pontos3 = Console.ReadLine();
                    Console.WriteLine("Insira o poder do terceiro herói:");
                    Poder3 = Console.ReadLine();
                }
                if(number >= 4)
                {
                    Console.WriteLine("Insira o nome do quarto herói:");
                    Nome4 = Console.ReadLine();
                    Console.WriteLine("Insira a pontuação do quarto herói:");
                    Pontos4 = Console.ReadLine();
                    Console.WriteLine("Insira o poder do quarto herói:");
                    Poder4 = Console.ReadLine();
                }
                if(number >= 5)
                {
                    Console.WriteLine("Insira o nome do quinto herói:");
                    Nome5 = Console.ReadLine();
                    Console.WriteLine("Insira a pontuação do quinto herói:");
                    Pontos5 = Console.ReadLine();
                    Console.WriteLine("Insira o poder do quinto herói:");
                    Poder5 = Console.ReadLine();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Escolha inválida");
            }

            Console.WriteLine("\n Aperte Enter pra prosseguir");
            Console.ReadLine();
            Console.Clear();
        }

        static void selecionarEquipe()
        {
            bool Valid1 = false, Valid2 = false, Valid3 = false;
            int number = 0;
            Console.Clear();
            Console.WriteLine("Quais heróis você deseja selecionar para a missão (Escolha 3):");
            Console.WriteLine($"1){Nome1}, Poder: {Poder1}; Pontos: {Pontos1}");
            Console.WriteLine($"2){Nome2}, Poder: {Poder2}; Pontos: {Pontos2}");
            Console.WriteLine($"3){Nome3}, Poder: {Poder3}; Pontos: {Pontos3}");
            Console.WriteLine($"4){Nome4}, Poder: {Poder4}; Pontos: {Pontos4}");
            Console.WriteLine($"5){Nome5}, Poder: {Poder5}; Pontos: {Pontos5}");
            while(!Valid1)
            {
                Console.Write("Escolha 1: "); string escolha1 = Console.ReadLine(); 
                if(int.TryParse(escolha1, out number) && number > 0 && number <= 5) Valid1 = true;
                else{Console.Clear(); Console.WriteLine("Escolha inválida");}
            }
            switch(number)
            {
                case 1:
                    Equipe *= 2;
                    break;
                case 2:
                    Equipe *= 3;
                    break;
                case 3:
                    Equipe *= 5;
                    break;
                case 4:
                    Equipe *= 7;
                    break;
                case 5:
                    Equipe *= 11;
                    break;
            }

            while(!Valid2)
            {
                Console.Write("Escolha 2: "); string escolha2 = Console.ReadLine(); 
                if(int.TryParse(escolha2, out number) && number > 0 && number <= 5) Valid2 = true;
                else{Console.Clear(); Console.WriteLine("Escolha inválida");}
            }
            switch(number)
            {
                case 1:
                    Equipe *= 2;
                    break;
                case 2:
                    Equipe *= 3;
                    break;
                case 3:
                    Equipe *= 5;
                    break;
                case 4:
                    Equipe *= 7;
                    break;
                case 5:
                    Equipe *= 11;
                    break;
            }

            while(!Valid3)
            {
                Console.Write("Escolha 3: "); string escolha3 = Console.ReadLine(); 
                if(int.TryParse(escolha3, out number) && number > 0 && number <= 5) Valid3 = true;
                else{Console.Clear(); Console.WriteLine("Escolha inválida");}
            }
            switch(number)
            {
                case 1:
                    Equipe *= 2;
                    break;
                case 2:
                    Equipe *= 3;
                    break;
                case 3:
                    Equipe *= 5;
                    break;
                case 4:
                    Equipe *= 7;
                    break;
                case 5:
                    Equipe *= 11;
                    break;
            }
            Console.WriteLine("Equipe selecionada!");
            Console.WriteLine("Aperte Enter pra prosseguir");
            Console.ReadLine();
            Console.Clear();
        }

        static void exibirEquipe()
        {
            Console.Clear();
            if(Equipe == 1)     Console.WriteLine("A equipe não foi selecionada ainda!");
            if(Equipe % 2 == 0) Console.WriteLine($"O(A) {Nome1} está presente! Ele possui o poder: {Poder1}; e a pontuação de: {Pontos1}");
            if(Equipe % 3 == 0) Console.WriteLine($"O(A) {Nome2} está presente! Ele possui o poder: {Poder2}; e a pontuação de: {Pontos2}");
            if(Equipe % 5 == 0) Console.WriteLine($"O(A) {Nome3} está presente! Ele possui o poder: {Poder3}; e a pontuação de: {Pontos3}");
            if(Equipe % 7 == 0) Console.WriteLine($"O(A) {Nome4} está presente! Ele possui o poder: {Poder4}; e a pontuação de: {Pontos4}");
            if(Equipe % 11 == 0) Console.WriteLine($"O(A) {Nome5} está presente! Ele possui o poder: {Poder5}; e a pontuação de: {Pontos5}");
            Console.WriteLine($"Pontuação total da equipe: {calcularPontuacaoTotal}");
            Console.WriteLine("\n Aperte Enter pra prosseguir");
            Console.ReadLine();
            Console.Clear();
        }

        static int calcularPontuacaoTotal()
        {
            int Total = 0;
            if(Equipe % 2 == 0)  Total += Convert.ToInt32(Pontos1);
            if(Equipe % 3 == 0)  Total += Convert.ToInt32(Pontos2);
            if(Equipe % 5 == 0)  Total += Convert.ToInt32(Pontos3);
            if(Equipe % 7 == 0)  Total += Convert.ToInt32(Pontos4);
            if(Equipe % 11 == 0) Total += Convert.ToInt32(Pontos5);
            return Total;
        }
    }
}
