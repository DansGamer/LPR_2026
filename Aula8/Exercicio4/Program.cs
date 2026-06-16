using System;
using System.Collections;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Daniel
{
    class SelecaoHerois
    {
        struct Heroi
        {
            string Nome, Pontos, Poder;
        }

        static Heroi[] herois = new Heroi[5];

        static int Equipe = 1;

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
                    herois[0].Nome = Console.ReadLine();
                    Console.WriteLine("Insira a pontuação do primeiro herói:");
                    herois[0].Pontos = Console.ReadLine();
                    Console.WriteLine("Insira o poder do primeiro herói:");
                    herois[0].Poder = Console.ReadLine();
                }
                if(number >= 2)
                {
                    Console.WriteLine("Insira o nome do segundo herói:");
                    herois[1].Nome = Console.ReadLine();
                    Console.WriteLine("Insira a pontuação do segundo herói:");
                    herois[1].Pontos = Console.ReadLine();
                    Console.WriteLine("Insira o poder do segundo herói:");
                    herois[1].Poder = Console.ReadLine();
                }
                if(number >= 3)
                {
                    Console.WriteLine("Insira o nome do terceiro herói:");
                    herois[2].Nome = Console.ReadLine();
                    Console.WriteLine("Insira a pontuação do terceiro herói:");
                    herois[2].Pontos = Console.ReadLine();
                    Console.WriteLine("Insira o poder do terceiro herói:");
                    herois[2].Poder = Console.ReadLine();
                }
                if(number >= 4)
                {
                    Console.WriteLine("Insira o nome do quarto herói:");
                    herois[3].Nome = Console.ReadLine();
                    Console.WriteLine("Insira a pontuação do quarto herói:");
                    herois[3].Pontos = Console.ReadLine();
                    Console.WriteLine("Insira o poder do quarto herói:");
                    herois[3].Poder = Console.ReadLine();
                }
                if(number >= 5)
                {
                    Console.WriteLine("Insira o nome do quinto herói:");
                    herois[4].Nome = Console.ReadLine();
                    Console.WriteLine("Insira a pontuação do quinto herói:");
                    herois[4].Pontos = Console.ReadLine();
                    Console.WriteLine("Insira o poder do quinto herói:");
                    herois[4].Poder = Console.ReadLine();
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
            Console.WriteLine($"1){herois[0].Nome}, Poder: {herois[0].Poder}; Pontos: {herois[0].Pontos}");
            Console.WriteLine($"2){herois[1].Nome}, Poder: {herois[1].Poder}; Pontos: {herois[1].Pontos}");
            Console.WriteLine($"3){herois[2].Nome}, Poder: {herois[2].Poder}; Pontos: {herois[2].Pontos}");
            Console.WriteLine($"4){herois[3].Nome}, Poder: {herois[3].Poder}; Pontos: {herois[3].Pontos}");
            Console.WriteLine($"5){herois[4].Nome}, Poder: {herois[4].Poder}; Pontos: {herois[4].Pontos}");
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
            if(Equipe % 2 == 0) Console.WriteLine($"O(A) {herois[0].Nome} está presente! Ele possui o poder: {herois[0].Poder}; e a pontuação de: {herois[0].Pontos}");
            if(Equipe % 3 == 0) Console.WriteLine($"O(A) {herois[1].Nome} está presente! Ele possui o poder: {herois[1].Poder}; e a pontuação de: {herois[1].Pontos}");
            if(Equipe % 5 == 0) Console.WriteLine($"O(A) {herois[2].Nome} está presente! Ele possui o poder: {herois[2].Poder}; e a pontuação de: {herois[2].Pontos}");
            if(Equipe % 7 == 0) Console.WriteLine($"O(A) {herois[3].Nome} está presente! Ele possui o poder: {herois[3].Poder}; e a pontuação de: {herois[3].Pontos}");
            if(Equipe % 11 == 0) Console.WriteLine($"O(A) {herois[4].Nome} está presente! Ele possui o poder: {herois[4].Poder}; e a pontuação de: {herois[4].Pontos}");
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
