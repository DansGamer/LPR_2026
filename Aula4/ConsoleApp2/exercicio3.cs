using System;

namespace Daniel
{
    class ClassesRPG
    {
        static void Main()
        {
            int Escolha = 0;
            bool Valid = false;
            while(!Valid)
            {
                Console.WriteLine("Escolha uma classe:");
                Console.WriteLine("1 - Guerreiro");
                Console.WriteLine("2 - Mago");
                Console.WriteLine("3 - Arqueiro");

                string Classe = Console.ReadLine();
                if(int.TryParse(Classe, out _))
                {
                    Valid = true;
                    Escolha = Convert.ToInt32(Classe);
                    switch(Escolha)
                    {
                        case 1:
                            Console.WriteLine("Você escolheu a classe Guerreiro!");
                            Console.WriteLine("Suas habilidades são: Ataque Pesado e Defesa Total");
                            break;
                        case 2:
                            Console.WriteLine("Você escolheu a classe Mago!");
                            Console.WriteLine("Suas habilidades são: Bola de Fogo e Escudo de Gelo");
                            break;
                        case 3:
                            Console.WriteLine("Você escolheu a classe Arqueiro!");
                            Console.WriteLine("Suas habilidades são: Flecha Precisa e Disparo Triplo");
                            break;
                        default:
                            Valid = false;
                            Console.WriteLine("A classe escolhida não é válida!");
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("O valor inserido não é uma classe válida!");
                }
                
            }
            
        }
    }
}